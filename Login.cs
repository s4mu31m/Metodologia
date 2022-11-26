using Microsoft.Win32;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public string Control_login(string usuario, string password)
        {
            data_user users = new data_user();
            string Rpta = "";
            prop_user datos_usuarios = null;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password))
            {
                Rpta = "Debe llenar todos los campos";
            }
            else
            {
                datos_usuarios = users.Login_user(usuario);

                if (datos_usuarios == null)
                {
                    Rpta = "El usuario no existe";
                }
                else
                {
                    if (datos_usuarios.password != password)
                    {
                        Rpta = "El usuario y/o contraseña no coinciden";
                    }
                }
            }

            return Rpta;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string usuario = txt_user.Text;
            string password = txt_password.Text;

            try
            {
                string Rpta = Control_login(usuario, password);

                if (Rpta.Length > 0)
                {
                    MessageBox.Show(Rpta, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Ingreso form = new Ingreso(); //si es correcto lo mande operaciones
                    form.Visible = true;
                    this.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      
    }

}
