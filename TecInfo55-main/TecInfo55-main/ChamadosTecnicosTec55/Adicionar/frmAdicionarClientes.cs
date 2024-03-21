using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChamadosTecnicosTec55.Adicionar
{
    public partial class frmAdicionarClientes : Form
    {
        //Chama a conexão
        string _conexao = ChamadosTecnicosTec55.Properties.Settings.Default.Conexao;

        public frmAdicionarClientes()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbNome.Clear();
            txbProfissao.Clear();
            txbSetor.Clear();
            txbObs.Clear();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Chmar o objeto cliente
            Clientes clientes = new Clientes();
            ClientesDao Clientedao = new ClientesDao(_conexao);

            if(string.IsNullOrWhiteSpace(txbNome.Text) || string.IsNullOrWhiteSpace(txbProfissao.Text) || string.IsNullOrWhiteSpace(txbSetor.Text)  || string.IsNullOrWhiteSpace(txbObs.Text))
            {
                MessageBox.Show("CADE OS DADOS????");
            }

            else
            {
                // Toda vez que mexer com o banco de dados uasar TRY
                try
                {
                    // Preenche o objeto cliente
                    clientes.Nome = txbNome.Text;
                    clientes.Profissao = txbProfissao.Text;
                    clientes.Setor = txbSetor.Text;
                    clientes.Obs = txbObs.Text;

                    // Chamar o DAO para incluir o cliente 
                    Clientedao.IncluiCliente(clientes);
                }

                catch(Exception ex)
                {
                    MessageBox.Show("ERRO  ao cadastrar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                finally
                {
                    MessageBox.Show("Cadastrado com sucesso!");
                }
            }
        }
    }
}
