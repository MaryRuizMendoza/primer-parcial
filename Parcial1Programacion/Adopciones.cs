using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1Programacion
{
    public class Adopciones:Perro
    {
        public readonly string color = "Cafe";
        public readonly int altura = 80;
        public Adopciones(string nom, string ra, int anos)
            :base(nom,ra,anos)
        {
        }

        public Adopciones()
        { }

        public new void SerAdoptado()
        {
            Console.WriteLine("La mascota "+nombre+" de tipo "+raza+" puede ser adoptada. \n Su altura es  de "+altura+" cm y su color es  "+color);
            Console.ReadLine();
        }

    }
}
