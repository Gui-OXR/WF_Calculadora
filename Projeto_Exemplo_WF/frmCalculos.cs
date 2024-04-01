using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Exemplo_WF
{
    public partial class frmCalculos : Form
    {
        public frmCalculos()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            double a, b, r;
            lblSinal.Text = "+";
            //tente, caso encontre um excessão de formato, mostre uma mensagem
            try
            {
                //Recolhendo valores das TextBox
                a = double.Parse(txtPrimeiro.Text);
                b = double.Parse(txtSegundo.Text);
                //Calculando
                r = a + b;
                //Mostrando o Resultado no Label
                lblResultado.Text = r.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números!");
            }
        }
        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            double a, b, r;
            lblSinal.Text = "-";
            //tente, caso encontre um excessão de formato, mostre uma mensagem
            try
            {
                //Recolhendo valores das TextBox
                a = double.Parse(txtPrimeiro.Text);
                b = double.Parse(txtSegundo.Text);
                //Calculando
                r = a - b;
                //Mostrando o Resultado no Label
                lblResultado.Text = r.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números!");
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            double a, b, r;
            lblSinal.Text = "x";
            //tente, caso encontre um excessão de formato, mostre uma mensagem
            try
            {
                //Recolhendo valores das TextBox
                a = double.Parse(txtPrimeiro.Text);
                b = double.Parse(txtSegundo.Text);
                //Calculando
                r = a * b;
                //Mostrando o Resultado no Label
                lblResultado.Text = r.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números!");
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double a, b, r;
            lblSinal.Text = "/";
            //tente, caso encontre um excessão de formato, mostre uma mensagem
            try
            {
                //Recolhendo valores das TextBox
                a = double.Parse(txtPrimeiro.Text);
                b = double.Parse(txtSegundo.Text);
                //Calculando
                r = a / b;
                //Mostrando o Resultado no Label
                lblResultado.Text = r.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números!");
            }
        }
        private void btnPotenciacao_Click(object sender, EventArgs e)
        {
            double a, b, r;
            lblSinal.Text = "^";
            //tente, caso encontre um excessão de formato, mostre uma mensagem
            try
            {
                //Recolhendo valores das TextBox
                a = double.Parse(txtPrimeiro.Text);
                b = double.Parse(txtSegundo.Text);
                //Calculando
                r = Math.Pow(a, b);
                //Mostrando o Resultado no Label
                lblResultado.Text = r.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números!");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Limpando os txts e labels
            txtPrimeiro.Clear();
            txtSegundo.Clear();
            lblSinal.Text = "";
            lblResultado.Text = "";
            //Envia o foco para o txtPrimeiro
            txtPrimeiro.Focus();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            //Fechando janela
            Close();
        }

        private void frmCalculos_Load(object sender, EventArgs e)
        {

        }
    }
}
