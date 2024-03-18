using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlCondominio
{
    public partial class Form1 : Form
    {
        List<Propietarios> propietarios = new List<Propietarios();    //Cargar Propietarios
        List<Propiedades> propiedades  = new List<Propiedades>();    //Cargar Clientes
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string fileName = "Propietarios.txt";
            FileStream stream = new FileStream(fileName, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            writer.WriteLine(TxtDpi.Text);
            writer.WriteLine(TxtNombre.Text);
            writer.WriteLine(TxtApellido.Text);
           
           
            writer.Close();
            MessageBox.Show("Propiedades Guardado");
            /*
            refrescarDatos();
            labelAl_datosVehiculo.Text = "...";
            comboBoxAl_placa.Text = "";
            maskedTextBoxPlaca.Select();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtDpi.Text  = "";
            TxtNombre.Text = "";
            TxtApellido.Text = "";
            textBoxNoCasa.Text = "";
            comboBoxDpiDueño.Text = "";
            textBoxCuota.Text = "";
        }

        private void Reistro_Propietrarios_Click(object sender, EventArgs e)
        {
            string fileName = "Propiedades.txt";
            FileStream stream = new FileStream(fileName, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            writer.WriteLine(TxtDpi.Text);
            writer.WriteLine(TxtNombre.Text);
            writer.WriteLine(TxtApellido.Text);


            writer.Close();
            MessageBox.Show("Propedades Guardado");

        }

        private void comboBoxDpiDueño_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxDpiDueño.ValueMember = "Dpi";
            string nitCliente = Convert.ToString(comboBoxDpiDueño.SelectedValue);

            Propietarios  clienteEncontrado = Propietarios.Find(c => c.Dpi == dpiCliente);
            //labelAl_clienteNombre.Text = clienteEncontrado.Nombre;
        }
    }
}
