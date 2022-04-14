using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Datos
{
    public class ClsDatosUsuario
    {
        public int registro(ClsModeloUsuario usuario)
        {

            ClsDatosConexion conex = new ClsDatosConexion();
            conex.conectar.Open();

            String sql = "INSERT INTO usuarios (usuario,password,nombre,id_tipo)" +
                "VALUES(@usuario, @password, @nombre, @id_tipo)";
            MySqlCommand comando = new MySqlCommand(sql, conex.conectar);
            comando.Parameters.AddWithValue("@usuario", usuario.Usuario1);
            comando.Parameters.AddWithValue("@password", usuario.Password);
            comando.Parameters.AddWithValue("@nombre", usuario.Nombre);
            comando.Parameters.AddWithValue("@id_tipo", 3);

            int resultado = comando.ExecuteNonQuery();

            return resultado;

        }

        public bool existeUsuario(string usuario)
        {
            //MySqlDataReader reader;


            //MySqlConnection conexion = Datos.DatosConexion.getConexion();
            //conexion.Open();

            //String sql = "SELECT id FROM usuarios WHERE usuario LIKE @usuario";
            //MySqlCommand comando = new MySqlCommand(sql, conexion);
            //comando.Parameters.AddWithValue("@usuario", usuario);

            //reader = comando.ExecuteReader();

            //if (reader.HasRows)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            String sql = "SELECT id FROM usuarios WHERE usuario LIKE "+usuario;
            DataTable DT = new ClsDatosMetodosGlobales().bdConsultas(sql);

            return DT.Rows.Count > 0 ? true : false;



        }

        public ClsModeloUsuario validacion(string usuario)
        {
            //MySqlDataReader reader;


            //MySqlConnection conexion = Datos.DatosConexion.getConexion();
            //conexion.Open();

            //String sql = "SELECT id, password, nombre, id_tipo FROM usuarios WHERE usuario LIKE @usuario";
            //MySqlCommand comando = new MySqlCommand(sql, conexion);
            //comando.Parameters.AddWithValue("@usuario", usuario);

            //reader = comando.ExecuteReader();

            //ClsUsuarios usr = null;

            //while (reader.Read())
            //{
            //    usr = new ClsUsuarios();

            //    usr.Id = int.Parse(reader["id"].ToString());
            //    usr.Password = reader["password"].ToString();
            //    usr.Nombre = reader["nombre"].ToString();
            //    usr.Id_tpo = int.Parse(reader["id_tipo"].ToString());
            //    return usr;

            //}
            //return usr;

            ClsModeloUsuario mUsuario = new ClsModeloUsuario();
            String sql = "SELECT id, password, nombre, id_tipo FROM usuarios WHERE usuario LIKE '" + usuario + "'";
            DataTable DT = new ClsDatosMetodosGlobales().bdConsultas(sql);
            if(DT.Rows.Count > 0)
            {
                mUsuario.Id = DT.Rows[0].Field<int>(0);
                mUsuario.Password = DT.Rows[0].Field<String>(1);
                mUsuario.Nombre = DT.Rows[0].Field<String>(2);
                mUsuario.Id_tpo = DT.Rows[0].Field<int>(3);

            }
            return mUsuario;


        }
    }
}
