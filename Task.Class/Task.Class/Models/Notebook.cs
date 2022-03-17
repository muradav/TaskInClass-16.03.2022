using System;
using System.Collections.Generic;
using System.Text;

namespace Task.Class.Models
{
    class Notebook:Product
    {
        public string BrandName;
        public string Model;
        public int Ram;
        public int Storage;

        public Notebook(string brandName, double price, int count) : base(price,count)
        {
            BrandName = brandName;

        }

        public void GetInfo()
        {
            Console.WriteLine($"BrandName: {BrandName} \n" +
                $"Model: {Model} \n" +
                $"Ram: {Ram} \n" +
                $"Storage: {Storage} \n" +
                $"Price: {Price} \n" +
                $"Count: {Count}" 
                );
        }


    }
}
