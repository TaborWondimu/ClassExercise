using System;
namespace ClassExercise
{
    class program
    {
        public static void Main(string[] args)
        {
            var carList = new Car();
            carList.Make = "Lambo";
            carList.Model = "Urus";
            carList.Year = 2022;
            Console.WriteLine($"The make is {carList.Make}, the model is {carList.Model}, it was made in the year {carList.Year} ");

        }
    }
} 