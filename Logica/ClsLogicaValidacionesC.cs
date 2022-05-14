using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ClsLogicaValidacionesC
    {
        public Boolean ValidarPrefijosCedula(String cedula)
        {

            try
            {
                int prefijo;
                prefijo = Convert.ToInt32(cedula.Substring(0, 3));

                if (prefijo == 607 || prefijo == 608 || prefijo == 610 || prefijo == 611 || prefijo == 612 || prefijo == 615 || prefijo == 454 || prefijo == 602 || prefijo == 601 || prefijo == 603 || prefijo == 604 || prefijo == 605 || prefijo == 606 || prefijo == 616 || prefijo == 619 || prefijo == 624 || prefijo == 626 || prefijo == 627 || prefijo == 628 || prefijo == 361 || prefijo == 362 || prefijo == 363 || prefijo == 364 || prefijo == 365 || prefijo == 366 || prefijo == 041 || prefijo == 042 || prefijo == 043 || prefijo == 044 || prefijo == 045 || prefijo == 046 || prefijo == 047 || prefijo == 048 || prefijo == 081 || prefijo == 082 || prefijo == 083 || prefijo == 084 || prefijo == 085 || prefijo == 086 || prefijo == 087 || prefijo == 088 || prefijo == 089 || prefijo == 090 || prefijo == 091 || prefijo == 092 || prefijo == 093 || prefijo == 121 || prefijo == 122 || prefijo == 123 || prefijo == 124 || prefijo == 125 || prefijo == 126 || prefijo == 127 || prefijo == 128 || prefijo == 129 || prefijo == 130 || prefijo == 161 || prefijo == 162 || prefijo == 163 || prefijo == 164 || prefijo == 165 || prefijo == 166 || prefijo == 201 || prefijo == 202 || prefijo == 203 || prefijo == 204 || prefijo == 241 || prefijo == 242 || prefijo == 243 || prefijo == 244 || prefijo == 245 || prefijo == 246 || prefijo == 247 || prefijo == 281 || prefijo == 283 || prefijo == 284 || prefijo == 285 || prefijo == 286 || prefijo == 287 || prefijo == 288 || prefijo == 289 || prefijo == 290 || prefijo == 291 || prefijo == 321 || prefijo == 322 || prefijo == 323 || prefijo == 324 || prefijo == 325 || prefijo == 326 || prefijo == 327 || prefijo == 328 || prefijo == 329 || prefijo == 001 || prefijo == 002 || prefijo == 003 || prefijo == 004 || prefijo == 005 || prefijo == 006 || prefijo == 007 || prefijo == 008 || prefijo == 009 || prefijo == 401 || prefijo == 402 || prefijo == 403 || prefijo == 404 || prefijo == 405 || prefijo == 406 || prefijo == 407 || prefijo == 408 || prefijo == 409 || prefijo == 441 || prefijo == 442 || prefijo == 443 || prefijo == 444 || prefijo == 445 || prefijo == 446 || prefijo == 447 || prefijo == 448 || prefijo == 449 || prefijo == 450 || prefijo == 451 || prefijo == 452 || prefijo == 453 || prefijo == 481 || prefijo == 482 || prefijo == 483 || prefijo == 484 || prefijo == 485 || prefijo == 486 || prefijo == 487 || prefijo == 488 || prefijo == 489 || prefijo == 490 || prefijo == 491 || prefijo == 492 || prefijo == 493 || prefijo == 521 || prefijo == 522 || prefijo == 523 || prefijo == 525 || prefijo == 526 || prefijo == 561 || prefijo == 562 || prefijo == 563 || prefijo == 564 || prefijo == 565 || prefijo == 566 || prefijo == 567 || prefijo == 568 || prefijo == 569 || prefijo == 570)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                return false;
            }

        }

        public Boolean ValidarFechaCedula(String cedula, String fecha_nacimiento)
        {
            try
            {

                Boolean fecha_valida;
                int dias, dianacimiento, meses, mesnacimiento, ano, anonacimienocorto, anonacimientolargo, anoactual;
                dias = Convert.ToInt32(cedula.Substring(3, 2));

                dianacimiento = Convert.ToInt32(fecha_nacimiento.Substring(8, 2));

                meses = Convert.ToInt32(cedula.Substring(5, 2));

                mesnacimiento = Convert.ToInt32(fecha_nacimiento.Substring(5, 2));

                ano = Convert.ToInt32(cedula.Substring(7, 2));

                anonacimienocorto = Convert.ToInt32(fecha_nacimiento.Substring(2, 2));

                anonacimientolargo = Convert.ToInt32(fecha_nacimiento.Substring(0, 4));

                anoactual = Convert.ToInt32(DateTime.Now.ToString("yyyy"));




                if (meses == 1 || meses == 3 || meses == 5 || meses == 7 || meses == 8 || meses == 10 || meses == 12)
                {
                    if (dias > 0 && dias <= 31)
                    {
                        fecha_valida = true;
                    }
                    else
                    {
                        fecha_valida = false;
                    }
                }
                else if (meses == 4 || meses == 6 || meses == 9 || meses == 11)
                {
                    if (dias > 0 && dias <= 30)
                    {
                        fecha_valida = true;
                    }
                    else
                    {
                        fecha_valida = false;
                    }
                }
                else if (meses == 2)
                {
                    if (dias > 0 && dias <= 28)
                    {
                        fecha_valida = true;
                    }
                    else
                    {
                        fecha_valida = false;
                    }
                }
                else
                {
                    fecha_valida = false;
                }

                if (fecha_valida == true)
                {

                    if ((anoactual - anonacimientolargo) >= 16)
                    {
                        if (ano == anonacimienocorto && meses == mesnacimiento && dias == dianacimiento)
                        {
                            return true;
                        }
                        else
                        {

                            return false;
                        }
                    }
                    else
                    {

                        return false;
                    }


                }
                else
                {

                    return false;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }


        public Boolean ValidarLetraCeduda(String cedula)
        {
            try
            {
                String Numerocedula, NewNumerocedula, Letra, Letras;
                int Valor;
                long cedulalong, cedulalong2;
                long ceduladoble;
                Numerocedula = cedula.Substring(0, 13);
                Letras = "ABCDEFGHJKLMNPQRSTUVWXY";
                Console.WriteLine(Numerocedula);

                cedulalong = Int64.Parse(Numerocedula);
                Console.WriteLine(cedulalong);
                ceduladoble = (Convert.ToInt64((cedulalong / 23))) * 23;
                Console.WriteLine(ceduladoble);
                cedulalong2 = Convert.ToInt64(ceduladoble);
                Console.WriteLine(cedulalong2);
                Valor = Convert.ToInt32((cedulalong - cedulalong2));
                Console.WriteLine(Valor);

                Letra = Letras.Substring(Valor, 1);
                Console.WriteLine(Letra);

                NewNumerocedula = Numerocedula + Letra;

                if (NewNumerocedula != cedula)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }

    }
}
