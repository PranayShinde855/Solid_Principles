using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Close_Principle
{
    // Open-Close Principle : A class should be open to Extendion but close for modificaion.
    interface IShapes
    {
        string Shape();
    }

    class Square : IShapes
    {
        public string Shape()
        {
            return "Square";
        }
    }

    class Triangle : IShapes
    {
        public string Shape()
        {
            return "Triangel";
        }
    }
}
