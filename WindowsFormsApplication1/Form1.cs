using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Inicio : Form
    {
        
        public Inicio()
        {
            InitializeComponent();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
 


            // Verificar la validez del nombre de usuario y la contraseña aquí

         



            {

                MessageBox.Show("Inicio de sesión exitoso");
                this.Hide(); // Oculta el formulario de inicio de sesión


                // Muestra el formulario "Bienvenido"
            }
            else
            {

                MessageBox.Show("Nombre de usuario o contraseña incorrectos");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          /*if (cn.conSQL(txtUsuario.Text, txtContraseña.Text) == 1) ;
            this.Hide();
            Form 1 = Form3();
            Form1.show();*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}