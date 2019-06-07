using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1Programacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Perro perrrrr = new Perro();
            perrrrr.SerAdoptado();
            perrrrr.Comer();
            perrrrr.Ladrar();
            perrrrr.Higiene();

            Cuidado care = new Cuidado();
            care.Bath();
            care.Medcar();
            care.Esterilizar();

            Adopciones adopt = new Adopciones();
            adopt.SerAdoptado();

            Dueño amo = new Dueño();
            amo.Adoptar();
        }
    }
}
