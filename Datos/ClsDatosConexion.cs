using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
namespace Datos
{
    public class ClsDatosConexion
    {
        static string host = "127.0.0.1";
        static string usuario = "root";
        static string clave = "root";
        static string BaseDatos = "vs0808522";

        //static string host = "btvgotij9h4tsvz21ler-mysql.services.clever-cloud.com";
        //static string usuario = "u2gwnvvdthxma2nd";
        //static string clave = "WeZuge38NwtPEyu2TmcS";
        //static string BaseDatos = "btvgotij9h4tsvz21ler";


        public MySqlConnection conectar = new MySqlConnection("datasource=" + host + ";username=" + usuario + ";password=" + clave + ";database=" + BaseDatos);

    }
}
