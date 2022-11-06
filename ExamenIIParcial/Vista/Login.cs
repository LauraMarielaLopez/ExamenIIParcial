using Datos;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vista
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void AceptarButton_Click(object sender, EventArgs e)
        {
            if (CodigoUsuarioTextBox.Text == String.Empty)
            {
                errorProvider1.SetError(CodigoUsuarioTextBox, "Ingrese un código de usuario");
                CodigoUsuarioTextBox.Focus();
                return;
            }
            errorProvider1.Clear();
            if (ClaveTextBox.Text == String.Empty)
            {
                errorProvider1.SetError(ClaveTextBox, "Ingrese una clave");
                ClaveTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            UsuarioDatos userDatos = new UsuarioDatos();

            bool valido = await userDatos.LoginAsync(CodigoUsuarioTextBox.Text, ClaveTextBox.Text);

            if (valido)
            {
                Menu formulario = new Menu();
                //System.Security.Principal.GenericIdentity identity = new System.Security.Principal.GenericIdentity(CodigoUsuarioTextBox.Text);
                //System.Security.Principal.GenericPrincipal principal = new System.Security.Principal.GenericPrincipal(identity, null);
                //System.Threading.Thread.CurrentPrincipal = principal;
                VariableGlobal.UsuarioLogin = CodigoUsuarioTextBox.Text;



                Hide();

                formulario.Show();
            }
            else
            {
                MessageBox.Show("Datos de usuario incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}