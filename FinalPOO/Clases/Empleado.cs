using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace FinalPOO.Clases
{
    public class Empleado
    {
        private string nombre;
        private string apellidos;
        private uint id;
        private char genero;
        private DateTime fechaNacimiento;
        private Bitmap imagen;
        private DateTime fechaIngreso;
        private float salario;
        private byte edad;
        private uint antiguedad;
        private DateTime fechaJuvilacion;

        public Empleado()
        {
            this.nombre = "Nombre";
            this.apellidos = "Apellidos";
            this.id = 0000;
            this.genero = 'F';
            this.fechaNacimiento = DateTime.Now;
            //Bitmap bitmap = new Bitmap("A");
            //this.imagen = bitmap;
            this.fechaIngreso = DateTime.Now;
            Salario = 0000000f;
            this.edad = 0;
            this.antiguedad = 0;
            this.fechaJuvilacion = DateTime.Now;
        }
        public Empleado(string nombre, string apellidos, uint id, char genero, DateTime fechaNacimiento, Bitmap imagen, DateTime fechaIngreso, float salario, byte edad, uint antiguedad, DateTime fechaJuvilacion)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.id = id;
            this.genero = genero;
            this.fechaNacimiento = fechaNacimiento;
            this.imagen = imagen;
            this.fechaIngreso = fechaIngreso;
            this.salario = salario;
            this.edad = edad;
            this.antiguedad = antiguedad;
            this.fechaJuvilacion = fechaJuvilacion;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public uint Id { get => id; set => id = value; }
        public char Genero { get => genero; set => genero = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public Bitmap Imagen { get => imagen; set => imagen = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public float Salario { get => salario; set =>salario = value; }
        public byte Edad { get => edad; set => edad = value; }
        public uint Antiguedad { get => antiguedad; set => antiguedad = value; }
        public DateTime FechaJuvilacion { get => fechaJuvilacion; set => fechaJuvilacion = value; }
    }
}
