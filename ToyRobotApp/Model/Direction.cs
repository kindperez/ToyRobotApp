using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyRobotApp.Model
{
    internal class Direction
    {
        public string direction { get; set; }
        public int polarity { get; set; }
        public string axis { get; set; }
        public string symbol { get; set; }

        public Direction() 
        { 
            direction = String.Empty;
            polarity = 0;
            axis = "x";
            symbol = String.Empty;
        }

    }
}
