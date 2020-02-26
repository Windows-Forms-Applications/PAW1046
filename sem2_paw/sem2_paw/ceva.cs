using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem2_paw
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal();
            Animal a2 = new Animal(10, "Azorel", 9.7f);
            Animal a3 = new Animal(a2);
            a3.Nume = "Grivei";
            Console.WriteLine(a3.Nume);
            Console.WriteLine(a1.ToString());

            Animal a4 = (Animal)a3.Clone();
            a4.Varsta = 5;
            Console.WriteLine(a3);
            Console.WriteLine(a4);

            Girafa g1 = new Girafa(11, "Sophie", 80, 4, 270);
            Console.WriteLine(g1);
            Zebra z1 = new Zebra(8, "Marti", 150, true, 2);
            Console.WriteLine(z1);

            Zoo zoo1 = new Zoo();
            zoo1.ListaAnimale.Add(a1);
            zoo1.ListaAnimale.Add(a2);
            zoo1.ListaAnimale.Add(a3);
            zoo1.ListaAnimale.Add(a4);
            zoo1.ListaAnimale.Add(g1);
            zoo1.ListaAnimale.Add(z1);
            Console.WriteLine(zoo1);

            Zoo zoo2 = (Zoo)zoo1.Clone();
            zoo2.Denumire = "Baneasa";
            foreach (Animal a in zoo2.ListaAnimale)
                a.Nume += " de Bucuresti";
            zoo1.ListaAnimale.Sort();
            Console.WriteLine(zoo1);
            zoo2.ListaAnimale.Sort();
            Console.WriteLine(zoo2);
            Console.WriteLine("**********************");
            Console.WriteLine(zoo2[3]);
        }
    }
}
