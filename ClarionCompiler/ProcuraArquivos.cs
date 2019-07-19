using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClarionCompiler
{
    class ProcuraArquivos
    {
        public void Procurar(ListBox lstb, string pastaInicial, string padrao)
        {
            
            try
            {
                // Limpa a listbox
                lstb.Items.Clear();
                // Define os padrões
                string[] padroes = AnalisaPadroes(padrao);
                DirectoryInfo dir_info = new DirectoryInfo(pastaInicial);
                //Procura no diretório usando os padrões
                ProcuraDiretorio(lstb, dir_info, padroes);
                //exibe mensagem 
                //MessageBox.Show("Foram encontrados " + lstb.Items.Count + " arquivos.");
                //lblTotal.Text = lstb.Items.Count.ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void ProcuraDiretorio(ListBox lstb, DirectoryInfo dir_info, string[] padroes)
        {
            try
            {
                // Procura o diretorio
                foreach (string padrao in padroes)
                {
                    // Verifica o padrão
                    foreach (FileInfo Arq_info in dir_info.GetFiles(padrao))
                    {
                        // Processa o arquivo
                        ProcessaArquivo(lstb, Arq_info);
                    }
                }

                // Procura nos subdiretorios
                foreach (DirectoryInfo subdir_info in dir_info.GetDirectories())
                {
                    ProcuraDiretorio(lstb, subdir_info, padroes);
                }
            }
            catch
            {
                throw;
            }
        }

        private string[] AnalisaPadroes(string string_padrao)
        {
            try
            {
                // Pega tudo que esta entre os parenteses
                if (string_padrao.Contains("("))
                {
                    string_padrao = TextoEntre(string_padrao, "(", ")");
                }

                // divide a string em ;
                string[] resultado = string_padrao.Split(';');

                // Remove todos os padrões para espaço extra
                for (int i = 0; i < resultado.Length; i++)
                {
                    resultado[i] = resultado[i].Trim();
                }
                //retorna o resultado
                return resultado;
            }
            catch
            {
                throw;
            }
        }

        private void ProcessaArquivo(ListBox lstb, FileInfo arq_info)
        {
            try
            {
                //exibe o nome do arquivo no listbox
                lstb.Items.Add(arq_info.FullName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao processar o arquivo " + arq_info.FullName + "\n" + ex.Message, "Atenção");
            }
        }


        private string TextoEntre(string txt, string delimitador1, string delimitador2)
        {
            try
            {
                // Encontra o delimitador inicial
                int pos1 = txt.IndexOf(delimitador1);
                int texto_inicio = pos1 + delimitador1.Length;
                int pos2 = txt.IndexOf(delimitador2, texto_inicio);
                return txt.Substring(texto_inicio, pos2 - texto_inicio);
            }
            catch
            {
                throw;
            }
        }
    }
}
