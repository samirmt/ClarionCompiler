using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClarionCompiler
{
    class ManipularArquivo
    {
        static string path = AppDomain.CurrentDomain.BaseDirectory.ToString();
        static string arquivo = path + "projetos.msbuild";


        public void gerarProjetosMSBuild(string file, ListBox lstb, bool continuar)
        {
            try
            {
                verificaArquivo(true);
                StreamWriter sw;
                int count = lstb.Items.Count - 1;
                string projeto = "";
                StringBuilder texto = new StringBuilder();

                texto.Append("<?xml version='1.0' encoding='utf-8'?>\n");
                texto.AppendLine("<Project DefaultTargets='Circular' xmlns = 'http://schemas.microsoft.com/developer/msbuild/2003' > ");
                texto.AppendLine("\t<ItemGroup>");
                texto.AppendLine("\t\t<FirstPass Include = '");

                
                sw = new StreamWriter(file, true, Encoding.ASCII);

                for (int x = 0; x <= count; x++)
                {
                    projeto = lstb.Items[x].ToString() + ";";
                    texto.AppendLine("\t\t\t" + projeto);
                }
                
                texto.AppendLine("\t\t'/>");
                texto.AppendLine("\t</ItemGroup >");
                texto.AppendLine("\t<Target Name='Projetos'>");
                texto.AppendLine("\t\t<Message Text='Configuration is $(Configuration)' />");
                texto.AppendLine("\t\t<Message Text='Compilacao Iniciada'></Message>");
                texto.AppendLine("\t\t<MSBuild Projects='@(FirstPass)' Targets='Build' ContinueOnError='" + continuar + "' />");
                texto.AppendLine("\t\t<Message Text='Compilacao Concluida'></Message>");
                texto.AppendLine("\t</Target>");
                texto.AppendLine("</Project>");

                sw.Write(texto.ToString());
                sw.Flush();
                sw.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao gerar o arquivo MSBuild\n" + e.Message);
            }
        }

        public void importaLista(string lista, ListBox lsbx)
        {
            if (File.Exists(lista))
            {
                try
                {
                    using (StreamReader texto = new StreamReader(lista))
                    {
                        string mensagem = "";
                        lsbx.Items.Clear();
                        while ((mensagem = texto.ReadLine()) != null)
                        {
                            if (mensagem.Contains("cwproj"))
                            {
                                lsbx.Items.Add(mensagem.TrimStart());
                            }

                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Erro ao ler arquivo\n" + e.Message);
                }
            }
        }

        private bool verificaArquivo(bool excluir)
        {
            try
            {
                
                if (File.Exists(arquivo))
                {
                    if (excluir)
                    {
                        File.Delete("projetos.msbuild");
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return false;
            }
        }

    }
}
