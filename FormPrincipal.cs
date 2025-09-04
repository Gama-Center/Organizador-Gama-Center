using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organizador_Gama_Center
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSeguranca_Click(object sender, EventArgs e)
        {
            // esconde a primeira tela
            this.Hide();

            // abre a segunda tela
            FormOrganizador formOrganizador = new FormOrganizador();
            formOrganizador.ShowDialog();

            //depois que organizado for fechado, fecha a primeira tela
            this.Close();
        }

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {

        }

        private void FormPrincipal_Resize(object sender, EventArgs e)
        {
            // Centraliza o painel horizontalmente
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;

            // Centraliza o painel verticalmente
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;

        }
    }
}
