using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyRobotApp.Model
{
    internal class Location
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Location(int x = 0, int y = 0)
        {
            X = x;
            Y = y;
        }

    }
}
