using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.IO;
namespace Datos
{
    public class ClsDatosConexion
    {
        //static string host = "127.0.0.1";
        //static string usuario = "root";
        //static string clave = "root";
        //static string BaseDatos = "vs0808522";

       
       static string[] lineas = File.ReadAllLines(@"C:\credenciales.txt");
        
        static string host = lineas[0];
        static string usuario = lineas[1];
        static string clave = lineas[2];
        static string BaseDatos = lineas[3];
         

        public MySqlConnection conectar = new MySqlConnection("datasource=" + host + ";username=" + usuario + ";password=" + clave + ";database=" + BaseDatos);

    }



    
    
        
    
}
