namespace CartaoVisita
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string idade = txtIdade.Text;
            string telefone = txtTelefone.Text;
            string email = txtEmail.Text;
            string endereco = txtEndereço.Text;

            frmCartaoVisita formulario = new frmCartaoVisita(
                     nome,idade,email,endereco, telefone
            );
            formulario.ShowDialog();
        }
    }
}
