using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class ClsDatosInventario
    {
        ClsDatosConexion conex = new ClsDatosConexion();
        public DataTable consulta(String sql)
        {
            return new ClsDatosMetodosGlobales().bdConsultas(sql);
        }

        public int agregarEntrada(int Pid_insumo, double Pcantidad, DateTime Pfecha, double Pprecio)
        {
            MySqlCommand CM = new MySqlCommand();
            MySqlParameter x = new MySqlParameter();

            try
            {
                conex.conectar.Open();
                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "AgregarEntradaInsumo";

                CM.Parameters.AddWithValue("Pid_insumo", Pid_insumo);
                CM.Parameters["Pid_insumo"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pcantidad", Pcantidad);
                CM.Parameters["Pcantidad"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pfecha", Pfecha.ToString("yyy-MM-dd HH:mm:ss"));
                CM.Parameters["Pfecha"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pprecio", Pprecio);
                CM.Parameters["Pprecio"].Direction = ParameterDirection.Input;

                x = CM.Parameters.AddWithValue("Pmsj", "");
                CM.Parameters["Pmsj"].Direction = ParameterDirection.Output;

                CM.ExecuteNonQuery();

                return Convert.ToInt32(x.Value.ToString());


            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.ToString());
                return 3;
            }
            finally
            {
                conex.conectar.Close();
            }
        }


        public int agregarSalida(int Pid_insumo, double Pcantidad, DateTime Pfecha, double Pprecio)
        {
            MySqlCommand CM = new MySqlCommand();
            MySqlParameter x = new MySqlParameter();

            try
            {
                conex.conectar.Open();
                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "agregarSalida";

                CM.Parameters.AddWithValue("Pid_insumo", Pid_insumo);
                CM.Parameters["Pid_insumo"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pcantidad", Pcantidad);
                CM.Parameters["Pcantidad"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pfecha", Pfecha.ToString("yyy-MM-dd HH:mm:ss"));
                CM.Parameters["Pfecha"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pprecio", Pprecio);
                CM.Parameters["Pprecio"].Direction = ParameterDirection.Input;

                x = CM.Parameters.AddWithValue("Pmsj", "");
                CM.Parameters["Pmsj"].Direction = ParameterDirection.Output;

                CM.ExecuteNonQuery();

                return Convert.ToInt32(x.Value.ToString());


            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.ToString());
                return 3;
            }
            finally
            {
                conex.conectar.Close();
            }
        }
    }
}
