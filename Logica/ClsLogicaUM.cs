using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;
namespace Logica
{
   public class ClsLogicaUM
    {

        public string AddUM(String descripcion)
        {


            ClsDatosUM UM = new ClsDatosUM();

            int i = UM.AddUM(descripcion);
            String mensaje = "";


            if (i == 1)
            {
                mensaje = "Esta Unidad de medida ya fue regstrada,\n Ingrese una nueva unidad de medida!";

            }
            if (i == 7)
            {
                mensaje = "Se guardo con Éxito la nueva uindad de medida!";

            }



            return mensaje;
        }
        


     
        public DataTable UM()
        {
            string sql = "SELECT um.id_UM AS ID, um.descripcion AS DESCRIPCION FROM um";
            return new ClsDatosUM().UM(sql);
        }


        public DataTable listarUm()
        {
            ClsDatosUM um = new ClsDatosUM();
            String sql = "SELECT um.id_UM AS ID, um.descripcion AS NOMBRE, um.id_tipo_um AS TIPO, um.conversion AS CONVERSION FROM um";
            return um.consultas(sql);
        }

    }
}
