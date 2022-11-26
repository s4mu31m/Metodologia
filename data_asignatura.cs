using MySql.Data.MySqlClient;
using System;
using System.Data;


namespace uprofe
{
    public class data_asignatura
    {
        public string guardar_ar(prop_asignatura oAr)
        {
            string Rpta = "";
            string query = "";


            MySqlConnection SqlCon = new MySqlConnection();

            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                

                query =
                    "INSERT INTO asignatura (`nombre_asignatura`, `cantidad_horas`, `valor_hora`, " +
                    "`mes_impartido`, `profesor_asignatura', `valor_a_pagar`) VALUES ('" 
                    + oAr.nombre_asignatura + "', '" 
                    + oAr.cantidad_horas + "', '" 
                    + oAr.valor_hora + "', '"
                    + oAr.mes_impartido + "', '" 
                    + oAr.profesor_asignatura + "', '" 
                    + oAr.valor_a_pagar + "');";

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
        public string Eliminar_ar(int nCodigo_ar)
        {
            string Rpta = "";
            string query = "";

            MySqlConnection SqlCon = new MySqlConnection();

            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                query = "delete from asignatura where id_asignatura='" + nCodigo_ar + "'";

                MySqlCommand Comando = new MySqlCommand(query, SqlCon);
                SqlCon.Open();

                Rpta = Comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo eliminar el registro";

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
