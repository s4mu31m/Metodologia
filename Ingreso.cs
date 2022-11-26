using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace uprofe
{
    public partial class Ingreso : Form
    {
        public Ingreso()
        {
            InitializeComponent();
        }

        int nCodigo_ar = 0;

        private void Selecciona_item()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dgv_reporte.CurrentRow.Cells["id_asignatura"].Value)))
            {
                MessageBox.Show("Selecciona un registro válido", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                this.nCodigo_ar = Convert.ToInt32(dgv_reporte.CurrentRow.Cells["id_asignatura"].Value);
            }
        }

        private void Formato_al()
        {

            dgv_reporte.Columns[0].Visible = false;
            dgv_reporte.Columns[1].Width = 150;
            dgv_reporte.Columns[1].HeaderText = "ASIGNATURA";
            dgv_reporte.Columns[2].Width = 100;
            dgv_reporte.Columns[2].HeaderText = "HORAS ASIGNATURA";
            dgv_reporte.Columns[3].Width = 100;
            dgv_reporte.Columns[3].HeaderText = "VALOR HORA";
            dgv_reporte.Columns[4].Width = 150;
            dgv_reporte.Columns[4].HeaderText = "MES IMPARTIDO";
            dgv_reporte.Columns[5].Width = 150;
            dgv_reporte.Columns[5].HeaderText = "PROFESOR ASIGNADO";
            dgv_reporte.Columns[6].Width = 150;
            dgv_reporte.Columns[6].HeaderText = "TOTAL A PAGAR";
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



        private void Listar_asignaturas()
        {
            MySqlConnection conexionBD = Conexion.getInstancia().CrearConexion();


            try
            {
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexionBD;
                comando.CommandText = ("SELECT * FROM asignatura;");

                MySqlDataAdapter adaptar = new MySqlDataAdapter();
                adaptar.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptar.Fill(tabla);
                dgv_reporte.DataSource = tabla;
                this.Formato_al();

            }
            catch (Exception b)
            {

                MessageBox.Show(b.Message + b.StackTrace);
            }

            conexionBD.Close();
        }


        private void ingresoProfe_Click(object sender, EventArgs e)
        {
            Ingreso_docente form = new Ingreso_docente();
            form.Visible = true;
            Visible = false;
        }

        private void eliminarRegistro_Click(object sender, EventArgs e)
        {

            string Rpta = "";
            data_asignatura Datos = new data_asignatura();
            Rpta = Datos.Eliminar_ar(nCodigo_ar);

            if (Rpta.Equals("OK"))
            {

                nCodigo_ar = 0;
                MessageBox.Show("Registro eliminado correctamente", "Aviso del Sistema", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("No tiene seleccionado ningún registro", "Aviso del Sistema", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            Listar_asignaturas();
        }

        private void dgv_reporte_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Selecciona_item();
        }

        private void Ingreso_Load(object sender, EventArgs e)
        {
            Listar_asignaturas();
        }
    }
}
