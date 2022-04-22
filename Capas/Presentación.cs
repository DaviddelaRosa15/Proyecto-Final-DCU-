using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capas
{
    public static class Presentación
    {
        public static string formatoTelefono(string numero)
        {
            double numeroDocumento = Double.Parse(numero);
            string formato = "";
            if (numeroDocumento.ToString().Length == 10)
            {
                formato = numeroDocumento.ToString("(000)-000-0000");
            }

            return formato;
        }

        public static string sinFormatoTelefono(string numeroConFormato)
        {
            string sinFormato;
            string sinFormato2;
            string sinFormato3;
            sinFormato = numeroConFormato.ToString().Replace("-", "");
            sinFormato2 = sinFormato.ToString().Replace("(", "");
            sinFormato3 = sinFormato2.ToString().Replace(")", "");
            
            return sinFormato3;
        }

        public static string formatoMatricula(string matricula)
        {
            double numeroDocumento = Double.Parse(matricula);
            string formato = "";
            if (numeroDocumento.ToString().Length == 9)
            {
                formato = numeroDocumento.ToString("0000-00000");
            }
            if (numeroDocumento.ToString().Length == 8)
            {
                formato = numeroDocumento.ToString("0000-0000");
            }

            return formato;
        }

        public static string sinFormatoMatricula(string matConFormato)
        {
            string sinFormato;
            sinFormato = matConFormato.ToString().Replace("-", "");

            return sinFormato;
        }
    }
}
