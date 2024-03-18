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

            writer.WriteLine(maskedTextBoxPlaca.Text);
            writer.WriteLine(textBoxMarca.Text);
            writer.WriteLine(textBoxModelo.Text);
            writer.WriteLine(textBoxColor.Text);
            writer.WriteLine(textBoxPrecioXkilometro.Text);

           
            writer.Close();
            MessageBox.Show("Propiedades Guardado");

            refrescarDatos();
            labelAl_datosVehiculo.Text = "...";
            comboBoxAl_placa.Text = "";
            maskedTextBoxPlaca.Select();
        }
    }
}
