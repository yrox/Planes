using System;

namespace Planes
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. alphabetize list\n" +
                              "2. max places\n" +
                              "3. min, max and average diatance\n" +
                              "4. plain names containing letter\n" +
                              "5. group by type\n" +
                              "6. add planes\n");

                var ans = Console.ReadLine();
                var choice = 0;
                if (int.TryParse(ans, out choice))
                {
                    switch (choice)
                    {
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                        case 6:
                        default:
                            Console.WriteLine("wrong selection");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("type numeric value only");
                }
            }
            
        }
    }
}
