using System;

namespace Open_Close_Principle
{
    class Shapes_Withoout_OCP
    {
        public string Shape { get; set; }
        public string PrintShape()
        {
            if (Shape == "Triangel")
            {
                return "Triangle";
            }
            else if (Shape == "Square")
            {
                return "Square";
            }
         return "Ok";
            
        }
        static void Main(string[] args)
        {
            Shapes_Withoout_OCP shape = new Shapes_Withoout_OCP();
            shape.PrintShape();
        }
    }
}
