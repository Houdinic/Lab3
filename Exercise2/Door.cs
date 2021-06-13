using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class Door
    {
        protected string color;
        public Door()
        {
            color = "Green";
        }
        public Door(string color)
        {
            this.color = color;
        }
        public string Color { get => color; set => color = value; }
        public void ShowData()
        {
            Console.WriteLine($"I am a door, my color is {color}");
        }
    }
}
