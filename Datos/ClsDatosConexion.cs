using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Reflection;
using System.IO;
namespace Datos
{
    public class ClsDatosConexion
    {
        /*static string host = "127.0.0.1";
        static string usuario = "root";
        static string clave = "root";
        static string BaseDatos = "vs0808522";*/

        //static string host = "btvgotij9h4tsvz21ler-mysql.services.clever-cloud.com";
        //static string usuario = "u2gwnvvdthxma2nd";
        //static string clave = "WeZuge38NwtPEyu2TmcS";
        //static string BaseDatos = "btvgotij9h4tsvz21ler";

        //static string[] lineas = File.ReadAllLines(@"C:\credenciales.txt");

        //devuelve el .txt en una sola variable como texto
       // static String strResourceName = "credenciales.txt";
        //static Assembly asm = Assembly.GetExecutingAssembly();
        //static Stream rsrcStream = asm.GetManifestResourceStream(asm.GetName().Name + ".Properties." + strResourceName);
        //static StreamReader sRdr = new StreamReader(rsrcStream);
        //static String credenciales = sRdr.ReadToEnd();
        //transforma el string multilinea en an array de strings
        static String rt = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "credenciales.txt");
        static string[] lineas = File.ReadAllLines(rt);
        /// <summary>
        /// static string[] lineas = credenciales.Split(new string[] { System.Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
        /// </summary>

        static string host = lineas[0];
        static string usuario = lineas[1];
        static string clave = lineas[2];
        static string BaseDatos = lineas[3];


        public MySqlConnection conectar = new MySqlConnection("datasource=" + host + ";username=" + usuario + ";password=" + clave + ";database=" + BaseDatos);

    }
    
}
