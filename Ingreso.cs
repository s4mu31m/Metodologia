using Microsoft.Win32;
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

namespace uprofe
{
    public partial class Ingreso : Form
    {
        public Ingreso()
        {
            InitializeComponent();
        }





        private void salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registro_Asignatura form = new Registro_Asignatura();
            form.Visible = true;
            Visible = false;
        }

        private void Ingreso_Load(object sender, EventArgs e)
        {
            MySqlConnection conexionBD = Conexion.getInstancia().CrearConexion();


            try
            {
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexionBD;
                comando.CommandText = ("select * from asignatura;");

                MySqlDataAdapter adaptar = new MySqlDataAdapter();
                adaptar.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptar.Fill(tabla);
                dgv_reporte.DataSource = tabla;

            }
            catch (Exception b)
            {

                MessageBox.Show(b.Message + b.StackTrace);
            }

            conexionBD.Close();
        }
    }
}
