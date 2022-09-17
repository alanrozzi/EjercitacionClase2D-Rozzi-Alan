using System.Text;

namespace FormsAero
{
    public partial class FrmMenu : Form
    {
        Form login;

        private FrmMenu()
        {
            InitializeComponent();
        }
        public FrmMenu(Form login) : this()
        {
            this.login = login;
        }

        public FrmMenu(string nombreCompleto) : this()
        {
            StringBuilder bienvenida = new StringBuilder();
            bienvenida.Append($"Buen dia {nombreCompleto}");
            this.lblNombreUsuario.Text = bienvenida.ToString();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            login.Show();
            //vuelve a cargar la app
            this.Close();
        }

        private void btnVuelosDisponibles_Click(object sender, EventArgs e)
        {
            //deben mostrarse los vuelos en el datagrid

        }
    }
}
