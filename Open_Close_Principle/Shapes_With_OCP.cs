using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Close_Principle
{
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
