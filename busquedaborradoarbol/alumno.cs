using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace busquedaborradoarbol
{
    internal class alumno
    {
        public int matricula;
        public string nombre;
        public decimal calif;
        public alumno izq, der;
        public alumno()
        {
            izq = null;
            der = null;
        }
    }
}
