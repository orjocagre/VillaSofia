using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
namespace Datos
{

    public class ClsDatosInsumo
    {


        ClsDatosConexion conex = new ClsDatosConexion();

        public int AgregarInsumo(string Pnombre, int Pid_UM, double Ppresentacion, double Pprecio, double Pexistencia, String Penvase)
        {
            MySqlCommand CM = new MySqlCommand();
            MySqlParameter x = new MySqlParameter();//98704

            try
            {
                conex.conectar.Open();

                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "AgregarInsumo";

                CM.Parameters.AddWithValue("Pnombre", Pnombre);
                CM.Parameters["Pnombre"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pid_UM", Pid_UM);
                CM.Parameters["Pid_UM"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pprecio", Pprecio);
                CM.Parameters["Pprecio"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Ppresentacion", Ppresentacion);
                CM.Parameters["Ppresentacion"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pexistencia", Pexistencia);
                CM.Parameters["Pexistencia"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Penvase", Penvase);
                CM.Parameters["Penvase"].Direction = ParameterDirection.Input;

                x = CM.Parameters.AddWithValue("PMSJ", "");
                CM.Parameters["PMSJ"].Direction = ParameterDirection.Output;

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


        public DataTable ListarInsumos(String sql)
        {
            return new ClsDatosMetodosGlobales().bdConsultas(sql);
        }
        public DataTable consulta(String sql)
        {
            return new ClsDatosMetodosGlobales().bdConsultas(sql);
        }
    }
}