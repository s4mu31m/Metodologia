using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace uprofe
{
    public partial class Registro_Asignatura : Form
    {
        public Registro_Asignatura()
        {
            InitializeComponent();
        }

        private void Limpiar_texto()
        {
            nombre_asignatura.Text = "";
            cantidad_horas.Text = "";
            valor_hora.Text = "";
            mes.Text = "";
            cbx_profes.Text = "";

        }

        private void guardar_asignatura_Click(object sender, EventArgs e)
        {
            string Rpta = "";
            

            

            if (!int.TryParse(cantidad_horas.Text, out _))
            {
                Rpta = "La Cantidad de Horas debe estar expresada en números!!";
                MessageBox.Show(Rpta,"Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!int.TryParse(valor_hora.Text, out _))
            {
                Rpta = "El Valor de Horas debe estar expresada en números!!";
                MessageBox.Show(Rpta, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                prop_asignatura oAr = new prop_asignatura();
                oAr.nombre_asignatura = nombre_asignatura.Text.Trim();
                oAr.cantidad_horas = Convert.ToInt32(cantidad_horas.Text);
                oAr.valor_hora = Convert.ToInt32(valor_hora.Text);
                oAr.mes_impartido = mes.Text.Trim();
                oAr.profesor_asignatura = cbx_profes.Text.Trim();
                oAr.valor_a_pagar = Convert.ToInt32(oAr.cantidad_horas * oAr.valor_hora);
                data_asignatura Datos = new data_asignatura();
                


                Rpta = Datos.guardar_ar(oAr);

                if (Rpta.Equals("OK"))
                {

                    MessageBox.Show("Los datos se han guardado correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar_texto();
                }
                else
                {
                    MessageBox.Show(Rpta, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ingreso form = new Ingreso();
            form.Visible = true;
            Visible = false;
        }

        private void Registro_Asignatura_Load(object sender, EventArgs e)
        {
            MySqlConnection conexionBD = Conexion.getInstancia().CrearConexion();


            try
            {
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexionBD;
                comando.CommandText = ("SELECT nombre FROM profesor;");
                MySqlDataReader registro = comando.ExecuteReader();
                while (registro.Read())
                {
                    cbx_profes.Items.Add(registro["nombre"].ToString());

                }
            }
            catch (Exception b)
            {

                MessageBox.Show(b.Message + b.StackTrace);
            }

            conexionBD.Close();
        }
    }
}
