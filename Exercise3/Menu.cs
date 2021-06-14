using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    class Menu
    {
        private int choice;
        public int Choice { get=>choice;
            set
            {
                if (choice<8 &&choice>0)
                {
                    choice = value;
                }
                else
                {
                    throw new OutOfRange();
                }
            } }
        public int PrintOptions()
        {
            string[] names = Enum.GetNames(typeof(Options));
            int[] values = (int[])Enum.GetValues(typeof(Options));
            Console.WriteLine("Welcome to the accounting system, please enter the number of your choice");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"If you want to {names[i]}, enter {values[i]}");
            }
            this.Choice = Convert.ToInt32(Console.ReadLine());
            return this.Choice;
        }
    }
}
