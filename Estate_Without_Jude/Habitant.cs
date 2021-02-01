using System;
using System.Collections.Generic;
using System.Text;

namespace Estate_Without_Jude
{
    class Habitant : Person
    {
        public Habitant(string name, string surname, int age) : base(name, surname, age)
        {

        }
        public string GetInfoAboutFlat(Habitant habitant, Flat flat)
        {
            return $"{habitant.ToString()}{flat.ToString()}";
        }
    }
}
