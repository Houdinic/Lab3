using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    class OutOfRange:Exception
    {
        public override string Message => "Index out of range!Please choose from 1 to 7 according to the menu!!!";
    }
}
