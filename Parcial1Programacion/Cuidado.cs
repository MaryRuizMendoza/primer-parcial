using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1Programacion
{
    public class Cuidado:Perro
    {
        private string especie = "Canino";
        public Cuidado(string nom, string ra, int anos)
           : base(nom, ra, anos)
        {
        }
        public Cuidado()
        {
        }

        public void Bath()
        {
            Console.WriteLine("La mascota "+nombre+" de tipo "+ especie+" - "+raza+" puede ser bañado.");
            Console.ReadLine();
        }

        public void Esterilizar()
        {
            Console.WriteLine("La mascota "+nombre+" puede ser esterilizada.");
            Console.ReadLine();
        }

        public void Medcar()
        {
            Console.WriteLine("Se han aplicado cuidados de medicacion y vacunas a la mascota "+nombre+" de tipo "+especie+" - "+raza+"\n Edad: "+edad+"\n Peso: "+peso);
            Console.ReadLine();
        }

    }
}
