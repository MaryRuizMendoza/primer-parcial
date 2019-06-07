using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1Programacion
{
    public class Perro
    {
        public string nombre = "Max";
        public string raza = "Labrador";
        public int peso = 80;
        public int edad = 5;

        public Perro(string nom, string ra, int anos)
        {
            nom = nombre;
            ra = raza;
            anos = edad;
        }
        public Perro(){
            }
        public string Nombre
        {
            set
            {nombre = value;}
            get
            { return nombre;}
        }

        public string Raza
        {
            set
            { nombre = value;}
            get
            { return nombre; }
        }

        public int Peso
        {
            set
            { peso = value; }
            get
            { return peso; }
        }

        public int Edad
        {
            set
            { edad = value; }
            get
            { return edad; }
        }
        public void Comer()
        {
            Console.WriteLine("El perro  "+ nombre +" come");
            Console.ReadLine();
        }
        public void Ladrar()
        {
            Console.WriteLine("Perro "+ nombre +" ladrando");
            Console.ReadLine();
        }
        public void SerAdoptado()
        {
            Console.Write("Perro "+nombre+" puede ser adoptado.");
            Console.ReadLine();
        }
        public void Higiene()
        {
            Console.WriteLine("Cuidados de higiene");
            Console.ReadLine();
        }

    }
}
