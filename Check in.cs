using K4os.Compression.LZ4.Encoders;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HOTEL
{
    public partial class Check_in : Form
    {
        public Check_in()
        {
            InitializeComponent();
        }

        int tot = 0;
        int tot1 = 300;
        int tot2 = 0;
        int tot3 = 0;
        int tot4 = 0;
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Check_in_Load(object sender, EventArgs e)
        {
            cboH.Items.Add("Habitacion sencilla $100");
            cboH.Items.Add("Habitacion Doble $200");
            cboH.Items.Add("Habitacion VIP $500");
            cboH.Items.Add("Habitacion VIP doble $600");
        }

        public void btnadd_Click(object sender, EventArgs e)
        {
            string habitacion_deseada = cboH.SelectedItem.ToString();

            // dataGridView1.Rows.Add(cboH);

            string nombre, telefono, edad, Habitacion, entrada, salida, color;
            int dias;

            entrada = dataEntrada.Text;
            salida = dataSalida.Text;
            nombre = txtNombre.Text;
            telefono = txtTelefono.Text;
            edad = txtEdad.Text;
            Habitacion = cboH.Text;
            dias = int.Parse(txtDias.Text);


            if (cboH.SelectedItem == "Habitacion sencilla $100")
            {

                tot = 100;
                tot = tot * dias;
                tot4 = tot;






            }




            if (cboH.SelectedItem == "Habitacion Doble $200")
            {


                tot1 = 200;
                tot1 = tot1 * dias;
                tot4 = tot1;




            }
            if (cboH.SelectedItem == "Habitacion VIP $500")
            {
                tot2 = 500;

                tot2 = tot2 * dias;
                tot4 = tot2;



            }
            if (cboH.SelectedItem == "Habitacion VIP doble $600")
            {
                tot3 = 600;

                tot3 = tot3 * dias;
                tot4 = tot3;
                cboH.Items.Remove("Habitacion VIP doble $600");
            }


            //tot = int.Parse(txtTotal.Text);




            dataGridView1.Rows.Add(nombre, telefono, edad, dias, Habitacion, tot4, entrada, salida);


            double final = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                final += Convert.ToDouble(row.Cells["Column6"].Value);
            }
            txtTotal.Text = Convert.ToString(final);


            entrada = dataEntrada.Text;
            salida = dataSalida.Text;
            nombre = txtNombre.Text;
            telefono = txtTelefono.Text;
            edad = txtEdad.Text;
            Habitacion = cboH.Text;
            dias = int.Parse(txtDias.Text);

            MySqlConnection conexion = new MySqlConnection("Database=hotel;data source = localhost;user id=root; pass =; SSL Mode = None;");

            conexion.Open();

            string consulta = "INSERT INTO hotel values(null,'" + txtNombre.Text + "','" + txtTelefono.Text + "','" + txtEdad.Text + "','" + txtDias.Text + "','" + Habitacion + "','" + txtTotal.Text + "','" + dataEntrada.Text + "','" + dataSalida.Text + "',true);";

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();



            conexion.Close();

            if (cboH.SelectedItem == "Habitacion sencilla $100")
            {


                cboH.Items.Remove("Habitacion sencilla $100");

                Consulta formularuiC = new Consulta();

                Label label = formularuiC.labelVIP;

                if (label != null)
                {
                    // Cambiar el color del Label
                    label.BackColor = Color.Red;
                }

            }

            if (cboH.SelectedItem == "Habitacion Doble $200")
            {

                cboH.Items.Remove("Habitacion Doble $200");

            }

            if (cboH.SelectedItem == "Habitacion VIP $500")
            {

                cboH.Items.Remove("Habitacion VIP $500");

            }

            if (cboH.SelectedItem == "Habitacion VIP doble $300")
            {

                cboH.Items.Remove("Habitacion VIP doble $300");
            }


        }





        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void button2_Click(object sender, EventArgs e)
        {



        }

        private void cboH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form Check_Out = new Check_Out();
            Check_Out.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form consu = new Consulta();

            consu.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }

}



//(NULL, '"+cliente.nombre+"', '"+cliente.apellido+"', '"+cliente.telefono+"', '"+cliente.tarjeta_de_credito+"');";



