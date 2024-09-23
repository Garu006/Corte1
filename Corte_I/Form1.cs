using Corte_I.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corte_I
{
    public partial class Form1 : Form
    {
        Registro registro = new Registro();
        Operacion operacion = new Operacion();
        public Form1()
        {
            InitializeComponent();
            this.Text = "Registro de edades - R.E.";
            this.Text = "Registro de edades - R.E.";

            
            cbCiudad.Items.Add("Ciudad El Doral");
            cbCiudad.Items.Add("Chinandega");
            cbCiudad.Items.Add("Managua");

            
            cbCiudad.SelectedIndex = 0;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Persona nuevaPersona = new Persona(
                    tbNombre.Text,
                    tbApellido.Text,
                    dtpFechaNacimiento.Value,
                    cbCiudad.SelectedItem.ToString()
                );

                registro.AgregarPersona(nuevaPersona);
                MessageBox.Show("Persona agregada correctamente");

                tbNombre.Clear();
                tbApellido.Clear();
                cbCiudad.SelectedIndex = -1; 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnMayorMenor_Click(object sender, EventArgs e)
        {
            try
            {
                Persona ultimaPersona = registro.personas[registro.contador - 1];
                int edad = operacion.CalcularEdad(ultimaPersona);
                string mayorOMenor = operacion.EsMayorDeEdad(ultimaPersona);

                MessageBox.Show($"Edad: {edad} años\n{mayorOMenor}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
