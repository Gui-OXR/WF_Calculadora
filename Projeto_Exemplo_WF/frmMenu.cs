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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void calculadora1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //instanciando objeto
            frmCalculos objCalculos = new frmCalculos();
            //
            objCalculos.MdiParent = this;
            //Mostrando o objeto
            objCalculos.Show();
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair", "Saindo...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void visorÚnicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //instanciando objeto
            frmVisor objCalculos = new frmVisor();
            //
            objCalculos.MdiParent = this;
            //Mostrando o objeto
            objCalculos.Show();
        }
    }
}
