using System;

namespace Week2Day1
{
    class Program
    {
        static void Main(string[] args)
        {   
            Person p1; //creo il solo riferimento all'oggetto senza crearlo
            //punto a null

            Person p2 = new Person();

            p2.FirstName = "Mario";
            p2.LastName = "Rossi";

            Person p3 = new Person();
            p3.FirstName = "Sara";
            p3.LastName = "Bianchi";

            p1 = p2; //2 riferimenti alla stessa istanza --> punta alla stessa memoria

            Console.WriteLine(p1.FirstName + " " + p1.LastName);
            p2.FirstName = "Dario";
            Console.WriteLine(p1.FirstName);

            Person p4 = new Person("Michela", "Neri");
            Person p5 = new Person("Samuele", "Verdi", 25);
            p5.Address.Street = "Via Roma";

            p5.PrintBioData();
        }
    }
}
