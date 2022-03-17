using System;
using Task.Class.Models;

namespace Task.Class
{
    class Program
    {
        static void Main(string[] args)
        {

            
            int quantity = GetInputQuantity("Please enter how many notebooks you want: ", 1, 100);

            Notebook[] notebooks = new Notebook[quantity];
            for (int i = 0; i < quantity; i++)
            {
                Console.Clear();
                
                string brandName = GetInputString("Please enter the Brand Name: ", 1, 100);

                
                string model = GetInputString("Please enter the Model: ", 1, 100);

                
                int ram = GetInputInt("Please enter the size of Ram: ", 1, 10000);

                
                int storage = GetInputInt("Please enter the size of Storage: ", 1, 1000);

                
                double price = GetInputDouble("Please enter the Price: ", 1, 10000);


                int count = GetInputInt("Please enter the Count: ", 1, 100);

                Console.WriteLine("=====================");

                notebooks[i] = new Notebook(brandName, price, count)
                {
                    Model = model,
                    Storage = storage,
                    Ram = ram


                };




            }
            Console.Clear();
            Console.WriteLine("List of Notebooks: ");
            foreach (var item in notebooks)
            {

                item.GetInfo();
                Console.WriteLine(" ");
            }


        }

        static int GetInputQuantity(string name, int min, int max)
        {
            int input;
            do
            {
                Console.WriteLine(name);
                input = Convert.ToInt32(Console.ReadLine());
            } while (input<min || input>max);
            return input; 

        }

        static string GetInputString(string name, int min, int max)
        {
            string input;
            do
            {

                Console.WriteLine(name);
                input = Console.ReadLine();
            } while (input.Length < min || input.Length > max) ;
            return input;
        }

        static int GetInputInt(string name, int min, int max)
        {
            int input;
            do
            {
                Console.WriteLine(name);
                input = Convert.ToInt32(Console.ReadLine());
            } while (input < min || input > max);
            return input;

        }
        static double GetInputDouble(string name, int min, int max)
        {
            double input;
            do
            {
                Console.WriteLine(name);
                input = Convert.ToInt32(Console.ReadLine());
            } while (input < min || input > max);
            return input;

        }
    }
}
