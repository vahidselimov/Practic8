using System;
using System.Collections.Generic;
using System.Text;

namespace Practic8
{
    internal class Pharmacy
    {
        public string Name;
        public static int UnikalId;
        public Drug[] Arr;
        public Pharmacy()
        {
            UnikalId++;
            Arr = new Drug[0];


        }
        public override string ToString()
        {
            return $"Name {Name} UNikalId{UnikalId}";

        }
        public Drug[] AddDrug(Drug drug)
        {
            Array.Resize(ref Arr, Arr.Length + 1);
            Arr[Arr.Length - 1] = drug;
            return Arr;

        }
        public void durglist()
        {
            foreach (var item in Arr)
            {
                Console.WriteLine($"Drug Name:{item.Name} Drug count{item.Count} Drug Price{item.Price}");
            }

        }
        public void SaleDrug(string name,double price,int count)
        {
            bool Name = false;
            bool Price = false;
            bool Count = false;
            foreach (var item in Arr)
            {
                if (item.Count<=count)
                {
                    Count = true;
                }
                if (item.Price<=price)
                {
                   Price = true;

                }
                if (item.Count<=count)
                {
                    Count = true;
                }
                bool check = Name && Price && Count;
              

                
            }

        }
    }
}
    

