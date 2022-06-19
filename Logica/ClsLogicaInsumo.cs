using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;
namespace Logica
{
    public class ClsLogicaInsumo
    {


        public String AgregarInsumo(string Pnombre, int Pid_UM, double Ppresentacion, double Pprecio, double Pexistencia, String Penvase)
        {
            String mensaje;
            int msj;
            ClsDatosInsumo Insumo = new ClsDatosInsumo();
            msj = Insumo.AgregarInsumo(Pnombre, Pid_UM, Ppresentacion, Pprecio, Pexistencia, Penvase);
           
            if (msj == -3)
            {
                mensaje = "Error al guardar";

            }
            else if (msj == -1)
            {
                mensaje = "Um invalida";
            }
            else if (msj == -2)
            {
                mensaje = "El insumo ya existe";
            }
            else
            {
                mensaje = msj.ToString();
            }

            return mensaje;

        }

        public DataTable cmbUm()
        {
            ClsDatosInsumo insumo = new ClsDatosInsumo();
            String sql = "SELECT um.id_UM AS ID, um.descripcion AS DESCRIPCION FROM um";
            return insumo.consulta(sql);
        }


        public DataTable dgvInsumo(String nombre)
        {
            ClsDatosInsumo insumo = new ClsDatosInsumo();
            String sql = "SELECT insumo.id_insumo AS ID, insumo.nombre AS NOMBRE, um.descripcion AS UM, insumo.presentacion AS PRESENTACION, insumo.precio AS PRECIO, insumo.envase AS ENVASE FROM insumo, um WHERE insumo.id_UM = um.id_UM AND insumo.nombre LIKE '%" + nombre+"%'";
            return insumo.consulta(sql);
        }


        /*

        //Listar Insumos 
        public DataTable ListarInsumos(String x)
        {
            String sql = "SELECT * FROM vistatrabajador WHERE vistatrabajador.cedula LIKE '%" + x + "%'";
            Datos.ClsDatosIngrendientes Lista = new Datos.ClsDatosIngrendientes();

            DataTable DT = new DataTable();
            DT = Lista.ListarInsumos(sql);
            return DT;
        }
        */




    }
}
