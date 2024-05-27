using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ejercicio_personajes.DATA.DataAccess;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ejercicio_personajes
{
    public partial class Form1 : Form
    {
        private Personajes Personajes;
        public Form1()
        {
            InitializeComponent();

            Personajes = new Personajes();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)

        {
            if (Personajes.ProbarConexion())
            {


                MessageBox.Show("SI SE PUDO");


            }
            else
            {
                MessageBox.Show("NEL PASTEl");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridViewPersonajes.DataSource = Personajes.LeerPersonajes();
            {

            }


        }

        private void textBox1_TextChanged_TextChanged(object sender, EventArgs e)
        {

        }

        private void insertar_Click(object sender, EventArgs e)


        {
            string nombre = textBoxnombre.Text;
            string raza = textBoxraza.Text;
            int nivelpoder = (int)numericUpDownNivel_de_Poder.Value;
            string historia = textBoxhistoria.Text;
            DateTime Fecha = dateTimePickerFechaCreacion.Value;


            int respuesta = Personajes.CrearPersonaje(nombre, raza, nivelpoder, Fecha, historia);
            if (respuesta > 0)
            {


                MessageBox.Show("SE CREO CORRECTAMENTE");
                dataGridViewPersonajes.DataSource = Personajes.LeerPersonajes();
            }
            else
            {

                MessageBox.Show("ERROR");
            }
        }



        private void BuscarPorId()
        {
            int idPersonajeABuscar = int.Parse(textBoxId.Text);

            DataTable personajeEncontrado = Personajes.BuscarPersonajePorId(idPersonajeABuscar);

            if (personajeEncontrado.Rows.Count > 0)
            {
                // El personaje fue encontrado
                string nombre = personajeEncontrado.Rows[0]["nombre"].ToString();
                string raza = personajeEncontrado.Rows[0]["raza"].ToString();
                int nivelPoder = int.Parse(personajeEncontrado.Rows[0]["nivel_poder"].ToString());
                textBoxnombre.Text = nombre;
                textBoxraza.Text = raza;

                numericUpDownNivel_de_Poder.Value = nivelPoder;
            }
            else
            {
                // El personaje no fue encontrado
                Console.WriteLine("No se encontró el personaje con ID: " + idPersonajeABuscar);
            }

        }
        private void ButtonBuscar_Click_Click(object sender, EventArgs e)

        {
            BuscarPorId();
        }


        private void textBoxID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxId.Text))
            {
                MessageBox.Show("Por favor, ingresa un valor en el campo de texto.");
                textBoxId.Focus(); // Devolver el foco al TextBox
            }
            else
            {
                BuscarPorId();
            }
        }
        private void ActualizarPersonaje()
        {
            int id = int.Parse(textBoxId.Text);
            string nombre = textBoxnombre.Text;
            string raza = textBoxraza.Text;
            int nivelPoder = (int)numericUpDownNivel_de_Poder.Value;
            DateTime Fecha = dateTimePickerFechaCreacion.Value;
            string historia = textBoxhistoria.Text;

            Personajes.ActualizarPersonaje(id, nombre, raza, nivelPoder, Fecha, historia);

            MessageBox.Show("Personaje actualizado correctamente.");
        }

        private void Actualizar_Click_Click(object sender, EventArgs e)
       
            {
                try
                {
                    ActualizarPersonaje();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }
            }
        }
    }

















