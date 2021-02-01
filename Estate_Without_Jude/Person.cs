using System;
using System.Collections.Generic;
using System.Text;

namespace Estate_Without_Jude
{
    class Person
    {
        private string name { get; set; }
        private string surname { get; set; }
        private int age { get; set; }

        public Person(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public override string ToString()
        {
            return $"name: {this.name} \nsurname: {this.surname} \nage: {this.age} \n";
        }

    }
}
