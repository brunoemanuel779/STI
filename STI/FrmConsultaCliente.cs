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
    public partial class FrmConsultaCliente : Form
    {
        frmCadCliente frmCliente;
        public FrmConsultaCliente(frmCadCliente frmCliente)
        {
            this.frmCliente = frmCliente;
            InitializeComponent();
        }

        private void FrmConsultaCliente_Load(object sender, EventArgs e)
        {
            //declaração da variavel para guardar as instrução sql
            string sqlSelect;

            //cria conexão chamado o método getConnection da classe Conexao
            SqlConnection conCliente = Conexao.getConnection();

            //cria a instrução sql,parametriza para selecionar todos os clientes em ordem de nome
            sqlSelect = "SELECT Id,NomeCli,CpfCli,TelCli,RuaCli,CidadeCli,EstadoCli,EstadoCivil FROM cliente ORDER BY NomeCli";

            //declara um DataAdapter

            SqlDataAdapter dta = new SqlDataAdapter(sqlSelect, conCliente);

            //declara um DataTable
            DataTable dt = new DataTable();

            //tratamento de exeçoes

            try
            {
                //chama o metodo fill() de DataAdapter passando com paramentro p DataTable dt
                dta.Fill(dt);

                //Configura a Fonte dados na datagrid
                dgvCliente.DataSource = dt;

                //altera cor das linhas alternadas do grid
                dgvCliente.RowsDefaultCellStyle.BackColor = Color.White;
                dgvCliente.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray;

                //cria as coluna no datagrid e coloca o texto nome das coluna
                dgvCliente.Columns[0].HeaderCell.Value = "Codigo do cliente";//primeira coluna
                dgvCliente.Columns[1].HeaderCell.Value = "Nome do cliente";//segunda linha
                dgvCliente.Columns[2].HeaderCell.Value = "CPF";//terceira Coluna
                dgvCliente.Columns[3].HeaderCell.Value = "Telefone";//quarta coluna
                dgvCliente.Columns[4].HeaderCell.Value = "Rua";
                dgvCliente.Columns[5].HeaderCell.Value = "Cidade";
                dgvCliente.Columns[6].HeaderCell.Value = "Estado";
                dgvCliente.Columns[6].HeaderCell.Value = "Estado Civil";



            }
            catch (Exception ex){
                MessageBox.Show("Problema ao listar cliente" + ex, "STI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if(conCliente != null)
                {
                    conCliente.Close();
                }
            }
            }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            string codigoCliente;

            codigoCliente = dgvCliente.CurrentRow.Cells[0].Value.ToString();

            string sqlQuery;

            SqlConnection conClienteConsulta = Conexao.getConnection();

            SqlDataReader dtr = null;

            sqlQuery = "SELECT Id,NomeCli,CpfCli,TelCli,RuaCli,CidadeCli,EstadoCli FROM cliente WHERE Id=@id_cliente";

            try
            {
                conClienteConsulta.Open();

                SqlCommand cmd = new SqlCommand(sqlQuery, conClienteConsulta);

                cmd.Parameters.Add(new SqlParameter("@id_cliente", Convert.ToInt32(codigoCliente)));

                dtr = cmd.ExecuteReader();

                if (dtr.Read())
                {
                    frmCliente.txtCodigo.Text = dtr["Id"].ToString();
                    frmCliente.txtNome.Text = dtr["NomeCli"].ToString();
                    frmCliente.mskCpf.Text = dtr["CpfCli"].ToString();
                    frmCliente.mskTel.Text = dtr["TelCli"].ToString();
                    frmCliente.txtRua.Text = dtr["RuaCli"].ToString();
                    frmCliente.txtCidade.Text = dtr["CidadeCli"].ToString();
                    frmCliente.cbxEstado.Text = dtr["EstadoCli"].ToString();
                }


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if(dtr != null)
                {
                    dtr.Close();
                }
                if(conClienteConsulta != null){
                    conClienteConsulta.Close();
                }
            }

            this.Close();
        }
    }
    }

