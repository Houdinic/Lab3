using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class Person
    {
        protected string name;
        protected House house;
        public Person()
        {
            name = "Haocheng";
            house = new House(125);
        }
        public Person(string name, House house)
        {
            this.name = name;
            this.house = house;
        }
        public string Name { get=>this.name; set=>this.name=value; }
        public House House { get => this.house; set => this.house = value; }
        public void ShowData()
        {
            Console.WriteLine("My name is {0}.", name);
            house.ShowData();
            house.Door.ShowData();

        }

    }
}
