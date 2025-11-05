namespace GeradorCodigoDeBarras
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictCodigo = new System.Windows.Forms.TextBox();
            this.pictCodigoSaida = new System.Windows.Forms.PictureBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.labelGeradorCodigo = new System.Windows.Forms.Label();
            this.Btn_Imprimir = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictCodigoSaida)).BeginInit();
            this.SuspendLayout();
            // 
            // pictCodigo
            // 
            this.pictCodigo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictCodigo.Location = new System.Drawing.Point(207, 133);
            this.pictCodigo.MaximumSize = new System.Drawing.Size(500, 200);
            this.pictCodigo.Name = "pictCodigo";
            this.pictCodigo.Size = new System.Drawing.Size(189, 25);
            this.pictCodigo.TabIndex = 0;
            this.pictCodigo.TextChanged += new System.EventHandler(this.pictCodigo_TextChanged);
            // 
            // pictCodigoSaida
            // 
            this.pictCodigoSaida.BackColor = System.Drawing.Color.Gainsboro;
            this.pictCodigoSaida.Location = new System.Drawing.Point(99, 196);
            this.pictCodigoSaida.Name = "pictCodigoSaida";
            this.pictCodigoSaida.Size = new System.Drawing.Size(406, 73);
            this.pictCodigoSaida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictCodigoSaida.TabIndex = 1;
            this.pictCodigoSaida.TabStop = false;
            this.pictCodigoSaida.Click += new System.EventHandler(this.pictCodigoSaida_Click);
            // 
            // btnGerar
            // 
            this.btnGerar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGerar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnGerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.ForeColor = System.Drawing.Color.White;
            this.btnGerar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGerar.Location = new System.Drawing.Point(416, 135);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(89, 25);
            this.btnGerar.TabIndex = 2;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGerar.UseVisualStyleBackColor = false;
            this.btnGerar.Click += new System.EventHandler(this.Btn_gerar_Click);
            // 
            // labelGeradorCodigo
            // 
            this.labelGeradorCodigo.AutoSize = true;
            this.labelGeradorCodigo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGeradorCodigo.ForeColor = System.Drawing.Color.Black;
            this.labelGeradorCodigo.Location = new System.Drawing.Point(182, 32);
            this.labelGeradorCodigo.MaximumSize = new System.Drawing.Size(500, 300);
            this.labelGeradorCodigo.Name = "labelGeradorCodigo";
            this.labelGeradorCodigo.Size = new System.Drawing.Size(292, 30);
            this.labelGeradorCodigo.TabIndex = 3;
            this.labelGeradorCodigo.Text = "Gerador de código de barras";
            this.labelGeradorCodigo.Click += new System.EventHandler(this.label1_Click);
            // 
            // Btn_Imprimir
            // 
            this.Btn_Imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Imprimir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Imprimir.ForeColor = System.Drawing.Color.Black;
            this.Btn_Imprimir.Location = new System.Drawing.Point(506, 343);
            this.Btn_Imprimir.Name = "Btn_Imprimir";
            this.Btn_Imprimir.Size = new System.Drawing.Size(125, 28);
            this.Btn_Imprimir.TabIndex = 4;
            this.Btn_Imprimir.Text = "Imprimir";
            this.Btn_Imprimir.UseVisualStyleBackColor = true;
            this.Btn_Imprimir.Click += new System.EventHandler(this.Btn_Imprimir_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Digite o código";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnGerar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnGerar;
            this.ClientSize = new System.Drawing.Size(633, 374);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Imprimir);
            this.Controls.Add(this.labelGeradorCodigo);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.pictCodigoSaida);
            this.Controls.Add(this.pictCodigo);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictCodigoSaida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pictCodigo;
        private System.Windows.Forms.PictureBox pictCodigoSaida;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Label labelGeradorCodigo;
        private System.Windows.Forms.Button Btn_Imprimir;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Label label1;
    }
}

