﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colchoneria.Servicios
{
    internal interface MenuInterfaz
    {
        public int mostrarMenuYSeleccion();

        public void mensajeBienvenida();

        public long pedirId();

    }
}
