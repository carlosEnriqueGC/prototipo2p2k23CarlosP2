using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using System.Security.Cryptography;
using System.Net;
using System.Net.Sockets;

namespace CapaModelo
{
    public class Sentencias
    {
        Conexion con = new Conexion();


       



       

        


     

        public List<string> ObtenerDatosM(string columna1,string columna2, string columna3, string columna4, string columna5, string columna6, string tabla)
        {
            List<string> datos = new List<string>();
            try
            {

                string consulta = $"SELECT {columna1},{columna2},{columna3},{columna4},{columna5},{columna6} FROM {tabla}";

                OdbcCommand command = new OdbcCommand(consulta, con.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string carnet = reader[columna1].ToString();
                    string nombre = reader[columna2].ToString();
                    string direccion = reader[columna3].ToString();
                    string telefono = reader[columna4].ToString();
                    string email = reader[columna5].ToString();
                    string estatus = reader[columna6].ToString();

                    string cadena = carnet + " - " +nombre + " - "+ direccion+" - "+telefono+" - "+email+" - "+estatus;
                    
                    datos.Add(cadena);
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return datos;
        }

      
    }
}
