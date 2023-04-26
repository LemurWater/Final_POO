using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using FinalPOO.Forms;
using FinalPOO.Clases;
using System.Drawing; 

namespace FinalPOO
{
    static class Program
    {
        public static List<Empleado> l_empleados = new List<Empleado>();
        public static Empleado empleado = new Empleado();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                Application.Run(new F01Loging());

                LeerArchivo(); 
                
                CrearListaEmpleados();

                
            }
            catch
            {

            }
            void LeerArchivo()
            {
                StreamIO.LeerArchivo();
            }
            void CrearListaEmpleados()
            {
                Empleado empleado = new Empleado();
                l_empleados.Add(empleado);
            }
            void Cerrar()
            {
                StreamIO.EscribirArchivo();
            }
        }
    }
}
