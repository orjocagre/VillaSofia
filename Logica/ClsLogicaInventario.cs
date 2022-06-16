﻿using System;
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
        public DataTable mostrarInventarioActual()
        {
            ClsDatosInventario inventario = new ClsDatosInventario();
            return inventario.consulta("SELECT insumo.id_insumo AS ID, insumo.nombre AS NOMBRE, insumo.existencia AS CANTIDAD, um.descripcion AS UM  FROM insumo, um WHERE insumo.id_UM = um.id_UM");

        }
    }
}
