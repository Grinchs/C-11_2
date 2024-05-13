using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_11_2
{
    internal class Program
    {
        public class Pirmais
        {
            public Pirmais()
            {
                Console.WriteLine("Tiek izveidots pirmais konstruktors");
            }
            ~Pirmais()
            {
                Console.WriteLine("Pirma konstruktora objekts tiek iznicinats");
            }
            public class Otrais : Pirmais
            {
                public Otrais()
                {
                    Console.WriteLine("Tiek izveidots otrais konstruktora objekts");
                }

                ~Otrais()
                {
                    Console.WriteLine("Otra konstruktora objekts tiek iznicinats");
                }
            }
            public class Tresais : Otrais
            {
                public Tresais()
                {
                    Console.WriteLine("Tiek izveidots tresa konstruktora objekts");
                }
                ~Tresais()
                {
                    Console.WriteLine("Tresa konstruktora objekts tiek iznicinats");
                }
            }
        }

        static void Main(string[] args)
        {
            Pirmais.Tresais tresais = new Pirmais.Tresais();
        }
    }
}
