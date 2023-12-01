using Colchoneria.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colchoneria.Servicios
{
    internal interface ColchonInterfaz
    {
        public void añadirColchon(List<ColchonDto> listaAntigua);

        public void modificarColchon(List<ColchonDto> listaAntigua);

        public void eliminarColchon(List<ColchonDto> listaAntigua);
    }
}
