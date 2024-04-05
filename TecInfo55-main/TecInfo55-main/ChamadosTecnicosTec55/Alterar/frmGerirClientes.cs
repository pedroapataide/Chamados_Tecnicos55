using ChamadosTecnicosTec55.Adicionar;
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
    public partial class frmGerirClientes : Form
    {
        //Chama a conexão
        string _conexao = ChamadosTecnicosTec55.Properties.Settings.Default.Conexao;
        public frmGerirClientes()
        {
            InitializeComponent();
        }

        // Busca no DAO o cliente 
        private void ListarCliente()
        {
            // Chamar cliente DAO
            ClientesDao clientesDao = new ClientesDao(_conexao);

            // Captura o valor digitado na barra de texto tab
            string busca = txt_buscar.Text.ToString();

            // Chamar o metodo BuscarClientes do objeto
            DataSet ds = new DataSet();
            ds = clientesDao.BuscarCliente(busca);

            //Defini o DataSource do DataGriedView
            dgv_gerirClientes.DataSource = ds;

            // defini o membro do DataSet
            dgv_gerirClientes.DataMember = "Clientes";
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            frmAdicionarClientes frmAdicionarClientes = new frmAdicionarClientes();
            frmAdicionarClientes.Show();
        }

        private void frmGerirClientes_Load(object sender, EventArgs e)
        {
            ListarCliente();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            ListarCliente();
        }
    }
}
