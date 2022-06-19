using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Logica
{
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
    }
}
