using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace uprofe
{
    public class data_profe
    {
        public string guardar_ar(prop_profesor oAr)
        {
            string Rpta = "";
            string query = "";


            MySqlConnection SqlCon = new MySqlConnection();

            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();


                query =
                    "INSERT INTO profesor " + "(`nombre`, `rut`, `fecha_nacimiento`, " +
                    "`titulo`, `experiencia`) " +
                    "VALUES ('" + oAr.nombre + "','" +
                    oAr.rut + "', '" +
                    oAr.fecha_nacimiento + "', '" +
                    oAr.titulo + "', '" +
                    oAr.experiencia + "');";

                MySqlCommand Comando = new MySqlCommand(query, SqlCon);
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo ingresar el registro";
            }
            catch (Exception ex)
            {

                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }

            return Rpta;
        }
    }
}