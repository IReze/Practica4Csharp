using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;
namespace Formulario_5
{
    public partial class Form1 : Form
    {
        string conexionSQL = "Server=localhost;Port=3306;Database=Formulario_PA;Uid=root;Pwd=Power616!;";
        public Form1()
        {
            InitializeComponent();
            TB_Nombre.TextChanged += ValidarNombre;
            TB_Apellido.TextChanged += ValidarApellido;
            TB_Edad.TextChanged += ValidarEdad;
            TB_Estatura.TextChanged += ValidarEstatura;
            TB_Telefono.TextChanged += ValidarTelefono;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void insertarRegistro(string nombre, string apellidos, int edad, decimal estatura, long telefono, string genero)
        {
            using (MySqlConnection conexion = new MySqlConnection(conexionSQL))
            {
                conexion.Open();
                string query = "INSERT INTO Datos (nombre, apellidos, edad, estatura, telefono, genero) VALUES (@nombre,@apellidos,@edad,@estatura,@telefono,@genero)";
                using (MySqlCommand comando = new MySqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@apellidos", apellidos);
                    comando.Parameters.AddWithValue("@edad", edad);
                    comando.Parameters.AddWithValue("@estatura", estatura);
                    comando.Parameters.AddWithValue("@telefono", telefono);
                    comando.Parameters.AddWithValue("@genero", genero);

                    comando.ExecuteNonQuery();
                }
                conexion.Close();
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = TB_Nombre.Text;
            string apellidos = TB_Apellido.Text;
            string edad = TB_Edad.Text;
            string estatura = TB_Estatura.Text;
            string telefono = TB_Telefono.Text;

            string genero = "";
            if (radbtn_Hombre.Checked)
            {
                genero = "Hombre";
            }
            else if (rdb_Mujer.Checked)
            {
                genero = "Mujer";
            }
            if (EsEnteroValido(edad) && EsDecimalValido(estatura) && EsEnteroValidoDe10Digitos(telefono) && EsTextoValido(nombre) && EsTextoValido(apellidos))
            {
                string datos = $"Nombres: {nombre}\r\nApellidos: {apellidos} \r\nTelefono: {telefono} kg\r\nEstatura:{estatura} cm\r\nEdad:{edad} años\r\nGenero: {genero}";
                string ruta = "C:/Users/96119/Downloads/carpetaprueba.txt";
                //File.WriteAllText(ruta,datos);
                bool archivoExiste = File.Exists(ruta);
                Console.WriteLine(archivoExiste);
                if (archivoExiste == false)
                {
                    File.WriteAllText(ruta, datos);
                }
                else
                {
                    using (StreamWriter writer = new StreamWriter(ruta))
                    {
                        if (archivoExiste)
                        {
                            writer.WriteLine();
                        }
                        writer.WriteLine(datos);
                    }
                }
                MessageBox.Show("Datos guardados correctamente:\n\n" + datos, "informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Datos no validos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool EsEnteroValido(string valor)
        {
            int resultado;
            return int.TryParse(valor, out resultado);
        }
        private bool EsDecimalValido(string valor)
        {
            decimal resultado;
            return decimal.TryParse(valor, out resultado);
        }
        private bool EsEnteroValidoDe10Digitos(string valor)
        {
            long resultado;
            return long.TryParse(valor, out resultado);
        }
        private bool EsTextoValido(string valor)
        {
            return Regex.IsMatch(valor, @"^[a-zA-Z\s]+$");
        }
        private void ValidarTelefono(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            string input = textbox.Text;
            input = input.Replace(" ", "").Replace("-", "");
            if (input.Length > 10)
            {
                if (!EsEnteroValidoDe10Digitos(input))
                {
                    MessageBox.Show("El telefono no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textbox.Clear();
                }

            }
            else if (!EsEnteroValidoDe10Digitos(input))
            {
                MessageBox.Show("El telefono no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ValidarEstatura(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (!EsDecimalValido(textbox.Text))
            {
                MessageBox.Show("La estatura no es valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textbox.Clear();
            }
        }
        private void ValidarEdad(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (!EsEnteroValido(textbox.Text))
            {
                MessageBox.Show("La edad no es valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textbox.Clear();
            }
        }
        private void ValidarApellido(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (!EsTextoValido(textbox.Text))
            {
                MessageBox.Show("El apellido no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textbox.Clear();
            }
        }
        private void ValidarNombre(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (!EsTextoValido(textbox.Text))
            {
                MessageBox.Show("El nombre no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textbox.Clear();
            }
        }
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            TB_Nombre.Clear();
            TB_Apellido.Clear();
            TB_Edad.Clear();
            TB_Estatura.Clear();
            TB_Telefono.Clear();
            radbtn_Hombre.Checked = false;
            rdb_Mujer.Checked = false;
        }
    }
}