using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPregunta3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre, apellido;

            Console.WriteLine("Porfavor ingrese su Nombre...");
            nombre = Console.ReadLine();
            Console.WriteLine("Porfavor ingrese su Apellido...");
            apellido = Console.ReadLine();

            if (nombre.Length <= 2 || apellido.Length <=2) 
            {
                throw new Exception("Nombre/Apellido no válido");
            }
        }
    }
}
