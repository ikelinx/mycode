using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp
{
    class Car
    {
        // Member variables
        // Private hides the variable from other classes
        private string _model;
        private string _brand;

        public Car(string brand, string model) {

            _model = model;
            _brand = brand;
            Console.WriteLine($"Brand is: {brand} - Model is: {model}");
        }
    }
}
