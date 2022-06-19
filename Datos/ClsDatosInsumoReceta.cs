using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace Datos
{
    public class ClsDatosInsumoReceta
    {
        ClsDatosConexion conex = new ClsDatosConexion();

        public int AddInsumoReceta(int idInsumo, int idReceta, double cantidad, int IDUM)
        {
            MySqlCommand CM = new MySqlCommand();
            MySqlParameter x = new MySqlParameter();

            try
            {
                conex.conectar.Open();
                //Console.WriteLine("\n \n \n \n \n " + idInsumo + "" + idReceta + "" + cantidad + "" + IDUM);
                CM.Connection = conex.conectar; 
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "AgregarInsumoReceta";

                

                CM.Parameters.AddWithValue("PIdInsumo", idInsumo);
                CM.Parameters["PIdInsumo"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("PIdReceta", idReceta);
                CM.Parameters["PIdReceta"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("PCantidad", cantidad);
                CM.Parameters["PCantidad"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("PIdUM", IDUM);
                CM.Parameters["PIdUM"].Direction = ParameterDirection.Input;

               /* x = CM.Parameters.AddWithValue("PMSJ", "");
                CM.Parameters["PMSJ"].Direction = ParameterDirection.Output;
                */
                x = CM.Parameters.AddWithValue("PMSJ", "");
                CM.Parameters["PMSJ"].Direction = ParameterDirection.Output;

                CM.ExecuteNonQuery();
                return Convert.ToInt32(x.Value.ToString());
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.ToString());
                return -1;
            }
            finally
            {
                conex.conectar.Close();
            }



        }
        public int EliminarReceta( int idinsumo, int ireceta)
        {
            MySqlCommand CM = new MySqlCommand();
            MySqlParameter x = new MySqlParameter();//98704

            try
            {
                conex.conectar.Open();

                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "EliminarRecetaInsumo";

                CM.Parameters.AddWithValue("PidInsumo", idinsumo);
                CM.Parameters["PidInsumo"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("PidReceta", ireceta);
                CM.Parameters["PidReceta"].Direction = ParameterDirection.Input;


                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\nIdReceta" + ireceta+ "IdInsumo"+idinsumo);

                CM.ExecuteNonQuery();
                return 1;
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.ToString());
                return -1;
            }
            finally
            {
                conex.conectar.Close();
            }

        }

        public DataTable consulta(String sql)
        {
            return new ClsDatosMetodosGlobales().bdConsultas(sql);
        }


    }

}










