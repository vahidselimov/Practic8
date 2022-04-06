using System;
using System.Collections.Generic;
using System.Text;

namespace Practic8
{
    internal class Drug
    {
        public string Name;
        public static int UnikalID;
        public double Price;
        public int Count;
        public override string ToString()
        {
            return $"Name {Name}  Price {Price} Count {Count}";

        }

    }
}
