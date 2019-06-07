using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1Programacion
{
    class Dueño:Perro
    {
        public string nombreDueño = "Mary Ruiz";
        public int edadDueño = 20;
        public string direccion = "calle # colonia, ciudad, estado, pais C.P.00000";
        
        public Dueño(string nom, string ra, int anos)
           : base(nom, ra, anos)
        {
        }

        public Dueño()
        { }

        public void Adoptar()
        {
            Console.WriteLine(nombreDueño+" ha adoptado a la mascota "+nombre+" de raza "+raza+" de "+edad+" años. \n La direccion del nuevo dueño es: "+direccion);
            Console.ReadLine();
        }
    }
}
