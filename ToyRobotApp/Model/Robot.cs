using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyRobotApp.Model
{
    internal class Robot
    {
        private readonly int _mapX = 0;
        private readonly int _mapY = 0;

        private Location location { get; set; }
        private Direction currentDirection { get; set; }

        private List<Direction> directions = new List<Direction>
        {
            new Direction { direction = "NORTH", polarity=1, axis="y", symbol="A"},
            new Direction { direction = "EAST", polarity=1, axis="x", symbol=">"},
            new Direction { direction = "SOUTH", polarity=-1, axis="y", symbol="V"},
            new Direction { direction = "WEST", polarity=-1, axis="x", symbol="<"}
        };    

        public Robot(int mapX, int mapY)
        {
            location = new Location(0, 0);
            currentDirection = directions[1];
            _mapX= mapX;
            _mapY= mapY;
        }

        public bool Place(int x, int y, string direction)
        {
            bool result = false;

            location.X = x;
            location.Y = y;

            currentDirection = directions.Find(d => d.direction.Equals(direction));

            if(!currentDirection.direction.Equals(String.Empty))
            {
                result = true;
            }

            return result;
        }

        public bool Move()
        {
            bool result = false;
            int newLoc = 0;

            switch (currentDirection.axis)
            {
                case "x":
                    newLoc = location.X + (currentDirection.polarity * 1);
                    if(newLoc >= 0 && newLoc < _mapX)
                    {
                        location.X = newLoc;
                    }
                    result = true;
                    break;
                case "y":
                    newLoc = location.Y + (currentDirection.polarity * 1);
                    if (newLoc >= 0 && newLoc < _mapY)
                    {
                        location.Y = newLoc;
                    }
                    result = true;
                    break;
            }

            return result;
        }

        public bool TurnRight()
        {
            bool result = false;

            currentDirection = directions.SkipWhile(s => s.direction != currentDirection.direction).Skip(1).DefaultIfEmpty(directions[0]).FirstOrDefault();

            result = true;

            return result;
        }

        public bool TurnLeft()
        {
            bool result = false;

            currentDirection = directions.TakeWhile(s => s.direction != currentDirection.direction).DefaultIfEmpty(directions[directions.Count-1]).LastOrDefault();

            result = true;

            return result;
        }

        public bool Report()
        {
            Console.WriteLine("The Robot is currently at (X:{0}, Y:{1}) facing {2}.", location.X, location.Y, currentDirection.direction);

            return true;
        }

        public bool Display()
        {
            for (int j = _mapY-1; j >=0; j--)
            {
                for (int i = 0; i < _mapX; i++)
                {
                    if (location.X == i && location.Y == j)
                    {
                        Console.Write(" {0} ", currentDirection.symbol);
                    }
                    else
                    {
                        Console.Write(" _ ");
                    }
                }
                Console.WriteLine();
            }

            return true;
        }

    }
}
