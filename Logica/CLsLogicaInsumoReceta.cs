using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Logica
{
   public class CLsLogicaInsumoReceta
    {


        public String ingresarDatosInsumo(string nombreIng)
        {

            ClsLogicaInsumo AddInsumo = new ClsLogicaInsumo();


            string X = AddInsumo.ingresarInsumos(nombreIng);

            return X;
        }

       public String ingresarDatosReceta(String nombreReceta, int porciones, String procedimiento)
        {

            ClsLogicaAddReceta AddReceta = new ClsLogicaAddReceta();


            string X = AddReceta.AddReceta(nombreReceta, porciones, procedimiento);

            return X;
        }
       

        public String AddInsumoR(int idInsumo, int idReceta, double cantidad,int IDUM)
        {


            ClsDatosInsumoReceta IReceta = new ClsDatosInsumoReceta();
            int i = IReceta.AddInsumoReceta(idInsumo,idReceta,cantidad, IDUM);

            string mensaje="";
            if (i == 1)
            {
                mensaje = "Ya esta agregado este insumo a la receta,\n Ingrese un nuevo insumo!";

            }
           if(i == 7)
           {
                mensaje = "Se guardo con Éxito el nuevo igrediente!";

           }
           
          
            return mensaje;
        }

        public string EliminarRecetaInsumo(int idinsumo, int ireceta)
        {
            int i;
            ClsDatosInsumoReceta InReceta = new ClsDatosInsumoReceta();

            i = InReceta.EliminarReceta( idinsumo, ireceta);
            String mensaje;



            if (i == -1)
            {
                mensaje = "Error al Eliminar";

            }
            else
            {
                mensaje = "Error al Eliminar";


            }



            return mensaje;
        }

   
        public DataTable ListarInsumos(string x)
        {
            string sql = "SELECT * FROM vistamostrarinsumos WHERE vistamostrarinsumos.id_receta ="+ x  ;
            // Datos.ClsDatosRegistroTrabajador Lista = new Datos.ClsDatosRegistroTrabajador();
            //  return new ClsDatosTipoTrabajador().ListarTipoTrabajador(sql);
            return new ClsDatosInsumoReceta().consulta(sql);
        }
      

    }
}
