using System;
using System.Collections.Generic;
using System.Text;

namespace Practic8
{
    internal class TypeDrug
    {
        public static int Id = 0;
        public string TypeName;
        public string Typename
        {
            get => TypeName;
            set
            {
                Typename = value;
            }
        }

        
    }
   
}
