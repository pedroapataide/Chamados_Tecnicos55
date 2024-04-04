using ChamadosTecnicosTec55.Adicionar;
using ChamadosTecnicosTec55.Alterar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChamadosTecnicosTec55
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void fecharSoluçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var msgBox = MessageBox.Show("Oh, vai sair mesmo?", "Sistema de Chamados", MessageBoxButtons.YesNo);

            if (msgBox == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void documentaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = @"https://sp.senac.br",
                UseShellExecute = true,
            });
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("calc");
        }

        private void clintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdicionarClientes frmAdicionarClientes = new frmAdicionarClientes();
            frmAdicionarClientes.MdiParent = this;
            frmAdicionarClientes.Show();
        }

        private void técnicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdicionarTecnicos frmAdicionarTecnicos = new frmAdicionarTecnicos();
            frmAdicionarTecnicos.MdiParent = this;
            frmAdicionarTecnicos.Show();
        }

        private void gestorDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGerirClientes frmGerirClientes = new frmGerirClientes();
            frmGerirClientes.MdiParent = this;  
            frmGerirClientes.Show();
        }
    }
}
