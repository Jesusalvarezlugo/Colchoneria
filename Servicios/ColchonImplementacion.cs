using Colchoneria.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colchoneria.Servicios
{
    internal class ColchonImplementacion : ColchonInterfaz
    {
        public void añadirColchon(List<ColchonDto> listaAntigua)
        {
            ColchonDto colchonN = colchonNuevo();

            listaAntigua.Add(colchonN);
        }

        private ColchonDto colchonNuevo()
        {
            ColchonDto colchon= new ColchonDto();

            Console.WriteLine("Introduzca el id del colchon: ");
            colchon.IdColchon = Int64.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca la marca del colchon: ");
            colchon.MarcaColchon = Console.ReadLine();
            Console.WriteLine("Introduzca el tipo del colchon: ");
            colchon.TipoColchon = Console.ReadLine();
            Console.WriteLine("Introduzca el ancho del colchon: ");
            colchon.AnchoColchon=Double.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el largo del colchon: ");
            colchon.LargoColchon=Double.Parse(Console.ReadLine());

            return colchon;
        }





        public void eliminarColchon(List<ColchonDto> listaAntigua)
        {
            throw new NotImplementedException();
        }

        public void modificarColchon(List<ColchonDto> listaAntigua)
        {
            throw new NotImplementedException();
        }
    }
}
