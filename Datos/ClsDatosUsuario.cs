using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Datos
{
    public class ClsDatosUsuario
    {
        ClsDatosConexion conex = new ClsDatosConexion();
        ClsDatosMetodosGlobales metodoG = new ClsDatosMetodosGlobales();
        public int registro(ClsModeloUsuario usuario)
        {
            conex.conectar.Open();

            String sql = "INSERT INTO usuarios (usuario,password,nombre,id_tipo)" +
                "VALUES(@usuario, @password, @nombre, @id_tipo)";
            MySqlCommand comando = new MySqlCommand(sql, conex.conectar);
            comando.Parameters.AddWithValue("@usuario", usuario.Usuario1);
            comando.Parameters.AddWithValue("@password", usuario.Password);
            comando.Parameters.AddWithValue("@nombre", usuario.Nombre);
            comando.Parameters.AddWithValue("@id_tipo", usuario.Id_tpo);

            int resultado = comando.ExecuteNonQuery();

            return resultado;

        }

        public bool existeUsuario(string usuario)
        {
            //MySqlDataReader reader;


            //MySqlConnection conexion = Datos.DatosConexion.getConexion();
            //conex.conectar.Open();

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

        /*
        public string EditarUsuario(int id, string username, string password, string rol, string nombre, string apellido, int id_sucursal)
        {
            Conectar.conectar.Open();

            MySqlCommand CMD = new MySqlCommand("EditarUsuario", Conectar.conectar);
            CMD.CommandType = CommandType.StoredProcedure;

            CMD.Parameters.AddWithValue("@pId", id);
            CMD.Parameters.AddWithValue("@pUser", username);
            CMD.Parameters.AddWithValue("@pPasw", password);

            CMD.Parameters.AddWithValue("@pRol", rol);

            CMD.Parameters.AddWithValue("@pNombre", nombre);
            CMD.Parameters.AddWithValue("@pApellido", apellido);
            CMD.Parameters.AddWithValue("@pid_sucursal", id_sucursal);
            CMD.Parameters.Add("@pMsj", MySqlDbType.VarChar, 30);
            CMD.Parameters["@pMsj"].Direction = ParameterDirection.Output;

            try
            {
                CMD.ExecuteNonQuery();
                string Mensaje = Convert.ToString(CMD.Parameters["@pMsj"].Value);
                return Mensaje;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            finally
            {
                Conectar.conectar.Close();
            }


        }

        /---------
        */
        public string CambiarEstado(string _id, string _accion)
        {
            conex.conectar.Open();

            MySqlCommand CMD = new MySqlCommand("CambiarEstadoUsuario", conex.conectar);
            CMD.CommandType = CommandType.StoredProcedure;

            CMD.Parameters.AddWithValue("@pId", _id);
            CMD.Parameters.AddWithValue("@pAccion", _accion);


            CMD.Parameters.Add("@pMsj", MySqlDbType.VarChar, 30);
            CMD.Parameters["@pMsj"].Direction = ParameterDirection.Output;

            try
            {
                CMD.ExecuteNonQuery();
                string Mensaje = Convert.ToString(CMD.Parameters["@pMsj"].Value);
                return Mensaje;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            finally
            {
                conex.conectar.Close();
            }


        }
        
        public string LogueoU(string id, string LogU)
        {


            conex.conectar.Open();
            MySqlParameter x;

            MySqlCommand CMD = new MySqlCommand("LogUnico", conex.conectar);
            CMD.CommandType = CommandType.StoredProcedure;

            CMD.Parameters.AddWithValue("pId", id);
            CMD.Parameters.AddWithValue("pLogueo", LogU);

            x = CMD.Parameters.Add("@pMsj", MySqlDbType.VarChar, 30);
            CMD.Parameters["@pMsj"].Direction = ParameterDirection.Output;


            try
            {
                CMD.ExecuteNonQuery();
                string Mensaje = Convert.ToString(CMD.Parameters["@pMsj"].Value);
                return Mensaje;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            finally
            {
                conex.conectar.Close();
            }
        }
        
        // Método para instanciar el inicio de sesión
        public int AgregarInicioSesion(int ID, String fecha, String Hora, String IpMaquina)
        {
            try
            {
                MySqlCommand CM = new MySqlCommand();
                MySqlParameter x;
                conex.conectar.Open();

                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "AgregarInicioBitacora";


                CM.Parameters.AddWithValue("pid", ID);
                CM.Parameters["pid"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pFechaInicio", fecha);
                CM.Parameters["pFechaInicio"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pHoraInicio", Hora);
                CM.Parameters["pHoraInicio"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pIpDispositivo", IpMaquina);
                CM.Parameters["pIpDispositivo"].Direction = ParameterDirection.Input;

                x = CM.Parameters.AddWithValue("pMsg", "");
                CM.Parameters["pMsg"].Direction = ParameterDirection.Output;
                
                CM.ExecuteNonQuery();

                return Convert.ToInt32(x.Value.ToString());

            }
            catch (MySqlException e)
            {

                Console.WriteLine(e.ToString());
                return 0;
            }

            finally
            {
                conex.conectar.Close();
            }

        }  //Fin del método
        
        public int AgregarCierreSesion(int ID, String fecha, String Hora)
        {
            try
            {
                MySqlCommand CM = new MySqlCommand();
                MySqlParameter x;
                conex.conectar.Open();

                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "AgregarSalidaBitacora";


                CM.Parameters.AddWithValue("pid", ID);
                CM.Parameters["pid"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pFechaCierreSesion", fecha);
                CM.Parameters["pFechaCierreSesion"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pHoraCierreSesion", Hora);
                CM.Parameters["pHoraCierreSesion"].Direction = ParameterDirection.Input;

                

                x = CM.Parameters.AddWithValue("pMsj", "");
                CM.Parameters["pMsj"].Direction = ParameterDirection.Output;

                CM.ExecuteNonQuery();

                return Convert.ToInt32(x.Value.ToString());

            }
            catch (MySqlException e)
            {

                Console.WriteLine(e.ToString());
                return 0;
            }

            finally
            {
                conex.conectar.Close();
            }
            //Fin del método

        }

        // Método para traer la biracora del inicio de sesión en el sistema
        //ya ta
        public DataTable bitacora(String Sql)
        {
            return metodoG.bdConsultas(Sql);
        }

        public DataTable nombreSucursal(String Sql)
        {
            return metodoG.bdConsultas(Sql);
        }

        public DataTable CmbSucursal(String Sql)
        {
            return metodoG.bdConsultas(Sql);
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
