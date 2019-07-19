namespace EncontrarArquivos
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtPastaInicial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDiretorioInicial = new System.Windows.Forms.Button();
            this.lbArquivos = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.cboPadraoArquivos = new System.Windows.Forms.ComboBox();
            this.fbd1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnCompilar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lbSelecionados = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSelecionados = new System.Windows.Forms.Label();
            this.btnTodos = new System.Windows.Forms.Button();
            this.btnRemoverTodos = new System.Windows.Forms.Button();
            this.btnAdicionaSelecionado = new System.Windows.Forms.Button();
            this.btnRemoverSelecionado = new System.Windows.Forms.Button();
            this.chkContinuarSeErro = new System.Windows.Forms.CheckBox();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.txtLocaliza = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPastaInicial
            // 
            this.txtPastaInicial.Location = new System.Drawing.Point(25, 30);
            this.txtPastaInicial.Margin = new System.Windows.Forms.Padding(4);
            this.txtPastaInicial.Name = "txtPastaInicial";
            this.txtPastaInicial.Size = new System.Drawing.Size(270, 22);
            this.txtPastaInicial.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pasta Inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Padrão de arquivos ";
            // 
            // btnDiretorioInicial
            // 
            this.btnDiretorioInicial.Image = ((System.Drawing.Image)(resources.GetObject("btnDiretorioInicial.Image")));
            this.btnDiretorioInicial.Location = new System.Drawing.Point(303, 30);
            this.btnDiretorioInicial.Margin = new System.Windows.Forms.Padding(4);
            this.btnDiretorioInicial.Name = "btnDiretorioInicial";
            this.btnDiretorioInicial.Size = new System.Drawing.Size(61, 23);
            this.btnDiretorioInicial.TabIndex = 2;
            this.btnDiretorioInicial.UseVisualStyleBackColor = true;
            this.btnDiretorioInicial.Click += new System.EventHandler(this.btnDiretorioInicial_Click);
            // 
            // lbArquivos
            // 
            this.lbArquivos.ForeColor = System.Drawing.Color.Blue;
            this.lbArquivos.FormattingEnabled = true;
            this.lbArquivos.ItemHeight = 16;
            this.lbArquivos.Location = new System.Drawing.Point(16, 178);
            this.lbArquivos.Margin = new System.Windows.Forms.Padding(4);
            this.lbArquivos.Name = "lbArquivos";
            this.lbArquivos.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbArquivos.Size = new System.Drawing.Size(388, 308);
            this.lbArquivos.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Projetos Encontrados:";
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocalizar.Location = new System.Drawing.Point(13, 505);
            this.btnLocalizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(106, 41);
            this.btnLocalizar.TabIndex = 5;
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.UseVisualStyleBackColor = true;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // btnSair
            // 
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(759, 505);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(105, 41);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // cboPadraoArquivos
            // 
            this.cboPadraoArquivos.FormattingEnabled = true;
            this.cboPadraoArquivos.Items.AddRange(new object[] {
            "CLARION(*.cwproj)"});
            this.cboPadraoArquivos.Location = new System.Drawing.Point(25, 75);
            this.cboPadraoArquivos.Name = "cboPadraoArquivos";
            this.cboPadraoArquivos.Size = new System.Drawing.Size(320, 24);
            this.cboPadraoArquivos.TabIndex = 6;
            this.cboPadraoArquivos.SelectedIndexChanged += new System.EventHandler(this.cboPadraoArquivos_SelectedIndexChanged);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(696, 150);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(81, 25);
            this.btnExportar.TabIndex = 7;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnCompilar
            // 
            this.btnCompilar.Location = new System.Drawing.Point(298, 505);
            this.btnCompilar.Name = "btnCompilar";
            this.btnCompilar.Size = new System.Drawing.Size(106, 41);
            this.btnCompilar.TabIndex = 8;
            this.btnCompilar.Text = "Compilar";
            this.btnCompilar.UseVisualStyleBackColor = true;
            this.btnCompilar.Click += new System.EventHandler(this.btnCompilar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(150, 156);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(15, 16);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "0";
            // 
            // lbSelecionados
            // 
            this.lbSelecionados.Enabled = false;
            this.lbSelecionados.FormattingEnabled = true;
            this.lbSelecionados.ItemHeight = 16;
            this.lbSelecionados.Location = new System.Drawing.Point(477, 178);
            this.lbSelecionados.Name = "lbSelecionados";
            this.lbSelecionados.Size = new System.Drawing.Size(388, 308);
            this.lbSelecionados.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(474, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Projetos Selecionados:";
            // 
            // lblSelecionados
            // 
            this.lblSelecionados.AutoSize = true;
            this.lblSelecionados.Location = new System.Drawing.Point(621, 156);
            this.lblSelecionados.Name = "lblSelecionados";
            this.lblSelecionados.Size = new System.Drawing.Size(15, 16);
            this.lblSelecionados.TabIndex = 15;
            this.lblSelecionados.Text = "0";
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(411, 236);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(60, 27);
            this.btnTodos.TabIndex = 16;
            this.btnTodos.Text = ">>";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // btnRemoverTodos
            // 
            this.btnRemoverTodos.Location = new System.Drawing.Point(412, 269);
            this.btnRemoverTodos.Name = "btnRemoverTodos";
            this.btnRemoverTodos.Size = new System.Drawing.Size(59, 27);
            this.btnRemoverTodos.TabIndex = 17;
            this.btnRemoverTodos.Text = "<<";
            this.btnRemoverTodos.UseVisualStyleBackColor = true;
            this.btnRemoverTodos.Click += new System.EventHandler(this.btnRemoverTodos_Click);
            // 
            // btnAdicionaSelecionado
            // 
            this.btnAdicionaSelecionado.Location = new System.Drawing.Point(412, 348);
            this.btnAdicionaSelecionado.Name = "btnAdicionaSelecionado";
            this.btnAdicionaSelecionado.Size = new System.Drawing.Size(59, 27);
            this.btnAdicionaSelecionado.TabIndex = 18;
            this.btnAdicionaSelecionado.Text = ">";
            this.btnAdicionaSelecionado.UseVisualStyleBackColor = true;
            this.btnAdicionaSelecionado.Click += new System.EventHandler(this.btnAdicionaSelecionado_Click);
            // 
            // btnRemoverSelecionado
            // 
            this.btnRemoverSelecionado.Location = new System.Drawing.Point(412, 381);
            this.btnRemoverSelecionado.Name = "btnRemoverSelecionado";
            this.btnRemoverSelecionado.Size = new System.Drawing.Size(59, 27);
            this.btnRemoverSelecionado.TabIndex = 19;
            this.btnRemoverSelecionado.Text = "<";
            this.btnRemoverSelecionado.UseVisualStyleBackColor = true;
            this.btnRemoverSelecionado.Click += new System.EventHandler(this.btnRemoverSelecionado_Click);
            // 
            // chkContinuarSeErro
            // 
            this.chkContinuarSeErro.AutoSize = true;
            this.chkContinuarSeErro.Location = new System.Drawing.Point(477, 75);
            this.chkContinuarSeErro.Name = "chkContinuarSeErro";
            this.chkContinuarSeErro.Size = new System.Drawing.Size(228, 20);
            this.chkContinuarSeErro.TabIndex = 20;
            this.chkContinuarSeErro.Text = "Continuar compilação se der erro.";
            this.chkContinuarSeErro.UseVisualStyleBackColor = true;
            // 
            // btnConfig
            // 
            this.btnConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfig.Location = new System.Drawing.Point(477, 506);
            this.btnConfig.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(105, 41);
            this.btnConfig.TabIndex = 21;
            this.btnConfig.Text = "Configurações";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(619, 505);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(105, 41);
            this.btnLimpar.TabIndex = 22;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(783, 150);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(81, 25);
            this.btnImportar.TabIndex = 23;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // txtLocaliza
            // 
            this.txtLocaliza.Location = new System.Drawing.Point(280, 154);
            this.txtLocaliza.Name = "txtLocaliza";
            this.txtLocaliza.Size = new System.Drawing.Size(124, 22);
            this.txtLocaliza.TabIndex = 24;
            this.txtLocaliza.TextChanged += new System.EventHandler(this.txtLocaliza_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(282, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Procurar:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(883, 558);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLocaliza);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.chkContinuarSeErro);
            this.Controls.Add(this.btnRemoverSelecionado);
            this.Controls.Add(this.btnAdicionaSelecionado);
            this.Controls.Add(this.btnRemoverTodos);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.lblSelecionados);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbSelecionados);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnCompilar);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.cboPadraoArquivos);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLocalizar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbArquivos);
            this.Controls.Add(this.btnDiretorioInicial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPastaInicial);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COMPILADOR PARA CLARION 9";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPastaInicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDiretorioInicial;
        private System.Windows.Forms.ListBox lbArquivos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ComboBox cboPadraoArquivos;
        private System.Windows.Forms.FolderBrowserDialog fbd1;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnCompilar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ListBox lbSelecionados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSelecionados;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.Button btnRemoverTodos;
        private System.Windows.Forms.Button btnAdicionaSelecionado;
        private System.Windows.Forms.Button btnRemoverSelecionado;
        private System.Windows.Forms.CheckBox chkContinuarSeErro;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.TextBox txtLocaliza;
        private System.Windows.Forms.Label label5;
    }
}

