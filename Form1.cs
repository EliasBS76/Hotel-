using Microsoft.VisualBasic;
using System.Drawing.Imaging;

namespace HOTEL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string  usuario, contraseña;

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Usuariotxt.Clear();
            Contraseñatxt.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            Form cerrar = new Form1();
            this.Close();
        }

        private void btningresar_Click(object sender, EventArgs E)
        {
            
            usuario = Convert.ToString (Usuariotxt.Text);
            contraseña =Convert.ToString (Contraseñatxt.Text);

          if(usuario=="EliasBs" && contraseña=="123")
            {
                Form nuevo = new Menu();
                nuevo.Show();

                
               

            }
            else
            {
                MessageBox.Show("Error al entrar");
            }


        }

        }
    }


