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

        public int agregarEntrada(int Pid_insumo, double Pcantidad, DateTime Pfecha, double Pprecio, int idUmCompra, double presentacion)
        {
            ClsDatosInventario inventario = new ClsDatosInventario();
            
            String sql = "SELECT insumo.id_UM AS UM FROM insumo WHERE insumo.id_insumo = "+Pid_insumo;
            int idUmInsumo = Convert.ToInt32(inventario.consulta(sql).Rows[0][0]);
            sql = "SELECT um.id_UM AS ID, um.conversion AS conversion FROM um";
            DataTable um = inventario.consulta(sql);

            double conversionUMCompra = -1;
            double conversionUMInsumo = -1;


            for (int i = 0; i < um.Rows.Count; i++)
            {
                if (conversionUMCompra == -1 || conversionUMInsumo == -1)
                {
                    if (idUmCompra == Convert.ToInt32(um.Rows[i][0]))
                    {
                        conversionUMCompra = Convert.ToDouble(um.Rows[i][1]);
                    }
                    if (idUmInsumo == Convert.ToInt32(um.Rows[i][0]))
                    {
                        conversionUMInsumo = Convert.ToDouble(um.Rows[i][1]);
                    }
                }
                else
                {
                    i = um.Rows.Count;
                }
            }
            if (conversionUMCompra != -1 && conversionUMInsumo != -1)
            {
                double cantidadEnUMInsumo = (Pcantidad * presentacion * conversionUMCompra) / conversionUMInsumo;

                int msj = inventario.agregarEntrada(Pid_insumo, cantidadEnUMInsumo, Pfecha, Pprecio);
                return msj;
            }
            else
            {
                return -1;
            }

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

        public DataTable generarKardex(int idInsumo, DateTime fechaInicial, DateTime fechaFinal)
        {
            Console.WriteLine("\n\n Entrada al metodo kardex");
            ClsDatosInventario inventario = new ClsDatosInventario();
            String sql = "SELECT fecha AS FECHA, cantidad AS CANTIDAD, precio AS PRECIO FROM entrada_inventario WHERE id_insumo = "+idInsumo+" AND fecha > '"+fechaInicial.ToString("yyy-MM-dd HH:mm:ss")+"' AND fecha < '"+fechaFinal.ToString("yyy-MM-dd HH:mm:ss") + "' ORDER BY fecha ASC";
            DataTable dtEntradas = inventario.consulta(sql);
            Console.WriteLine("dt entradas lineas: "+dtEntradas.Rows.Count);
            sql = "SELECT fecha AS FECHA, cantidad AS CANTIDAD, precio AS PRECIO FROM salida_inventario WHERE id_insumo = " + idInsumo + " AND fecha > '" + fechaInicial.ToString("yyy-MM-dd HH:mm:ss") + "' AND fecha < '" + fechaFinal.ToString("yyy-MM-dd HH:mm:ss") + "' ORDER BY fecha ASC";
            DataTable dtSalidas = inventario.consulta(sql);
            Console.WriteLine("dt salidas lineas: " + dtSalidas.Rows.Count);

            DataTable kardex = new DataTable();
            kardex.Columns.Add("FECHA", typeof(String));
            kardex.Columns.Add("CANTIDAD ENTRADAS", typeof(double));
            kardex.Columns.Add("COSTO ENTRADAS", typeof(String));
            kardex.Columns.Add("CANTIDAD SALIDAS", typeof(double));
            kardex.Columns.Add("COSTO SALIDAS", typeof(String));


            int filaEntrada = 0;
            int filaSalida = 0;

            while (filaEntrada < dtEntradas.Rows.Count || filaSalida < dtSalidas.Rows.Count)
            {
                Console.WriteLine("vuelta while");
                kardex.Rows.Add();
                if(filaSalida == dtSalidas.Rows.Count)
                {
                    kardex.Rows[kardex.Rows.Count - 1][0] = dtEntradas.Rows[filaEntrada][0].ToString();
                    kardex.Rows[kardex.Rows.Count - 1][1] = (Convert.ToDouble(dtEntradas.Rows[filaEntrada][1])).ToString("#,#.#");
                    kardex.Rows[kardex.Rows.Count - 1][2] = (Convert.ToDouble(dtEntradas.Rows[filaEntrada][2])).ToString("C$ #,#.00");
                    filaEntrada++;
                }
                else if(filaEntrada == dtEntradas.Rows.Count)
                {
                    kardex.Rows[kardex.Rows.Count - 1][0] = dtSalidas.Rows[filaSalida][0].ToString();
                    kardex.Rows[kardex.Rows.Count - 1][3] = (Convert.ToDouble(dtSalidas.Rows[filaSalida][1])).ToString("#,#.#");
                    kardex.Rows[kardex.Rows.Count - 1][4] = (Convert.ToDouble(dtSalidas.Rows[filaSalida][2])).ToString("C$ #,#.00");
                    filaSalida++;
                }
                else
                {
                    if (Convert.ToDateTime(dtEntradas.Rows[filaEntrada][0]) < Convert.ToDateTime(dtSalidas.Rows[filaSalida][0]))
                    {
                        kardex.Rows[kardex.Rows.Count - 1][0] = dtEntradas.Rows[filaEntrada][0].ToString();
                        kardex.Rows[kardex.Rows.Count - 1][1] = (Convert.ToDouble(dtEntradas.Rows[filaEntrada][1])).ToString("#,#.#");
                        kardex.Rows[kardex.Rows.Count - 1][2] = (Convert.ToDouble(dtEntradas.Rows[filaEntrada][2])).ToString("C$ #,#.00");
                        filaEntrada++;
                    }
                    else
                    {
                        kardex.Rows[kardex.Rows.Count - 1][0] = dtSalidas.Rows[0][0].ToString();
                        kardex.Rows[kardex.Rows.Count - 1][3] = (Convert.ToDouble(dtSalidas.Rows[filaSalida][1])).ToString("#,#.#");
                        kardex.Rows[kardex.Rows.Count - 1][4] = (Convert.ToDouble(dtSalidas.Rows[filaSalida][2])).ToString("C$ #,#.00");
                        filaSalida++;
                    }
                }
                
                Console.WriteLine("bucle while " + kardex.Rows.Count);
            }

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n");
            for(int i=0; i<kardex.Rows.Count; i++)
            {
                for(int j=0; j<kardex.Columns.Count; j++)
                {
                    Console.WriteLine(kardex.Rows[i][j].ToString());
                }
            }
            return kardex;
        }


        public DataTable listarMinimos(String nombre)
        {
            ClsDatosInventario inventario = new ClsDatosInventario();
            String sql = "SELECT insumo.id_insumo AS ID, insumo.nombre AS NOMBRE, insumo.minimo AS MINIMO, um.descripcion AS UM, insumo.envase AS ENVASE, insumo.presentacion AS PRESENTACION FROM insumo, um WHERE insumo.id_UM = um.id_UM AND insumo.nombre LIKE '%"+nombre+"%'";
            DataTable DT = inventario.consulta(sql);

            DataTable minimos = new DataTable();
            minimos.Columns.Add("ID", typeof(int));
            minimos.Columns.Add("NOMBRE", typeof(String));
            minimos.Columns.Add("MINIMO", typeof(double));
            minimos.Columns.Add("PRESENTACION", typeof(String));


            for(int i=0; i<DT.Rows.Count; i++)
            {
                minimos.Rows.Add();
                minimos.Rows[i][0] = DT.Rows[i][0];
                minimos.Rows[i][1] = DT.Rows[i][1];

                minimos.Rows[i][2] = Convert.ToDouble(DT.Rows[i][2]) / Convert.ToDouble(DT.Rows[i][5]);

                minimos.Rows[i][3] = DT.Rows[i][4].ToString() + " de " + (Convert.ToDouble(DT.Rows[i][5])).ToString("#,#.#") +" "+ DT.Rows[i][3].ToString() + "(s)";

            }
            return minimos;

        }

        public int editarMinimoInsumo(int PidInsumo, double Pminimo)
        {
            ClsDatosInventario inventario = new ClsDatosInventario();
            int msj = inventario.editarMinimoInsumo(PidInsumo, Pminimo);
            return msj;
        }

        public DataTable generarListaComprasPresentacionTodos()
        {
            ClsDatosInventario inventario = new ClsDatosInventario();
            String sql;

            sql = "SELECT insumo.id_insumo AS ID, insumo.nombre AS NOMBRE, insumo.envase AS ENVASE, insumo.existencia / insumo.presentacion AS EXISTENCIA, insumo.minimo / insumo.presentacion AS MINIMO, (insumo.minimo / insumo.presentacion) - (insumo.existencia / insumo.presentacion) AS COMPRAS, insumo.precio AS PRECIO, insumo.presentacion AS PRESENTACION FROM insumo ORDER BY insumo.id_insumo ASC";


            DataTable DT = inventario.consulta(sql);
            for(int i=0; i<DT.Rows.Count; i++)
            {
                DT.Rows[i][5] = Math.Ceiling((double)DT.Rows[i][5]);
                DT.Rows[i][6] = (double)DT.Rows[i][6] * (double)DT.Rows[i][5];
            }
            return DT;
        }

        public DataTable generarListaComprasUMTodos()
        {
            ClsDatosInventario inventario = new ClsDatosInventario();
            String sql;
            sql = "SELECT insumo.id_insumo AS ID, insumo.nombre AS NOMBRE, um.descripcion AS UM, insumo.existencia AS EXISTENCIA, insumo.minimo AS MINIMO, (insumo.minimo / insumo.presentacion) - (insumo.existencia / insumo.presentacion) AS COMPRAS, insumo.precio AS PRECIO, insumo.presentacion AS presentacion FROM insumo, um WHERE insumo.id_UM = um.id_UM ORDER BY insumo.id_insumo ASC";


            DataTable DT = inventario.consulta(sql);
            for (int i = 0; i < DT.Rows.Count; i++)
            {
                double comprasPresentacion = Math.Ceiling((double)DT.Rows[i][5]);
                DT.Rows[i][5] = comprasPresentacion * (double)DT.Rows[i][7];
                DT.Rows[i][6] = (double)DT.Rows[i][6] * comprasPresentacion;
            }
            return DT;
        }

        public DataTable generarListaComprasPresentacion()
        {
            ClsDatosInventario inventario = new ClsDatosInventario();
            String sql;
            sql = "SELECT insumo.id_insumo AS ID, insumo.nombre AS NOMBRE, insumo.envase AS ENVASE, insumo.existencia / insumo.presentacion AS EXISTENCIA, insumo.minimo / insumo.presentacion AS MINIMO, (insumo.minimo / insumo.presentacion) - (insumo.existencia / insumo.presentacion) AS COMPRAS, insumo.precio AS PRECIO, insumo.presentacion AS PRESENTACION FROM insumo WHERE (insumo.minimo / insumo.presentacion) - (insumo.existencia / insumo.presentacion) > 0 ORDER BY insumo.id_insumo ASC";


            DataTable DT = inventario.consulta(sql);
            for (int i = 0; i < DT.Rows.Count; i++)
            {
                DT.Rows[i][5] = Math.Ceiling((double)DT.Rows[i][5]);
                DT.Rows[i][6] = (double)DT.Rows[i][6] * (double)DT.Rows[i][5];
            }
            return DT;
        }

        public DataTable generarListaComprasUM()
        {
            ClsDatosInventario inventario = new ClsDatosInventario();
            String sql;
            sql = "SELECT insumo.id_insumo AS ID, insumo.nombre AS NOMBRE, um.descripcion AS UM, insumo.existencia AS EXISTENCIA, insumo.minimo AS MINIMO, (insumo.minimo / insumo.presentacion) - (insumo.existencia / insumo.presentacion) AS COMPRAS, insumo.precio AS PRECIO, insumo.presentacion AS presentacion FROM insumo, um WHERE insumo.id_UM = um.id_UM AND ((insumo.minimo / insumo.presentacion) - (insumo.existencia / insumo.presentacion) > 0)  ORDER BY insumo.id_insumo ASC";


            DataTable DT = inventario.consulta(sql);
            for (int i = 0; i < DT.Rows.Count; i++)
            {
                double comprasPresentacion = Math.Ceiling((double)DT.Rows[i][5]);
                DT.Rows[i][5] = comprasPresentacion * (double)DT.Rows[i][7];
                DT.Rows[i][6] = (double)DT.Rows[i][6] * comprasPresentacion;
            }
            return DT;
        }
        public int agregarListaCompras()
        {
            ClsDatosInventario inventario = new ClsDatosInventario();
            return inventario.agregarListaCompras();
        }

        public int agregarInsumoListaCompras(int Pid_insumo, int Pid_listaCompras, String Penvase, double Pexistencia, double Ppresentacion, double Pprecio, double Pminimo, double Pcompras)
        {
            ClsDatosInventario inventario = new ClsDatosInventario();
            int msj = inventario.agregarInsumoListaCompras(Pid_insumo, Pid_listaCompras, Penvase, Pexistencia, Ppresentacion, Pprecio, Pminimo, Pcompras);
            return msj;

        }

        public DataTable generarListaComprasPresentacionTodos(int idListaCompras)
        {
            ClsDatosInventario inventario = new ClsDatosInventario();
            String sql;

            sql = "SELECT insumo.id_insumo AS ID, insumo.nombre AS NOMBRE, listacompras_insumo.envase AS ENVASE, listacompras_insumo.existencia / listacompras_insumo.presentacion AS EXISTENCIA, listacompras_insumo.minimo / listacompras_insumo.presentacion AS MINIMO, listacompras_insumo.compras AS COMPRAS, listacompras_insumo.precio AS PRECIO, listacompras_insumo.presentacion AS PRESENTACION FROM insumo, listacompras_insumo WHERE listacompras_insumo.id_insumo = insumo.id_insumo AND listacompras_insumo.id_listaCompras = "+idListaCompras+" ORDER BY insumo.id_insumo ASC";


            DataTable DT = inventario.consulta(sql);
            
            return DT;
        }

        public DataTable generarListaComprasUMTodos(int idListaCompras)
        {
            ClsDatosInventario inventario = new ClsDatosInventario();
            String sql;
            sql = "SELECT insumo.id_insumo AS ID, insumo.nombre AS NOMBRE, um.descripcion AS UM, listacompras_insumo.existencia AS EXISTENCIA, listacompras_insumo.minimo AS MINIMO, (listacompras_insumo.compras * listacompras_insumo.presentacion) AS COMPRAS, listacompras_insumo.precio AS PRECIO, listacompras_insumo.presentacion AS presentacion FROM insumo, um, listacompras_insumo WHERE listacompras_insumo.id_insumo = insumo.id_insumo AND listacompras_insumo.id_UM = um.id_UM AND listacompras_insumo.id_listaCompras = " + idListaCompras + " ORDER BY insumo.id_insumo ASC";


            DataTable DT = inventario.consulta(sql);
            
            return DT;
        }

        public DataTable generarListaComprasPresentacion(int idListaCompras)
        {
            ClsDatosInventario inventario = new ClsDatosInventario();
            String sql;
            sql = "SELECT insumo.id_insumo AS ID, insumo.nombre AS NOMBRE, listacompras_insumo.envase AS ENVASE, listacompras_insumo.existencia / listacompras_insumo.presentacion AS EXISTENCIA, listacompras_insumo.minimo / listacompras_insumo.presentacion AS MINIMO, listacompras_insumo.compras AS COMPRAS, listacompras_insumo.precio AS PRECIO, listacompras_insumo.presentacion AS PRESENTACION FROM insumo, listacompras_insumo WHERE listacompras_insumo.id_insumo = insumo.id_insumo AND listacompras_insumo.id_listaCompras = " + idListaCompras + " AND listacompras_insumo.compras > 0 ORDER BY insumo.id_insumo ASC";


            DataTable DT = inventario.consulta(sql);
            
            return DT;
        }

        public DataTable generarListaComprasUM(int idListaCompras)
        {
            ClsDatosInventario inventario = new ClsDatosInventario();
            String sql;

            sql = "SELECT insumo.id_insumo AS ID, insumo.nombre AS NOMBRE, um.descripcion AS UM, listacompras_insumo.existencia AS EXISTENCIA, listacompras_insumo.minimo AS MINIMO, (listacompras_insumo.compras * listacompras_insumo.presentacion) AS COMPRAS, listacompras_insumo.precio AS PRECIO, listacompras_insumo.presentacion AS presentacion FROM insumo, um, listacompras_insumo WHERE listacompras_insumo.id_insumo = insumo.id_insumo AND listacompras_insumo.id_UM = um.id_UM AND listacompras_insumo.compras > 0 AND listacompras_insumo.id_listaCompras = " + idListaCompras + " ORDER BY insumo.id_insumo ASC";


            DataTable DT = inventario.consulta(sql);
            
            return DT;
        }

        public DataTable listarListasCompras(DateTime fecha)
        {
            ClsDatosInventario inventario = new ClsDatosInventario();
            String sql = "	SELECT id_listaCompras AS ID, fecha AS FECHA FROM listacompras WHERE fecha LIKE '%"+fecha.ToString("yyy-MM-dd")+ "%' ORDER BY fecha DESC";
            return inventario.consulta(sql);
        }

        public DataTable listarListasCompras()
        {
            ClsDatosInventario inventario = new ClsDatosInventario();
            String sql = "	SELECT id_listaCompras AS ID, fecha AS FECHA FROM listacompras";
            return inventario.consulta(sql);
        }


    }
}
