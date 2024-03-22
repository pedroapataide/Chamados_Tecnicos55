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
    public partial class frmAdicionarTecnicos : Form
    {
        //Chama a conexão
        string _conexao = ChamadosTecnicosTec55.Properties.Settings.Default.Conexao;

        public frmAdicionarTecnicos()
        {
            InitializeComponent();
  
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbNome.Clear();
            txbEspecialidade.Clear();
            txbEmail.Clear();
            txbSenha.Clear();
            txbObs.Clear();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            // Chmar o objeto cliente
            Tecnicos tecnicos = new Tecnicos();
            Tecnicodao tecnicodao = new Tecnicodao(_conexao);

            if (string.IsNullOrWhiteSpace(txbNome.Text) || string.IsNullOrWhiteSpace(txbEspecialidade.Text) || string.IsNullOrWhiteSpace(txbEmail.Text) || string.IsNullOrWhiteSpace(txbSenha.Text) || string.IsNullOrWhiteSpace(txbObs.Text))
            {
                MessageBox.Show("CADE OS DADOS????");
            }

            else
            {
                // Toda vez que mexer com o banco de dados uasar TRY
                try
                {
                    // Preenche o objeto cliente
                    tecnicos.Nome = txbNome.Text;
                    tecnicos.Especialidade = txbEspecialidade.Text;
                    tecnicos.Email = txbEmail.Text;
                    tecnicos.senha = txbSenha.Text;
                    tecnicos.Obs = txbObs.Text;

                    // Chamar o DAO para incluir o cliente 
                    tecnicodao.IncluiTecnico(tecnicos);
                    MessageBox.Show("Cadastrado com sucesso!");
                    this.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("ERRO  ao cadastrar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
 }
