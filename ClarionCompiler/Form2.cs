using ClarionCompiler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncontrarArquivos
{
    public partial class Form2 : Form
    {
        public delegate void InvokeDelegate();
        Stopwatch cronometro = new Stopwatch();
        ManipularArquivo manipularArquivo = new ManipularArquivo();
        List<string> lstproj = new List<string>();
        DateTime dt1;
        string clarionbin = "";
        string msbuild = "";
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var config = new IniFile("Settings.ini");
            clarionbin = @config.Read("CLARIONBIN", "SETTINGS");
            msbuild = @config.Read("MSBUILD", "SETTINGS") + "/MSBuild.exe";
            lblStatus.Text = "Aguarde compilando...";
            groupBox1.Enabled = false;
            dt1 = DateTime.Now;
            lblIniciado.Text = DateTime.Now.ToString();
            this.BeginInvoke(new InvokeDelegate(startCompilador));
            carregaSelecionados();
        }

        private void startCompilador()
        {
            Thread t = new Thread(compilar);
            t.Start();
            cronometro.Reset();
            cronometro.Start();
            timer1.Start();
        }             

        public void finalizarTimer()
        {
            lblStatus.Text = "Processo concluído!";            
            lerRetorno();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            if (File.Exists("log_resumo.log"))
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.RedirectStandardInput = true;
                cmd.StartInfo.RedirectStandardOutput = true;
                cmd.StartInfo.CreateNoWindow = true;
                cmd.StartInfo.UseShellExecute = false;
                cmd.Start();

                cmd.StandardInput.WriteLine("log_resumo.log");
                cmd.StandardInput.Flush();
                cmd.StandardInput.Close();
                cmd.WaitForExit();
            }
            else
            {
                MessageBox.Show("LOG não econtrado!");
            }
        }      

        private void lerRetorno()
        {
            int cntErro = 0;
            int cntAcerto = 0;
            string line, linha;
            string duracao = lblDuracao.Text;
            StringBuilder sbErros = new StringBuilder();
            StringBuilder sbAcerto = new StringBuilder();
             
            // Read the file and display it line by line.  
            StreamReader file = new StreamReader("log_compilacao.log");
            while ((line = file.ReadLine()) != null)
            {
                if (line.Contains("Time Elapsed") || line.Contains("Tempo Decorrido"))
                {
                    duracao = line.Substring(line.Length - 11, 8);
                }
                if (line.Contains("Done building project") || line.Contains("Projeto de compila"))
                {
                    linha = line;
                    if (linha.Contains("FAILED") || linha.Contains("FALHA"))
                    {
                        sbErros.AppendLine(linha);
                        cntErro += 1;

                        linha = linha.TrimStart();
                        string[] p = linha.Split('"');

                        foreach (var item in p)
                        {
                            if (item.Contains("cwproj"))
                            {
                                procuraNaLista(item.ToString(), Color.Red);
                            }
                        }
                    }
                    else
                    {
                        sbAcerto.AppendLine(linha);
                        cntAcerto += 1;

                        linha = linha.TrimStart();
                        string[] p = linha.Split('"');

                        foreach (var item in p)
                        {
                            if (item.Contains("cwproj"))
                            {
                                procuraNaLista(item.ToString(), Color.Green);
                            }
                        }
                    }
                }
            }

            file.Close();
            
            gravaLog(sbAcerto.ToString(), sbErros.ToString(), cntAcerto, cntErro);                      
        }

        private void gravaLog(string sucesso, string falhas, int acertos, int erros)
        {
            try
            {
                StreamWriter sw = new StreamWriter("log_resumo.log");
                sw.WriteLine("Resumo do processo de compilação!");
                sw.WriteLine("");
                sw.WriteLine("");
                sw.WriteLine("Projeto(s) concluído com falha: (" + erros + ")");
                sw.WriteLine(falhas);
                sw.WriteLine("---------------------------------------------------------");
                sw.WriteLine("");
                sw.WriteLine("Projeto(s) concluído com sucesso: (" + acertos + ")");
                sw.WriteLine(sucesso);
                sw.WriteLine("---------------------------------------------------------");
                sw.WriteLine("");
                sw.WriteLine("Elapsed time: " + lblDuracao.Text );
                sw.Flush();
                sw.Close();
                cronometro.Stop();
                timer1.Stop();
                groupBox1.Enabled = true;
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void compilar()
        {
            try
            {
                string projetos = "projetos.msbuild";
                string par1 = "/p:ClarionBinPath=" + clarionbin;
                string par2 = "/p:NoDependency='true'";
                string par3 = "/p:Configuration='Release'";
                string par4 = "/p:CopyCoreFiles='true'";
                string par5 = "/target:Projetos > log_compilacao.log";
                string esp = " ";
                string parametros = par1 + esp + par2 + esp + par3 + esp + par4 + esp + par5;

                string comando = msbuild + esp + projetos + esp + parametros;

                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.RedirectStandardInput = true;
                cmd.StartInfo.RedirectStandardOutput = true;
                cmd.StartInfo.CreateNoWindow = true;
                cmd.StartInfo.UseShellExecute = false;
                cmd.Start();

                cmd.StandardInput.WriteLine(comando);
                cmd.StandardInput.Flush();
                cmd.StandardInput.Close();
                cmd.WaitForExit();
                this.BeginInvoke(new InvokeDelegate(finalizarTimer));
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLogCompleto_Click(object sender, EventArgs e)
        {
            if (File.Exists("log_compilacao.log"))
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.RedirectStandardInput = true;
                cmd.StartInfo.RedirectStandardOutput = true;
                cmd.StartInfo.CreateNoWindow = true;
                cmd.StartInfo.UseShellExecute = false;
                cmd.Start();

                cmd.StandardInput.WriteLine("log_compilacao.log");
                cmd.StandardInput.Flush();
                cmd.StandardInput.Close();
                cmd.WaitForExit();
            }
            else
            {
                MessageBox.Show("Arquivo de LOG não eonctrado!");
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDuracao.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", cronometro.Elapsed.Hours, cronometro.Elapsed.Minutes, cronometro.Elapsed.Seconds, cronometro.Elapsed.Milliseconds / 10);
        }


        private void carregaSelecionados()
        {
            ListBox lb = new ListBox();
            manipularArquivo.importaLista("projetos.msbuild", lb);

            foreach (var item in lb.Items)
            {
                lvProjetos.Items.Add(separaNome(item.ToString()));
                lstproj.Add(separaNome(item.ToString()));
            }

        }

        private string separaNome(string texto)
        {
            string retorno = "";
            string v1 = @"\";
            string v2 = "-";

            string linha = texto.TrimStart();
            linha = linha.Replace(v1, v2);
                        
            string[] p = linha.Split('-');

            foreach (var item in p)
            {
                if (item.ToString().Contains("cwproj"))
                {
                    retorno = item.ToString().Substring(0, item.ToString().Length - 1);
                }
            }
            
            return retorno;
        }       


        private void procuraNaLista(string texto, Color cor)
        {
            for (int i = 0; i < lvProjetos.Items.Count; i++)
            {
                if(lvProjetos.Items[i].Text.Contains(texto))
                {
                    Console.WriteLine(texto);
                    lvProjetos.Items[i].BackColor = cor;
                }
            }
        }


    }
}
