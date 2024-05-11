using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CartaoVisita
{
    public partial class frmCartaoVisita : Form
    {
        string nome;
        string idade;
        string telefone;
        string email;
        string endereco;
        public frmCartaoVisita(string nome, string telefone, string email, string idade, string endereco)
        {
            InitializeComponent();
            this.nome = nome;
            this.telefone = telefone;
            this.email = email;
            this.idade = idade;
            this.endereco = endereco;
        }

        private void frmCartaoVisita_Load(object sender, EventArgs e)
        {
            lblNome.Text = nome.ToString();
            lblIdade.Text = idade.ToString();
            lblEmail.Text = email.ToString();
            lblTelefone.Text = telefone.ToString();
            lblEndereço.Text = endereco.ToString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
