using System;
using System.Collections.Generic;
using System.Text;

namespace Estate_Without_Jude
{
    class Program
    {
        static void Main(string[] args)
        {
            Habitant a = new Habitant("Martin", "Holena", 17);
            Habitant b = new Habitant("Kači", "Kováč", 17);
            Habitant c = new Habitant("Filip", "Bezvajco", 14);
            Habitant d = new Habitant("Michal", "Turcel", 18);

            Console.WriteLine(a.ToString());

            Flat A = new Flat(1, 72, 3);
            Flat B = new Flat(2, 82, 4);
            Flat C = new Flat(3, 79, 2);

            A.AddHabitant(a);
            A.AddHabitant(b);
            Console.WriteLine(A.ToString());
            A.GetInfoAboutAllHabitants();

            B.AddHabitant(c);
            Console.WriteLine(B.ToString());
            B.GetInfoAboutAllHabitants();
            C.AddHabitant(d);

            Console.WriteLine(d);
            Console.WriteLine(d.GetInfoAboutFlat());
        }
    }
}
