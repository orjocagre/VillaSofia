﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Datos;


namespace Logica
{
    public class ClsLogicaUsuario
    {
        public string ctrlRegistro(ClsModeloUsuario usuario)
        {

            ClsDatosUsuario datosUsuario = new ClsDatosUsuario();
            String respuesta = "";

            if (string.IsNullOrEmpty(usuario.Usuario1) || string.IsNullOrEmpty(usuario.Password) || string.IsNullOrEmpty(usuario.ConPassword)
                || string.IsNullOrEmpty(usuario.Nombre))
            {

                respuesta = "Debe llenar todos los campos";


            }
            else
            {
                if (usuario.Password == usuario.ConPassword)
                {

                    if (datosUsuario.existeUsuario(usuario.Usuario1))
                    {

                        respuesta = "El usuario ya existe";

                    }
                    else
                    {

                        usuario.Password = generarSHA1(usuario.Password);
                        datosUsuario.registro(usuario);

                    }

                }
                else
                {
                    respuesta = "Las contraseñas no coinciden";
                }
            }

            return respuesta;

        }

        public string crtlLogin(string usuario, string password)
        {
            ClsDatosUsuario datosUsuario = new ClsDatosUsuario();
            string respuesta = "";
            ClsModeloUsuario modeloUsuario;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password))
            {
                respuesta = "Debe llenar todos los campos";

            }
            else
            {
                modeloUsuario = datosUsuario.validacion(usuario);
                if (modeloUsuario == null)
                {
                    respuesta = "El usuario no existe";
                }
                else
                {
                    Console.WriteLine("\n\n\n\n\n\n\n\n\n"+modeloUsuario.Password + " " + generarSHA1(password));
                    if (modeloUsuario.Password != generarSHA1(password))
                    {
                        respuesta = "El usuario y/o contraseña no existen";
                    }
                    else
                    {

                        ClsSession.id = modeloUsuario.Id;
                        ClsSession.id_tipo = modeloUsuario.Id_tpo;
                        ClsSession.nombre = modeloUsuario.Nombre;
                        ClsSession.usuario = modeloUsuario.Usuario1;
                        //  Añadir un label para poner el nombre del usuario activo

                    }
                }
            }
            return respuesta;
        }

        private string generarSHA1(string cadena)
        {

            UTF8Encoding enc = new UTF8Encoding();
            byte[] data = enc.GetBytes(cadena);
            byte[] result;

            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();

            result = sha.ComputeHash(data);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {

                if (result[i] < 16)
                {
                    sb.Append("0");
                }

                sb.Append(result[i].ToString("x"));
            }
            return sb.ToString();

        }
    }
}
