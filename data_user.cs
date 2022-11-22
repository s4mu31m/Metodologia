using MySql.Data.MySqlClient;

namespace uprofe
{
    public class data_user
    {
        public prop_user Login_user(string usuario)
        {
            MySqlDataReader reader;
            MySqlConnection SqlCon = new MySqlConnection();
            SqlCon = Conexion.getInstancia().CrearConexion();
            SqlCon.Open();

            string query = "SELECT id_usuario, password, usuario, tipo_usuario FROM usuarios WHERE usuario like @usuario";
            MySqlCommand Comando = new MySqlCommand(query, SqlCon);
            Comando.Parameters.AddWithValue("@usuario", usuario);

            reader = Comando.ExecuteReader();

            prop_user usr = null;

            while (reader.Read())
            {
                usr = new prop_user();
                usr.id_usuario = int.Parse(reader["id_usuario"].ToString());
                usr.tipo_usuario = int.Parse(reader["tipo_usuario"].ToString());
                usr.password = reader["password"].ToString();
                usr.usuario = reader["usuario"].ToString();

            }
            return usr;
        }
    }
}