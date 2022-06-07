using System;

namespace lesson111
{
    class Program
    {
        static void Main(string[] args)
        {
            string option;
            do
            {

                Console.WriteLine("Telebe elave et");
                Console.WriteLine("Telebelerin ortalamasina bax");
                Console.WriteLine("Telebeleri goster");
                Console.WriteLine("Menudan cix");

                option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.WriteLine("Product elave etmek emeliyyati");
                        break;
                    case "2":
                        Console.WriteLine("Telebelerin ortalamasin gostermek emeliyyati");
                        break;
                    case "3":
                        Console.WriteLine("Telebeleri goster");
                        break;
                    case "4":
                        break;
                    default:
                        break;

                }

            }
            while (true);
        }
    }
}
