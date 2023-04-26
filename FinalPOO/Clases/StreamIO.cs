using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace FinalPOO.Clases
{
    static class StreamIO
    {
        public static string direccion = Environment.CurrentDirectory + "@/Lista Empleados.txt";
        public static void LeerArchivo()
        {
            try
            {
                string[] lineas = File.ReadAllLines(direccion);
                foreach (string linea in lineas)
                {
                    string[] v = linea.Split(',');
                    Bitmap imagen = new Bitmap("a");
                    Empleado empleado = new Empleado(v[0], v[1], uint.Parse(v[2]), Convert.ToChar(v[3]), DateTime.Parse(v[4]), imagen,
                        DateTime.Parse(v[5]), float.Parse(v[6]), byte.Parse(v[7]), uint.Parse(v[8]), DateTime.Parse(v[9]));

                    Program.l_empleados.Add(empleado);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("StreamIO - LeerArchivo() - EX: " + ex.Message);
            }
        }
        public static void EscribirArchivo()
        {
            try
            {
                if (File.Exists(direccion))
                {
                    File.Delete(direccion);
                }
                using (StreamWriter sw = File.CreateText(direccion))
                {
                    foreach (Empleado e in Program.l_empleados)
                    {
                        sw.WriteLine(e.Nombre + "," + e.Apellidos + "," + e.Id + "," + e.Genero + "," + e.FechaNacimiento + ","
                            + e.FechaIngreso + "," + e.Salario + "," + e.Edad + "," + e.Antiguedad + "," + e.FechaJuvilacion);
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("StreamIO - EscribirArchivo() - EX: " + ex.Message);
            }
        }
    }

}
