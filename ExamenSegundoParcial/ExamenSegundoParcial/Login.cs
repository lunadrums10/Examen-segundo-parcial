using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Datos.Acceso;
using Datos.Entidades;

namespace ExamenSegundoParcial
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Aceptarbutton1_Click(object sender, EventArgs e)
        {
            UsuarioDA usuarioDA = new UsuarioDA();
            Usuario usuario = new Usuario();

            usuario = usuarioDA.Login(UsuariotextBox1.Text, ClavetextBox2.Text);

            if (usuario == null)
            {
                MessageBox.Show("Datos mal ingresados");
                return;
            }

           FremMenu fremMenu= new FremMenu();
            fremMenu.Show();
            this.Hide();

            
        }
    }
}
