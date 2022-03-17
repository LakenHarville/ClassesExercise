using System;

namespace ClassesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            car.Year = 2013;
            car.Make = "KIA";
            car.Model = "Optima";
            car.Drive();

        }

        
    }
}
