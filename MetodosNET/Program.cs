using System;

namespace MetodosNET
{
    class Program
    {
        static void Main(string[] args)
        {
            Random dice = new Random();
            int roll = dice.Next(1, 7);
            Console.WriteLine(roll);
            //Métodos Sobrecargados
            int number = 7;
            string text = "seven";

            Console.WriteLine(number);
            Console.WriteLine();
            Console.WriteLine(text);

            //Sobre carga de métodos
            Random dice2 = new Random();
            int roll1 = dice2.Next();
            int roll2 = dice2.Next(101);
            int roll3 = dice2.Next(50, 101);

            Console.WriteLine($"First roll: {roll1}");
            Console.WriteLine($"Second roll: {roll2}");
            Console.WriteLine($"Third roll: {roll3}");
            //2,147,483,647, que es el valor máximo que int puede almacenar


            //Ejercicio
            int firstValue = 500;
            int secondValue = 600;
            int largerValue;

            largerValue = Math.Max(firstValue, secondValue);

            Console.WriteLine(largerValue);
        }
    }
}
