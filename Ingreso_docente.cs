using System;
using System.Windows.Forms;

namespace uprofe
{
    public partial class Ingreso_docente : Form
    {
        public Ingreso_docente()
        {
            InitializeComponent();
        }
        private void Limpiar_texto()
        {
            txt_NombreProfesor.Text = "";
            txt_RutProfe.Text = "";
            txt_fechaProfe.Text = "";
            txt_titulo.Text = "";
            txt_experiencia.Text = "";

        }

        private void GuardarProfe_Click(object sender, EventArgs e)
        {
            string Rpta = "";


            prop_profesor oAr = new prop_profesor();
            oAr.nombre = txt_NombreProfesor.Text.Trim();
            oAr.rut = txt_RutProfe.Text.Trim();
            oAr.fecha_nacimiento = txt_fechaProfe.Text.Trim();
            oAr.titulo = txt_fechaProfe.Text.Trim();
            oAr.experiencia = txt_experiencia.Text.Trim();



            data_profe Datos = new data_profe();
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


        private void atras_Click(object sender, EventArgs e)
        {
            Ingreso form = new Ingreso();
            form.Visible = true;
            Visible = false;
        }
    }
}

