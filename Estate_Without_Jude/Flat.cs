using System;
using System.Collections.Generic;
using System.Text;

namespace Estate_Without_Jude
{
    class Flat
    {
        private int numberOfFlat { get; set; }
        private int areaOfFlat { get; set; }
        private int numberOfRoom { get; set; }

        public List<Habitant> habitants = new List<Habitant>();

       

        public Flat(int numberOfFlat, int areaOfFlat, int numberOfRoom)
        {
            this.numberOfFlat = numberOfFlat;
            this.areaOfFlat = areaOfFlat;
            this.numberOfRoom = numberOfRoom;
        }
        public override string ToString()
        {
            return $"numberOfFlat: {this.numberOfFlat} \nareaOfFlat: {this.areaOfFlat} \nnumberOfRoom: {this.numberOfRoom} \n";
        }
        public void AddHabitant(Habitant habitant)
        {
            habitants.Add(habitant);
        }
        public void GetInfoAboutAllHabitants()
        {
            for (int i = 0; i < habitants.Count; i++)
            {
                Console.WriteLine($"{habitants[i]}");
            }
        }
    }
}
