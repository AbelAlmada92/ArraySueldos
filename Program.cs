using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace arraySueldos
{
    class program
    {
        private string[] nombre;
        private float[] sueldo;

        public void Cargar()
        {
            nombre = new string[5];
            sueldo = new float[5];
            for(int i=0; i<nombre.Length; i++)
            {
                Console.WriteLine("Ingrese su nombre: ");
                nombre[i] = Console.ReadLine();
                Console.WriteLine("Ingrese su sueldo: ");
                string linea;
                linea = Console.ReadLine();
                sueldo[i] = float.Parse(linea);
            }
        }

        public void MayorSueldo()
        {
            float mayor;
            int pos;
            mayor = sueldo[0];
            pos = 0;
            for(int i=0; i<nombre.Length; i++)
            {
                if(sueldo[i] > mayor)
                {
                    mayor = sueldo[i];
                    pos = i;
                }         
            }
            Console.WriteLine("El empleado con mayor sueldo es: " +nombre[pos]);
            Console.WriteLine("El sueldo es: "+mayor);
            Console.ReadKey();
        }
        static void Main(string[]args)
        {
            program ps = new program();
            ps.Cargar();
            ps.MayorSueldo();
        }
    }
}