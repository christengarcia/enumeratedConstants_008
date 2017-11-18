using System;

namespace enumeratedConstants_008
{
    class Program
    {
        enum Color
        {
            Red,
            Orange,
            Green,
            Blue,
            Indigo,
            Violet,
        }

        static void Main(string[] args)
        {
            Color favorite = Color.Green;

            switch (favorite)
            {
                case Color.Red:
                    Console.WriteLine("You chose Red");
                    break;
                case Color.Orange:
                    Console.WriteLine("You chose Orange");
                    break;
                case Color.Green:
                    Console.WriteLine("You chose Green");
                    break;
                case Color.Blue:
                    Console.WriteLine("You chose Blue");
                    break;
                case Color.Indigo:
                    Console.WriteLine("You chose Indigo");
                    break;
                case Color.Violet:
                    Console.WriteLine("You chose Violet");
                    break;
                default:
                    Console.WriteLine("You didn't chose a color");
                    break;
            }
        }
    }
}