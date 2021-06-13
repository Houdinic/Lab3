using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    abstract class Shape1
    {

        protected float R, L, B;

        //Abstract methods can have only declarations
        public abstract float Area();
        public abstract float Circumference();
        public abstract void GetData();

    }
    class Rectangle: Shape1
    {
        public override void GetData()
        {
            Console.WriteLine("Please type in Length and Breath of the Rectange: ");
            string[] parameters=Console.ReadLine().Split(" ");
            L = (float)Convert.ToDouble(parameters[0]);
            B = (float)Convert.ToDouble(parameters[1]);
        }
        public override float Area()
        {
            return L * B;
        }
        public override float Circumference()
        {
            return 2 * (L + B);
        }

    }
    class Circle:Shape1
    {
        public override void GetData()
        {
            Console.WriteLine("Please type in Raiud of the circle:");
            R = (float)Convert.ToDouble(Console.ReadLine());
        }
        public override float Area()
        {
            return R * R * (float)3.14;

        }
        public override float Circumference()
        {
            return 2 *(float) 3.14 * R;
        }
    }
}

