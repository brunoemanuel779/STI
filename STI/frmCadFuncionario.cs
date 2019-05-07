using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace STI
{
    public partial class frmCadFuncionario : Form
    {

        private bool validaFunc()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Preenchimento obrigatorio Nome", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Clear();
                txtNome.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(mskCpf.Text))
            {
                MessageBox.Show("Preenchimento obrigatorio CPF", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskCpf.Clear();
                mskCpf.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtRua.Text))
            {
                MessageBox.Show("Preenchimento obrigatorio Rua", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRua.Clear();
                txtRua.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCidade.Text))
            {
                MessageBox.Show("Preenchimento obrigatorio Cidade", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCidade.Clear();
                txtCidade.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(cbxEstado.Text))
            {
                MessageBox.Show("Preenchimento obrigatorio Estado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCidade.Clear();
                txtCidade.Focus();
                return false;
            }
            DateTime auxData;
            if (!(DateTime.TryParse(mskDatanasc.Text, out auxData)))
            {
                MessageBox.Show("Prenchimento de campo Data de nascimento obrigatorio", "ACR Rental Car",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskDatanasc.Clear();
                mskDatanasc.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(mskSal.Text)) {
                MessageBox.Show("Prenchimento de campo Salario obrigatorio", "ACR Rental Car",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskSal.Clear();
                mskSal.Focus();
                return false;
            }

            

        
                return true;
        }
        void limpaControle()
        {
            txtNome.Clear();
            txtRua.Clear();
            txtCidade.Clear();
            mskDatanasc.Clear();
            mskCpf.Clear();
            mskSal.Clear();
            mskTel.Clear();
            cbxEstado.Focus();
        }
        public frmCadFuncionario()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            validaFunc();
            if (validaFunc() == false)
                return;

            string SqlInsert;
            SqlConnection conFuncionario = Conexao.getConnection();
          //  SqlInsert = "INSERT INTO funcionario(NomeFunc,DataNascFunc,CpfFunc,TelFunc,RuaFunc,CidadeFunc,EstadoFunc,SalFunc)VALUES(@nome,@data,@cpf,@tel,@rua,@cidade,@estado,@salario)";
            SqlInsert = "INSERT INTO funcionario(NomeFunc,DataNascFunc,CpfFunc,TelFunc,RuaFunc,CidadeFunc,EstadoFunc,SalFunc) VALUES(@nome,@data,@cpf,@tel,@rua,@cidade,@estado,@salario)";
            try
            {
                conFuncionario.Open();
                SqlCommand cmd = new SqlCommand(SqlInsert, conFuncionario);
                cmd.Parameters.Add(new SqlParameter("@nome", txtNome.Text));
               
                cmd.Parameters.Add(new SqlParameter("@data", Convert.ToDateTime(mskDatanasc.Text)));
                cmd.Parameters.Add(new SqlParameter("@cpf",mskCpf.Text));
                cmd.Parameters.Add(new SqlParameter("@tel", mskTel.Text));
                cmd.Parameters.Add(new SqlParameter("@rua", txtRua.Text));
                cmd.Parameters.Add(new SqlParameter("@cidade", txtCidade.Text));
                cmd.Parameters.Add(new SqlParameter("@estado", cbxEstado.Text));
                MessageBox.Show(mskSal.Text);
                cmd.Parameters.Add(new SqlParameter("@salario", mskSal.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Funcionario incluído com sucesso", "STI",
MessageBoxButtons.OK, MessageBoxIcon.Information);

                limpaControle();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Problema ao incluir Funcionario " + ex, "",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (conFuncionario != null)
                { conFuncionario.Close(); }
            }

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void frmCadFuncionario_Load(object sender, EventArgs e)
        {

        }
    }
}
