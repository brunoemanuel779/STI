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
    public partial class frmCadCliente : Form
    {
        private void habilitar()
        {
            //txtCodigo sempre será desabilitado
            txtCodigo.Enabled = false;
            //altera a propriedade Enabled dos controles para true, habilitando o controle
            txtNome.Enabled = true;
            mskCpf.Enabled = true;
            mskTel.Enabled = true;
        }

        private void desabilitar()
        {
            //txtCodigo sempre será desabilitado
            txtCodigo.Enabled = false;

            //altera a propriedade Enabled dos controles para ficarem desabilitados
            txtNome.Enabled = false;
            mskCpf.Enabled = false;
            mskTel.Enabled = false;
        }

        
        private void limparControles()
        {
            txtCodigo.Enabled = false;

            txtNome.Clear();
            mskCpf.Clear();
            mskTel.Clear();
            txtCidade.Clear();
            txtRua.Clear();
            cbxEstado.Focus();

        }
        private bool validaCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Preenchimento obrigatorio Nome","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
                cbxEstado.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cbxEstadoc.Text))
            {
                MessageBox.Show("Preenchimento obrigatorio Estado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
          
                cbxEstadoc.Focus();
                return false;
            }


            return true;
        }
        public frmCadCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CadCliente_Load(object sender, EventArgs e)
        {
            habilitar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            validaCampos();

            if (validaCampos() == false)
                    return;
            string SqlInsert;
            SqlConnection conCliente = Conexao.getConnection();
            SqlInsert = "INSERT INTO cliente(NomeCli,CpfCli,TelCli,RuaCli,CidadeCli,EstadoCli,EstadoCivil) VALUES(@nome,@cpf,@tel,@rua,@cidade,@estado,@estadocivil)";
            try
            {
                conCliente.Open();
                SqlCommand cmd = new SqlCommand(SqlInsert, conCliente);
                cmd.Parameters.Add(new SqlParameter("@nome", txtNome.Text));
                cmd.Parameters.Add(new SqlParameter("@cpf", mskCpf.Text));
                cmd.Parameters.Add(new SqlParameter("@tel", mskTel.Text));
                cmd.Parameters.Add(new SqlParameter("@rua", txtRua.Text));
                cmd.Parameters.Add(new SqlParameter("@cidade", txtCidade.Text));
                cmd.Parameters.Add(new SqlParameter("@estado", cbxEstado.Text));
                cmd.Parameters.Add(new SqlParameter("@estadocivil", cbxEstadoc.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente incluído com sucesso", "ACR Rental Car",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problema ao incluir cliente " + ex, "ACR Rental Car",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (conCliente != null)
                { conCliente.Close(); }
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new FrmConsultaCliente(this);

            frm.MdiParent = this.MdiParent;

            frm.Show();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Consulte o Cliente que deseja alterar clicando no botao consulta", "STI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(validaCampos() == false)
            {
                return;
            }

            string sqlQuerya;

            SqlConnection conCliente = Conexao.getConnection();

            sqlQuerya = "UPDATE cliente set NomeCli=@NomeCli,CpfCli=@CpfCli,TelCli=@TelCli,RuaCli=@RuaCli,CidadeCli=@CidadeCli,EstadoCli=@EstadoCli,EstadoCivil=@estadocivil WHERE Id=@id_cliente";

            try
            {
                conCliente.Open();
                SqlCommand cmd = new SqlCommand(sqlQuerya, conCliente);

                
                cmd.Parameters.Add(new SqlParameter("@NomeCli", txtNome.Text));
                cmd.Parameters.Add(new SqlParameter("@CpfCli", mskCpf.Text));
                cmd.Parameters.Add(new SqlParameter("@TelCli", mskTel.Text));
                cmd.Parameters.Add(new SqlParameter("@RuaCli", txtRua.Text));
                cmd.Parameters.Add(new SqlParameter("@CidadeCli", txtCidade.Text));
                cmd.Parameters.Add(new SqlParameter("@EstadoCli", cbxEstado.Text));
                cmd.Parameters.Add(new SqlParameter("id_cliente", txtCodigo.Text));
                cmd.Parameters.Add(new SqlParameter("@estadocivil", cbxEstadoc.Text));
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cliente Alterado com Sucesso", "STI", MessageBoxButtons.OK);

                limparControles();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Problema ao alterar cliente" + ex, "STI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if(conCliente != null)
                {
                    conCliente.Close();
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Consulte o cliente que deseja excluir clicando no botão consultar", "STI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if(MessageBox.Show("Deseja excluir permanente o registro ?","STI",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string SqlQuerye;

                SqlConnection conCliente = Conexao.getConnection();

                SqlQuerye = " DELETE FROM cliente WHERE Id=@id_cliente";

                try
                {
                    conCliente.Open();

                    SqlCommand cmd = new SqlCommand(SqlQuerye, conCliente);

                    cmd.Parameters.Add(new SqlParameter("@id_cliente", Convert.ToInt32(txtCodigo.Text)));

                    cmd.ExecuteNonQuery();

                    limparControles();
                }catch(Exception ex)
                {
                    MessageBox.Show("Problema ao excluir" + ex, "STI", MessageBoxButtons.OK);
                }
                finally
                {
                    if(conCliente != null)
                    {
                        conCliente.Close();
                    }
                }
            }
        }
    }
}
