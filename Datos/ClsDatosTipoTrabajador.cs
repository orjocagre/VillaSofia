﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;


namespace Datos
{
    public class ClsDatosTipoTrabajador
    {

        ClsDatosConexion conex = new ClsDatosConexion();

        
            public int AddTipoTrabajador(String descripcion)
            {
                MySqlCommand CM = new MySqlCommand();
                MySqlParameter x = new MySqlParameter();//98704

                try
                {
                    conex.conectar.Open();

                    CM.Connection = conex.conectar;
                    CM.CommandType = CommandType.StoredProcedure;
                    CM.CommandText = "AgregarTipoTrabajador";

                    CM.Parameters.AddWithValue("Pdescripcion", descripcion);
                    CM.Parameters["Pdescripcion"].Direction = ParameterDirection.Input;



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



        public DataTable ListarTipoTrabajador(String sql)
        {
          
            return new ClsDatosMetodosGlobales().bdConsultas(sql);
        }



    }
}
