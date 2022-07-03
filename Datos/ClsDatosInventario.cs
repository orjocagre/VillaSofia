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

        public int editarMinimoInsumo(int PidInsumo, double Pminimo)
        {
            MySqlCommand CM = new MySqlCommand();
            MySqlParameter x = new MySqlParameter();

            try
            {
                conex.conectar.Open();
                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "EditarMinimo";

                CM.Parameters.AddWithValue("PidInsumo", PidInsumo);
                CM.Parameters["PidInsumo"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pminimo", Pminimo);
                CM.Parameters["Pminimo"].Direction = ParameterDirection.Input;

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

        public int agregarInsumoListaCompras(int Pid_insumo, int Pid_listaCompras, String Penvase, double Pexistencia, double Ppresentacion, double Pprecio, double Pminimo, double Pcompras)
        {
            MySqlCommand CM = new MySqlCommand();
            MySqlParameter x = new MySqlParameter();

            Console.WriteLine("Pid_insumo" + Pid_insumo+ "Pid_listaCompras " + Pid_listaCompras + "Penvase " + Penvase + " Pexistencia" + Pexistencia + "Ppresentacion " + Ppresentacion + " Pprecio" + Pprecio + " Pminimo" + Pminimo + "Pcompras " + Pcompras);
            try
            {
                conex.conectar.Open();
                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "agregarlistacompras_insumo";

                CM.Parameters.AddWithValue("Pid_insumo", Pid_insumo);
                CM.Parameters["Pid_insumo"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pid_listaCompras", Pid_listaCompras);
                CM.Parameters["Pid_listaCompras"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Penvase", Penvase);
                CM.Parameters["Penvase"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pexistencia", Pexistencia);
                CM.Parameters["Pexistencia"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Ppresentacion", Ppresentacion);
                CM.Parameters["Ppresentacion"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pprecio", Pprecio);
                CM.Parameters["Pprecio"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pminimo", Pminimo);
                CM.Parameters["Pminimo"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pcompras", Pcompras);
                CM.Parameters["Pcompras"].Direction = ParameterDirection.Input;

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


        public int agregarListaCompras()
        {
            MySqlCommand CM = new MySqlCommand();
            MySqlParameter x = new MySqlParameter();

            try
            {
                conex.conectar.Open();
                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "AgregarListaCompras";

                CM.Parameters.AddWithValue("Pfecha", DateTime.Now.ToString("yyy-MM-dd HH:mm:ss"));
                CM.Parameters["Pfecha"].Direction = ParameterDirection.Input;

                x = CM.Parameters.AddWithValue("Pmsj", "");
                CM.Parameters["Pmsj"].Direction = ParameterDirection.Output;

                CM.ExecuteNonQuery();

                return Convert.ToInt32(x.Value.ToString());

            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.ToString());
                return -3;
            }
            finally
            {
                conex.conectar.Close();
            }
        }
    }
}
