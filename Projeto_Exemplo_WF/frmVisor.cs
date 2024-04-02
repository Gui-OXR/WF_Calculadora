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
    public partial class frmVisor : Form
    {
        public decimal Resultado { get; set; }
        public decimal Valor { get; set; }
        private Operacao OperacaoSelecionada { get; set; }

        private enum Operacao
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao
        }

        public frmVisor()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            visor.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            visor.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            visor.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            visor.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            visor.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            visor.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            visor.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            visor.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            visor.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            visor.Text += "9";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtracao;
            Valor = Convert.ToDecimal(visor.Text);
            visor.Text = "";
            lblSinal.Text = "-";
        }

        private void btnAdi_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Adicao;
            Valor = Convert.ToDecimal(visor.Text);
            visor.Text = "";
            lblSinal.Text = "+";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicacao;
            Valor = Convert.ToDecimal(visor.Text);
            visor.Text = "";
            lblSinal.Text = "x";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao;
            Valor = Convert.ToDecimal(visor.Text);
            visor.Text = "";
            lblSinal.Text = "/";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada)
            {
                case Operacao.Subtracao:
                    Resultado = Valor - Convert.ToDecimal(visor.Text);
                    break;
                case Operacao.Adicao:
                    Resultado = Valor + Convert.ToDecimal(visor.Text);
                    break;
                case Operacao.Multiplicacao:
                    Resultado = Valor * Convert.ToDecimal(visor.Text);
                    break;
                case Operacao.Divisao:
                    if (Convert.ToDecimal(visor.Text) > 0)
                    {
                        Resultado = Valor / Convert.ToDecimal(visor.Text);
                    }
                    else
                    {
                        MessageBox.Show("Não é possivel dividir por 0!");
                    }
                    break;
            }
            visor.Text = Convert.ToString(Resultado);
            lblSinal.Text = "=";
        }

        private void btnVir_Click(object sender, EventArgs e)
        {
            if (!visor.Text.Contains(","))
                visor.Text += ",";
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            visor.Text = "";
            lblSinal.Text = "";
        }
    }
}
