namespace EncontrarArquivos
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.lblIniciado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDuracao = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnLogResumido = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLogCompleto = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lvProjetos = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Iniciado:";
            // 
            // lblIniciado
            // 
            this.lblIniciado.AutoSize = true;
            this.lblIniciado.Location = new System.Drawing.Point(95, 45);
            this.lblIniciado.Name = "lblIniciado";
            this.lblIniciado.Size = new System.Drawing.Size(49, 13);
            this.lblIniciado.TabIndex = 1;
            this.lblIniciado.Text = "00:00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Duração:";
            // 
            // lblDuracao
            // 
            this.lblDuracao.AutoSize = true;
            this.lblDuracao.Location = new System.Drawing.Point(95, 70);
            this.lblDuracao.Name = "lblDuracao";
            this.lblDuracao.Size = new System.Drawing.Size(49, 13);
            this.lblDuracao.TabIndex = 5;
            this.lblDuracao.Text = "00:00:00";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(23, 9);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(164, 16);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Aguarde compilando...";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogResumido
            // 
            this.btnLogResumido.Location = new System.Drawing.Point(11, 32);
            this.btnLogResumido.Name = "btnLogResumido";
            this.btnLogResumido.Size = new System.Drawing.Size(75, 23);
            this.btnLogResumido.TabIndex = 7;
            this.btnLogResumido.Text = "Resumido";
            this.btnLogResumido.UseVisualStyleBackColor = true;
            this.btnLogResumido.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLogCompleto);
            this.groupBox1.Controls.Add(this.btnLogResumido);
            this.groupBox1.Location = new System.Drawing.Point(15, 306);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 74);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Logs";
            // 
            // btnLogCompleto
            // 
            this.btnLogCompleto.Location = new System.Drawing.Point(99, 32);
            this.btnLogCompleto.Name = "btnLogCompleto";
            this.btnLogCompleto.Size = new System.Drawing.Size(75, 23);
            this.btnLogCompleto.TabIndex = 8;
            this.btnLogCompleto.Text = "Completo";
            this.btnLogCompleto.UseVisualStyleBackColor = true;
            this.btnLogCompleto.Click += new System.EventHandler(this.btnLogCompleto_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lvProjetos
            // 
            this.lvProjetos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvProjetos.Location = new System.Drawing.Point(12, 86);
            this.lvProjetos.MultiSelect = false;
            this.lvProjetos.Name = "lvProjetos";
            this.lvProjetos.Size = new System.Drawing.Size(189, 214);
            this.lvProjetos.TabIndex = 9;
            this.lvProjetos.UseCompatibleStateImageBehavior = false;
            this.lvProjetos.View = System.Windows.Forms.View.List;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 392);
            this.Controls.Add(this.lvProjetos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblDuracao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblIniciado);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIniciado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDuracao;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnLogResumido;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLogCompleto;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListView lvProjetos;
    }
}