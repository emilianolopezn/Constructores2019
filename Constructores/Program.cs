using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    class Program
    {
        static void Main(string[] args)
        {
            Contacto contacto1 = new Contacto();
            contacto1.Nombre = "José";
            contacto1.Celular = "(644) 4 00 00 00";
            contacto1.Correo = "jose@correo.com";

            Console.WriteLine(
                "Nombre: " + contacto1.Nombre);
            Console.WriteLine(
                "Correo: " + contacto1.Correo);
            Console.WriteLine(
                "Dirección: " + contacto1.Direccion);

            Contacto contacto2 =
                new Contacto("Juan", "juan@correo.com");
            Console.WriteLine("*Contacto 2:");
            Console.WriteLine(
                "Nombre: " + contacto2.Nombre);
            Console.WriteLine(
                "Correo: " + contacto2.Correo);
            Console.WriteLine("Dirección: " +
                contacto2.Direccion);


            Console.Read();
        }
    }
}
