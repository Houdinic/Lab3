using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise5
{
    class ComplexNumber
    {
        public int Real { get; set; }
        public int Imaginary { get; set; }
        public ComplexNumber(int real,int imaginary)
        {
            this.Real = real;
            this.Imaginary = imaginary;
        }
        public new string ToString()
        {
            return "(" +Convert.ToString(this.Real)+","+Convert.ToString(this.Imaginary)+")";

        }
        public void SetImaginary(int imaginary)
        {
            this.Imaginary = imaginary;
        }
        public double GetMagnitude()
        {
            return Math.Sqrt(this.Real * this.Real + this.Imaginary * this.Imaginary);
        }
        public ComplexNumber Add (ComplexNumber a)
        {
            this.Real = a.Real + this.Real;
            this.Imaginary = a.Imaginary + this.Imaginary;
            return this;
        }
    }
}
