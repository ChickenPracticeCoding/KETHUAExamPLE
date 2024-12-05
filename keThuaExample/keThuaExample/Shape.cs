using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace keThuaExample
{
    public class Shape
    {
        public string Color {get ; set;}
        public Boolean Filled {get; set;}
        public Shape() 
        {
            Color = "green";
            Filled = true;
        }

        public Shape(string color, Boolean filled)
        {
            Color = color;
            Filled = filled;
        }

        public virtual string ToString() 
        {
            if (Filled) 
            {
                return $"A Shape with color of {Color} and filled";
            }
            else 
            {
                return $"A Shape with color of {Color} and filled";
            }
        }
    }
}
