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
            profesor_asignado.Text = "";

        }

        private void guardar_asignatura_Click(object sender, EventArgs e)
        {
            string Rpta = "";


            prop_asignatura oAr = new prop_asignatura();
            oAr.nombre_asignatura = nombre_asignatura.Text.Trim();
            oAr.cantidad_horas = Convert.ToInt32(cantidad_horas.Text);
            oAr.valor_hora = Convert.ToInt32(valor_hora.Text);
            oAr.mes_impartido = mes.Text.Trim();
            oAr.profesor_asignatura = profesor_asignado.Text.Trim();


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

        private void button3_Click(object sender, EventArgs e)
        {
            Ingreso form = new Ingreso();
            form.Visible = true;
            Visible = false;
        }
    }
}
