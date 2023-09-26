using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo;
using System.Data.Odbc;
using System.Data;

namespace CapaControlador
{
    public class Controlador
    {
        Sentencias sn = new Sentencias();

       
     

        
    


       
    

   

        public List<string> ObtenerDatosM(string columna1, string columna2, string columna3, string columna4, string columna5, string columna6, string tabla)
        {
            return sn.ObtenerDatosM(columna1,columna2, columna3, columna4, columna5, columna6, tabla);
        }


      



       
    }
}
