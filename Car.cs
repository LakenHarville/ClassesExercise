using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExercise
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; } 
        public int Year { get; set; }

        public void Drive()
        {
            Console.WriteLine($"This guy drives a {Year} {Make} {Model}!");
        }
    }
}
