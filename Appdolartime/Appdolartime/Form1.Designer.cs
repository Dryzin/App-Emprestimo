namespace Appdolartime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtemprestimo = new System.Windows.Forms.MaskedTextBox();
            this.CotacaoDolar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textjurosAnual = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Button();
            this.txtValorporMes = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.parcelasBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttotalpago = new System.Windows.Forms.Label();
            this.txttotaljuros = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtemprestimo
            // 
            this.txtemprestimo.Location = new System.Drawing.Point(220, 94);
            this.txtemprestimo.Name = "txtemprestimo";
            this.txtemprestimo.Size = new System.Drawing.Size(310, 20);
            this.txtemprestimo.TabIndex = 1;
            this.txtemprestimo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // CotacaoDolar
            // 
            this.CotacaoDolar.AutoSize = true;
            this.CotacaoDolar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CotacaoDolar.Location = new System.Drawing.Point(214, 59);
            this.CotacaoDolar.Name = "CotacaoDolar";
            this.CotacaoDolar.Size = new System.Drawing.Size(254, 32);
            this.CotacaoDolar.TabIndex = 2;
            this.CotacaoDolar.Text = "Valor do emprestimo";
            this.CotacaoDolar.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Taxa de Juros Anual (%)";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textjurosAnual
            // 
            this.textjurosAnual.Location = new System.Drawing.Point(220, 166);
            this.textjurosAnual.Name = "textjurosAnual";
            this.textjurosAnual.Size = new System.Drawing.Size(310, 20);
            this.textjurosAnual.TabIndex = 4;
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.Color.White;
            this.lblResultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Image = ((System.Drawing.Image)(resources.GetObject("lblResultado.Image")));
            this.lblResultado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblResultado.Location = new System.Drawing.Point(220, 280);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(310, 43);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Calcular Emprestimo";
            this.lblResultado.UseVisualStyleBackColor = false;
            this.lblResultado.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtValorporMes
            // 
            this.txtValorporMes.AutoSize = true;
            this.txtValorporMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorporMes.ForeColor = System.Drawing.Color.Firebrick;
            this.txtValorporMes.Location = new System.Drawing.Point(216, 339);
            this.txtValorporMes.Name = "txtValorporMes";
            this.txtValorporMes.Size = new System.Drawing.Size(153, 24);
            this.txtValorporMes.TabIndex = 6;
            this.txtValorporMes.Text = "Valor da Parcela:";
            this.txtValorporMes.Click += new System.EventHandler(this.txtValorCovert_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 450);
            this.panel1.TabIndex = 7;
            // 
            // parcelasBox
            // 
            this.parcelasBox.Location = new System.Drawing.Point(220, 237);
            this.parcelasBox.Name = "parcelasBox";
            this.parcelasBox.Size = new System.Drawing.Size(310, 20);
            this.parcelasBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(214, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Numero de Parcelas";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txttotalpago
            // 
            this.txttotalpago.AutoSize = true;
            this.txttotalpago.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalpago.ForeColor = System.Drawing.Color.Firebrick;
            this.txttotalpago.Location = new System.Drawing.Point(216, 408);
            this.txttotalpago.Name = "txttotalpago";
            this.txttotalpago.Size = new System.Drawing.Size(105, 24);
            this.txttotalpago.TabIndex = 10;
            this.txttotalpago.Text = "Total Pago:";
            // 
            // txttotaljuros
            // 
            this.txttotaljuros.AutoSize = true;
            this.txttotaljuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotaljuros.ForeColor = System.Drawing.Color.Firebrick;
            this.txttotaljuros.Location = new System.Drawing.Point(216, 374);
            this.txttotaljuros.Name = "txttotaljuros";
            this.txttotaljuros.Size = new System.Drawing.Size(134, 24);
            this.txttotaljuros.TabIndex = 11;
            this.txttotaljuros.Text = "Total em juros:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txttotaljuros);
            this.Controls.Add(this.txttotalpago);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.parcelasBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtValorporMes);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.textjurosAnual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CotacaoDolar);
            this.Controls.Add(this.txtemprestimo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtemprestimo;
        private System.Windows.Forms.Label CotacaoDolar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textjurosAnual;
        private System.Windows.Forms.Button lblResultado;
        private System.Windows.Forms.Label txtValorporMes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox parcelasBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txttotalpago;
        private System.Windows.Forms.Label txttotaljuros;
    }
}

