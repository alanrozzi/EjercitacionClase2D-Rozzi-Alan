using Aerolineas;

namespace FormsAero
{
    public partial class FrmLogin : Form
    {
        List<Administrador> administradores = new List<Administrador>(Mock.Administradores());
        Administrador adminLogueado;

        public FrmLogin()
        {
            InitializeComponent();
            /*
            //DEBUG
            StringBuilder texto = new StringBuilder();
            foreach (Administrador itemAdmin in administradores)
            {
                texto.AppendLine($"{itemAdmin.Contrasenia}, {itemAdmin.Usuario}");
            }
            MessageBox.Show(texto.ToString()); //ANDAAA
            */
            //Console.WriteLine(Environment.NewLine);
        }

        private void btnAutocompletar_Click(object sender, EventArgs e)
        {
            //el boton autocompletar debe rellenar los campos con un random
            Random rnd = new Random();
            //tomo un usuario random de admins
            Administrador admin = administradores[rnd.Next(0, 4)];
            //carga las props del admin
            this.txtUsuario.Text=admin.Usuario;
            this.txtContrasenia.Text = admin.Contrasenia;
            adminLogueado = admin;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //verifico que sea el usser que quiero
            if (adminLogueado != null && this.txtUsuario.Text == adminLogueado.Usuario && this.txtContrasenia.Text == adminLogueado.Contrasenia)
            {
                //me manda para el menu, lo instancio en este momento, le paso el nombre del usuario para que muestre
                //frmMenu menuPrincipal = new frmMenu(adminLogueado.NombreCompleto);
                FrmMenu menuPrincipal = new FrmMenu(this);
                //muestro el menu ppal
                menuPrincipal.Show();
                //cierro el login
                this.Hide();
            }
            else
            {
                //vacio, no quiero el popup feo
                this.txtUsuario.Text = string.Empty;
                this.txtUsuario.PlaceholderText = "RETRY USSER";
                this.txtContrasenia.Text = string.Empty;
                this.txtContrasenia.PlaceholderText = "RETRY PW";
            }
        }
    }
}