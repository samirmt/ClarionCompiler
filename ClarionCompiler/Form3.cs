using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncontrarArquivos
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                fbd1.SelectedPath = txtClarionBin.Text;
                if (fbd1.ShowDialog() == DialogResult.OK)
                {
                    txtClarionBin.Text = fbd1.SelectedPath;
                }
            }
            catch
            {
                throw;
            }
        }

        private void btnDiretorioInicial_Click(object sender, EventArgs e)
        {
            try
            {
                fbd1.SelectedPath = txtMsbuild.Text;
                if (fbd1.ShowDialog() == DialogResult.OK)
                {
                    txtMsbuild.Text = fbd1.SelectedPath;
                }
            }
            catch
            {
                throw;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (File.Exists("Settings.ini"))
            {
                var config = new IniFile("Settings.ini");
                txtClarionBin.Text = config.Read("CLARIONBIN", "SETTINGS");
                txtMsbuild.Text = config.Read("MSBUILD", "SETTINGS");
                btnDiretorioInicial.Focus();
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if(txtClarionBin.Text != "" && txtMsbuild.Text != "")
            {
                try
                {
                    var config = new IniFile("Settings.ini");
                    config.Write("CLARIONBIN", txtClarionBin.Text, "SETTINGS");
                    config.Write("MSBUILD", txtMsbuild.Text, "SETTINGS");
                    MessageBox.Show("Configurações salvas com sucesso!");
                }catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro!\n" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            
        }
    }
}
