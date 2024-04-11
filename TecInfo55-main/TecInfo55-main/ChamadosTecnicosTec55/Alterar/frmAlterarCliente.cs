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

namespace ChamadosTecnicosTec55.Alterar
{
    public partial class frmAlterarCliente : Form
    {
        string _conexao = ChamadosTecnicosTec55.Properties.Settings.Default.Conexao;
        public frmAlterarCliente(int codigo)
        {
            InitializeComponent();

            // Verifica se o codigo é maior que zero
            if (codigo > 0)
            {
                // Criar uma instância do objeto cliente
                Clientes clientes = new Clientes();
                ClientesDao clientesDao = new ClientesDao(_conexao);

                clientes = clientesDao.ObtemCliente(codigo);

                // Se o cliente não foi encontrado
                if (clientes == null)
                {
                    MessageBox.Show("Cliente não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }

                txb_codigo.Text = clientes.CodigoCliente.ToString();
                txbNome.Text = clientes.Nome;
                txbProfissao.Text = clientes.Profissao;
                txbSetor.Text = clientes.Setor;
                txbObs.Text = clientes.Obs;
            }
        }
    }
}
