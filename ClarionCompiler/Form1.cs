using ClarionCompiler;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using static EncontrarArquivos.Form2;

namespace EncontrarArquivos
{
    public partial class Form1 : Form
    {
        ProcuraArquivos procuraArquivos = new ProcuraArquivos();
        ManipularArquivo manipularArquivo = new ManipularArquivo();
        List<string> lstproj = new List<string>();
        static string path = AppDomain.CurrentDomain.BaseDirectory.ToString();
        static string arquivo = path + "projetos.msbuild";
        static string clarionbin = "";
        static string msbuild = "";
        public Form1()
        {
            InitializeComponent();
        }

        // Recupera as configurações
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "COMPILADOR PARA CLARION 9 - VERSÃO: " + getVersion();
            txtPastaInicial.Text = "";//Properties.Settings.Default.PastaInicial;
            cboPadraoArquivos.Text = "CLARION(*.cwproj)";// Properties.Settings.Default.PadraoArquivos;
            chkContinuarSeErro.Checked = true;
            if (!File.Exists("Settings.ini"))
            {
                MessageBox.Show("Aplicativo não está configurado!\nEdite as configurações!","Atenção");
            }
            else
            {
                var config = new IniFile("Settings.ini");
                clarionbin = @config.Read("CLARIONBIN", "SETTINGS");
                msbuild = @config.Read("MSBUILD", "SETTINGS") + "/MSBuild.exe";
            }
            
        }
                

        //define a pasta inicial para buscar os arquivos
        private void btnDiretorioInicial_Click(object sender, EventArgs e)
        {
            try
            {
                fbd1.SelectedPath = txtPastaInicial.Text;
                if (fbd1.ShowDialog() == DialogResult.OK)
                {
                    txtPastaInicial.Text = fbd1.SelectedPath;
                }
            }
            catch
            {
                throw;
            }
        }

        //Chama o método ProcurarArquivos passando os valores
        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPastaInicial.Text) && cboPadraoArquivos.SelectedIndex != -1)
            {
                procuraArquivos.Procurar(lbArquivos, txtPastaInicial.Text, cboPadraoArquivos.Text);
                lblTotal.Text = lbArquivos.Items.Count.ToString();
                var p = new ProjetosModel();
                string v1 = "\\";
                string v2 = "/";
                foreach (var item in lbArquivos.Items)
                {
                    p.nome = item.ToString().Replace(v1, v2);
                    lstproj.Add(p.nome);
                }
            }
            else
            {
                MessageBox.Show("Defina a pasta incial de busca e/ou o padrão de arquivos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }       
        
       
        private void btnExportar_Click(object sender, EventArgs e)
        {             
            if(lbSelecionados.Items.Count > 0)
            {
                try
                {
                    string filename = Interaction.InputBox("Digite o nome do arquivo:");
                    filename += ".msbuild";

                   if(filename != "")
                    {
                        manipularArquivo.gerarProjetosMSBuild(filename, lbSelecionados, chkContinuarSeErro.Checked);
                        //gerarProjetosMSBuild(filename);
                        MessageBox.Show("Exportado com sucesso!", "Clarion Compiler");
                    }
                    else
                    {
                        MessageBox.Show("Digite um nome válido!", "Clarion Compiler");
                    }
                }catch (Exception ex)
                {
                    MessageBox.Show("Erro a gerar o projetos.msbuild!:\n" + ex.Message.ToString(), "Atenção");
                }
                
            }
            else
            {
                MessageBox.Show("Não há itens para exportar!", "Atenção");
            }
           
        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void btnCompilar_Click(object sender, EventArgs e)
        {
            if (lbSelecionados.Items.Count > 0)
            {
                manipularArquivo.gerarProjetosMSBuild(arquivo, lbSelecionados, chkContinuarSeErro.Checked);
            }
            else
            {
                MessageBox.Show("Não há projetos selecionados!", "Atenção");
                return;
            }
                        
            if (verificaArquivo(false))
            {
                try
                {
                    this.BeginInvoke(new Action(chamaFormStatus));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            else
            {
                MessageBox.Show("projetos.msbuild não encontrado!", "Atenção");
            }
            
        }
        
        private void chamaFormStatus()
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            lbSelecionados.Enabled = false;
        }
        

        private bool verificaArquivo(bool excluir)
        {
            try
            {
                if (File.Exists(arquivo))
                {
                    if (excluir)
                    {
                        File.Delete(arquivo);
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return false;
            }
        }
                
        private void deselecionaItens(ListBox lst)
        {
            int count = lst.Items.Count - 1;

            for (int x = 0; x <= count; x++)
            {
                lst.SetSelected(x, false);
            }
        } 
        
        private void copiarItens()
        {
            int count = lbArquivos.Items.Count - 1;

            for(int x = 0; x <= count; x++)
            {
                lbSelecionados.Items.Add(lbArquivos.Items[x]);
            }
            lblSelecionados.Text = lbSelecionados.Items.Count.ToString();
            lbSelecionados.Enabled = true;
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            if(lbArquivos.Items.Count > 0)
            {
                copiarItens();
            }
            else
            {
                MessageBox.Show("Não há projetos para adicionar!", "Atenção");
            }
        }

        private void btnRemoverTodos_Click(object sender, EventArgs e)
        {
            if (lbSelecionados.Items.Count > 0)
            {
                lbSelecionados.Items.Clear();
                lblSelecionados.Text = "0";
            }
        }

        private void btnAdicionaSelecionado_Click(object sender, EventArgs e)
        {
            if (lbArquivos.Items.Count > 0)
            {
                if (lbArquivos.SelectedIndex >= 0)
                {
                    foreach (var item in lbArquivos.SelectedItems)
                    {                         
                        if (verificaSeExsite(item.ToString()))
                        {
                            MessageBox.Show("Projeto já adicionado!", "Atenção");
                        }
                        else
                        {
                            lbSelecionados.Items.Add(item.ToString());
                        }
                    }
                    deselecionaItens(lbArquivos);
                    lblSelecionados.Text = lbSelecionados.Items.Count.ToString();
                    lbSelecionados.Enabled = true;                   
                }
                else
                {
                    MessageBox.Show("Não há projeto selecionado!", "Atenção");
                }
                
            }
            else
            {
                MessageBox.Show("Não há projeto para adicionar!", "Atenção");
            }
        }

        private bool verificaSeExsite(string searchString)
        {
            bool result = false;
            // Ensure we have a proper string to search for.
            if (searchString != string.Empty)
            {
                // Find the item in the list and store the index to the item.
                int index = lbSelecionados.FindString(searchString);
                // Determine if a valid index is returned. Select the item if it is valid.
                if (index != -1)
                    result = true;
                else
                   result = false;
            }
            return result;
        }

        private void btnRemoverSelecionado_Click(object sender, EventArgs e)
        {
            if (lbSelecionados.Items.Count > 0)
            {
                if (lbSelecionados.SelectedIndex >= 0)
                {
                    string selecionado = lbSelecionados.SelectedItem.ToString();
                    lbSelecionados.Items.Remove(selecionado);
                    lblSelecionados.Text = lbSelecionados.Items.Count.ToString();

                    if (lbSelecionados.Items.Count == 0)
                    {
                        lbSelecionados.Enabled = false;
                    }
                    else
                    {
                        deselecionaItens(lbSelecionados);
                    }
                }
                else
                {
                    MessageBox.Show("Não há projeto selecionado!", "Atenção");
                }

            }
            else
            {
                lbSelecionados.Enabled = false;
            }
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //lbArquivos.Items.Clear();
            lbSelecionados.Items.Clear();
            lblSelecionados.Text = lbSelecionados.Items.Count.ToString();
            txtLocaliza.Text = "";
            deselecionaItens(lbArquivos);
            //lblTotal.Text = lbArquivos.Items.Count.ToString();
            if (File.Exists("projetos.msbuild"))
            {
                File.Delete("projetos.msbuild");
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            try
            {
                ofd.Title = "Selecione um arquivo";
                ofd.Filter = "MSBuild (*.msbuild)|*.msbuild";
                ofd.FilterIndex = 1;
                ofd.FileName = "";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    manipularArquivo.importaLista(ofd.FileName, lbSelecionados);
                    lblSelecionados.Text = lbSelecionados.Items.Count.ToString();
                    lbSelecionados.Enabled = true;
                    if (File.Exists("projetos.msbuild"))
                    {
                        File.Delete("projetos.msbuild");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string getVersion()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);

            return fvi.FileVersion;
        }

        private void txtLocaliza_TextChanged(object sender, EventArgs e)
        {
           if(txtLocaliza.Text.Length > 5 && lbArquivos.Items.Count > 0)
            {
                int index = procuraNaLista(txtLocaliza.Text.ToUpper(), lbArquivos);
                lbArquivos.SelectedIndex = index;
            }
            else
            {
                deselecionaItens(lbArquivos);
            }
        }

        private int procuraNaLista(string texto, ListBox lsb)
        {
            string v1 = "/";
            string v2 = @"\" ;
            string retorno = "";
            int index = 0;

            IEnumerable<string> result = lstproj.Where(s => s.Contains(texto));

            foreach (var item in result)
            {
                retorno = item.ToString();
            }

            retorno = retorno.Replace(v1, v2);

            if (lsb.SelectedIndex + 1 == lsb.Items.Count)
            {
                lsb.SelectedIndex = -1;
            }
            index = lsb.FindString(retorno);
            return index;
            //lsb.SelectedIndex = lsb.FindString(retorno);
        }

        private void cboPadraoArquivos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
