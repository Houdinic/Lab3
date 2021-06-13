using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class House
    {
        protected int area;
        protected Door door;
        public House(int area)
        {
            this.area = area;
            door = new Door();
        }
        public int Area { get; set; }
        public Door Door { get=>this.door; set=>door=value; }
        public virtual void ShowData()
        {
            Console.WriteLine("I am a house, my area is {0} square meters",area);
        }
    }
}
