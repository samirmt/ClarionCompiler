namespace EncontrarArquivos
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMsbuild = new System.Windows.Forms.TextBox();
            this.txtClarionBin = new System.Windows.Forms.TextBox();
            this.btnDiretorioInicial = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.fbd1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnGravar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Diretório do Clarion Bin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Diretorio MSBUILD:";
            // 
            // txtMsbuild
            // 
            this.txtMsbuild.Location = new System.Drawing.Point(15, 72);
            this.txtMsbuild.Name = "txtMsbuild";
            this.txtMsbuild.Size = new System.Drawing.Size(406, 20);
            this.txtMsbuild.TabIndex = 3;
            // 
            // txtClarionBin
            // 
            this.txtClarionBin.Location = new System.Drawing.Point(15, 25);
            this.txtClarionBin.Name = "txtClarionBin";
            this.txtClarionBin.Size = new System.Drawing.Size(406, 20);
            this.txtClarionBin.TabIndex = 4;
            // 
            // btnDiretorioInicial
            // 
            this.btnDiretorioInicial.Image = ((System.Drawing.Image)(resources.GetObject("btnDiretorioInicial.Image")));
            this.btnDiretorioInicial.Location = new System.Drawing.Point(428, 72);
            this.btnDiretorioInicial.Margin = new System.Windows.Forms.Padding(4);
            this.btnDiretorioInicial.Name = "btnDiretorioInicial";
            this.btnDiretorioInicial.Size = new System.Drawing.Size(42, 23);
            this.btnDiretorioInicial.TabIndex = 5;
            this.btnDiretorioInicial.UseVisualStyleBackColor = true;
            this.btnDiretorioInicial.Click += new System.EventHandler(this.btnDiretorioInicial_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(428, 25);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 23);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(395, 125);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 7;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 178);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDiretorioInicial);
            this.Controls.Add(this.txtClarionBin);
            this.Controls.Add(this.txtMsbuild);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMsbuild;
        private System.Windows.Forms.TextBox txtClarionBin;
        private System.Windows.Forms.Button btnDiretorioInicial;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog fbd1;
        private System.Windows.Forms.Button btnGravar;
    }
}