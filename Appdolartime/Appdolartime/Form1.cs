using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appdolartime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            double taxaDeJurosMensal = (Convert.ToDouble(textjurosAnual.Text) / 100) / 12;
            double valorDaParcela = Convert.ToDouble(txtemprestimo.Text) * (taxaDeJurosMensal / (1 - Math.Pow(1 + taxaDeJurosMensal, - Convert.ToDouble(parcelasBox.Text))));

            double totalpago = valorDaParcela * Convert.ToDouble(parcelasBox.Text);

            double totaldejuros = totalpago - Convert.ToDouble(txtemprestimo.Text);

            txtValorporMes.Text = "Valor da Parcela: " + valorDaParcela.ToString("N2");

            txttotaljuros.Text = "Total de Juros: " + totaldejuros.ToString("N2");

            txttotalpago.Text = "Total Pago: " + totalpago.ToString("N2") ;
            //textcotacaoreal.Clear();
            textjurosAnual.Focus();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtValorCovert_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
