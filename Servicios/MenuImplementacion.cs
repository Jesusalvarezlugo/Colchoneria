
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colchoneria.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public void mensajeBienvenida()
        {
           
            string mensaje = "Bienvenido/a a Colchoneria y muebles Bernal";
            Console.WriteLine(mensaje);


        }

        public int mostrarMenuYSeleccion()
        {
            int opcion;

            Console.WriteLine("###################");
            Console.WriteLine("0. Salir");
            Console.WriteLine("1. Añadir Colchon");
            Console.WriteLine("2. Modificar Colchon");
            Console.WriteLine("3. Eliminar Colchon");
            Console.WriteLine("4. Ver Colchones");
            Console.WriteLine("###################");
            Console.WriteLine("Introduzca una opcion: ");
            opcion = Console.ReadKey(true).KeyChar - ('0');

            return opcion;
        }
    }
}
