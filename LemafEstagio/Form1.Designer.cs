using System.Drawing;

namespace LemafEstagio
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bCarregar = new System.Windows.Forms.Button();
            this.textDiretorio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lvReservas = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.bGerarArquivo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.MinimumSize = new System.Drawing.Size(600, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(600, 106);
            this.label2.TabIndex = 3;
            this.label2.Text = "Meet Group Reservas";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 375);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Desenvolvido por: João Paulo Vilela Pereira";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // bCarregar
            // 
            this.bCarregar.Location = new System.Drawing.Point(452, 146);
            this.bCarregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bCarregar.Name = "bCarregar";
            this.bCarregar.Size = new System.Drawing.Size(104, 24);
            this.bCarregar.TabIndex = 5;
            this.bCarregar.Text = "Carregar arquivo...";
            this.bCarregar.UseVisualStyleBackColor = true;
            this.bCarregar.Click += new System.EventHandler(this.bCarregar_Click);
            // 
            // textDiretorio
            // 
            this.textDiretorio.Enabled = false;
            this.textDiretorio.Location = new System.Drawing.Point(40, 149);
            this.textDiretorio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textDiretorio.Name = "textDiretorio";
            this.textDiretorio.Size = new System.Drawing.Size(408, 20);
            this.textDiretorio.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Realizar reservas através de arquivo:";
            // 
            // lvReservas
            // 
            this.lvReservas.Location = new System.Drawing.Point(45, 223);
            this.lvReservas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvReservas.Name = "lvReservas";
            this.lvReservas.Size = new System.Drawing.Size(582, 102);
            this.lvReservas.TabIndex = 8;
            this.lvReservas.UseCompatibleStateImageBehavior = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 205);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Reservas feitas:";
            // 
            // bGerarArquivo
            // 
            this.bGerarArquivo.Location = new System.Drawing.Point(262, 330);
            this.bGerarArquivo.Name = "bGerarArquivo";
            this.bGerarArquivo.Size = new System.Drawing.Size(138, 23);
            this.bGerarArquivo.TabIndex = 10;
            this.bGerarArquivo.Text = "Gerar arquivo de texto";
            this.bGerarArquivo.UseVisualStyleBackColor = true;
            this.bGerarArquivo.Click += new System.EventHandler(this.bGerarArquivo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 402);
            this.Controls.Add(this.bGerarArquivo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lvReservas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textDiretorio);
            this.Controls.Add(this.bCarregar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Meet Group Reservas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bCarregar;
        private System.Windows.Forms.TextBox textDiretorio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lvReservas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bGerarArquivo;
    }
}

