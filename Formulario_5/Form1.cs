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

namespace Formulario_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            string datos = $"Nombres: {nombre}\r\nApellidos: {apellidos} \r\nTelefono: {telefono} kg\r\nEstatura:{estatura} cm\r\nEdad:{edad} años\r\nGenero: {genero}";
            string ruta = "C:/Users/96119/Downloads/carpetaprueba.txt";
            //File.WriteAllText(ruta,datos);
            bool archivoExiste = File.Exists(ruta);
            Console.WriteLine(archivoExiste);
            if (archivoExiste==false)
            {
                File.WriteAllText(ruta, datos);
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(ruta))
                {
                    if (archivoExiste)
                    {
                        writer.WriteLine( );
                    }
                    writer.WriteLine(datos);
                }
            }
            MessageBox.Show("Datos guardados correctamente:\n\n"+ datos, "informacion", MessageBoxButtons.OK,MessageBoxIcon.Information);
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
