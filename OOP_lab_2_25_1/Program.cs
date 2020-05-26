using System;

namespace OOP_lab_2_25_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            switch (a % 10)
            {
                case 1:
                    Console.WriteLine("{0} рiк.", a);
                    break;

                case 2:
                case 3:
                case 4:
                    Console.WriteLine("{0} рoки.", a);
                    break;

                default:
                    Console.WriteLine("{0} рoкiв.", a);
                    break;
            }
        }
    }
}
