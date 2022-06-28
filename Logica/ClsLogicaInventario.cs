using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Logica
{
    //linea para salir es este chacuatol
    public class ClsLogicaInventario
    {
        public DataTable mostrarInventarioActualEnUm()
        {
            ClsDatosInventario inventario = new ClsDatosInventario();
            return inventario.consulta("SELECT insumo.id_insumo AS ID, insumo.nombre AS NOMBRE, insumo.existencia AS CANTIDAD, um.descripcion AS UM  FROM insumo, um WHERE insumo.id_UM = um.id_UM");

        }

        public DataTable mostrarInventarioActualEnUds()
        {
            ClsDatosInventario inventario = new ClsDatosInventario();
            return inventario.consulta("SELECT insumo.id_insumo AS ID, insumo.nombre AS NOMBRE, (insumo.existencia / insumo.presentacion) AS CANTIDAD, insumo.envase AS ENVASE, insumo.presentacion AS PRESENTACION, um.descripcion AS UM FROM insumo, um WHERE insumo.id_UM = um.id_UM");
        }

        public int agregarEntrada(int Pid_insumo, double Pcantidad, DateTime Pfecha, double Pprecio)
        {
            ClsDatosInventario inventario = new ClsDatosInventario();
            int msj = inventario.agregarEntrada(Pid_insumo, Pcantidad, Pfecha, Pprecio);
            return msj;

        }
        public DataTable listarInsumos()
        {
            ClsDatosInventario registro = new ClsDatosInventario();
            String sql = "SELECT insumo.nombre AS sinF, insumo.nombre AS sin, insumo.nombre AS nom, insumo.id_insumo as id FROM insumo ORDER BY insumo.id_insumo";
            return registro.consulta(sql);
        }

        public DataTable listarUMInsumos()
        {
            ClsDatosInventario inventario = new ClsDatosInventario();
            String sql = "SELECT insumo.id_insumo AS ID, insumo.id_UM AS UM, um.id_tipo_um AS TIPO, um.conversion AS CONVERSION FROM insumo, um WHERE insumo.id_UM = um.id_UM ORDER BY insumo.id_insumo";
            return inventario.consulta(sql);
        }

        public void disminuirUnProductodeInventario(int idProducto, int unidades)
        {
            ClsDatosInventario inventario = new ClsDatosInventario();
            String sql = "SELECT insumo.id_insumo AS ID, insumo_receta.cantidad AS CANTIDAD, insumo_receta.IdUM AS IDUMRECETA, insumo.id_UM AS IDUMINSUMO FROM insumo, insumo_receta, receta, producto, um WHERE producto.id_receta = receta.id_receta AND receta.id_receta = insumo_receta.idReceta AND insumo_receta.idInsumo = insumo.id_insumo AND insumo_receta.IdUM = um.id_UM AND producto.idProducto = " + idProducto;
            DataTable insumos = inventario.consulta(sql);
            sql = "SELECT um.id_UM AS ID, um.conversion AS conversion FROM um";
            DataTable um = inventario.consulta(sql);

            for(int i=0; i<insumos.Rows.Count; i++)
            {
                int idInsumo = Convert.ToInt32(insumos.Rows[i][0]);
                double cantidadEnUMReceta = Convert.ToDouble(insumos.Rows[i][1]);
                int idUMReceta = Convert.ToInt32(insumos.Rows[i][2]);
                int idUMInsumo = Convert.ToInt32(insumos.Rows[i][3]);
                double conversionUMReceta = -1;
                double conversionUMInsumo = -1;


                for (int j=0; j<um.Rows.Count; j++)
                {
                    if(conversionUMReceta == -1 || conversionUMInsumo == -1)
                    {
                        if (idUMReceta == Convert.ToInt32(um.Rows[j][0]))
                        {
                            conversionUMReceta = Convert.ToDouble(um.Rows[j][1]);
                        }
                        if (idUMInsumo == Convert.ToInt32(um.Rows[j][0]))
                        {
                            conversionUMInsumo = Convert.ToDouble(um.Rows[j][1]);
                        }
                    }
                    else
                    {
                        j = um.Rows.Count;
                    }
                }
                if (conversionUMReceta != -1 && conversionUMInsumo != -1)
                {
                    double cantidadEnUMInsumo = ((cantidadEnUMReceta * conversionUMReceta) / conversionUMInsumo) * unidades;
                    inventario.agregarSalida(idInsumo, cantidadEnUMInsumo, DateTime.Now, 0);

                }
                else
                {
                    Console.WriteLine("\n\n\n\n\n\n" + conversionUMReceta + " " + conversionUMInsumo + " " + idInsumo + " " + cantidadEnUMReceta + " " + idUMReceta + " " + idUMInsumo);
                }
                    
            }
        }
    }
}
