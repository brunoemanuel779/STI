using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STI
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pesquisaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form CadFunc = new frmCadFuncionario();
            CadFunc.MdiParent = this;
            CadFunc.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form CadCli = new frmCadCliente();
            CadCli.MdiParent = this;
            CadCli.Show();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void relatoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void funcionariosToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form CadServ= new frmCadServico();
            CadServ.MdiParent = this;
            CadServ.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
