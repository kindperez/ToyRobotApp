using System;
using ToyRobotApp.Model;
public class Program
{
    static void Main(string[] args)
    {
        int mapX = 5;
        int mapY = 5;
        bool? result = null;
        int placeX = 0;
        int placeY= 0;
        string placeDirection = "NORTH";
        bool robotPlaced = false;

        Robot robot = new Robot(mapX, mapY);

        Console.WriteLine("ROBOT START!");

        string commandString = Console.ReadLine().ToUpper().Trim();
        string command = String.Empty;        

        do
        {
            string[] commands = commandString.Split(" ");

            if(commands.Length > 0)
            {
                command = commands.First();
            }

            if (!robotPlaced)
            {
                if (command.Equals("PLACE"))
                {
                    result = false ;
                    if (commands.Length > 1)
                    {
                        string[] placeParams = commands[1].Split(',');
                        if (placeParams.Length == 3)
                        {
                            placeX = Convert.ToInt32(placeParams[0]);
                            placeY = Convert.ToInt32(placeParams[1]);

                            if (placeX >= mapX || placeX < 0)
                            {
                                Console.WriteLine("PLACE X IS OUT OF BOUNDS!");
                            }
                            else if (placeY >= mapY || placeY < 0)
                            {
                                Console.WriteLine("PLACE Y IS OUT OF BOUNDS!");
                            }
                            else
                            {
                                result = robot.Place(placeX, placeY, placeParams[2]);
                                robotPlaced = true;
                                result = true;
                            }
                        }
                        else
                        {
                            Console.WriteLine("INVALID PLACE PARAMETERS!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("MISSING PLACE PARAMETERS!");
                    }
                }
                else
                {
                    Console.WriteLine("PLACE THE ROBOT FIRST!");
                }
            }
            else
            {
                result = false;
                switch (command)
                {
                    case "MOVE":
                        result = robot.Move();
                        break;
                    case "LEFT":
                        result = robot.TurnLeft();
                        break;
                    case "RIGHT":
                        result = robot.TurnRight();
                        break;
                    case "REPORT":
                        result = robot.Report();
                        break;
                    case "DISPLAY":
                        result = robot.Display();
                        break;
                    default:
                        Console.WriteLine("INVALID COMMAND!");
                        result = null;
                        break;
                }
            }

            if (result.HasValue)
            {
                if (result.Value)
                {
                    Console.WriteLine("COMMAND EXECUTED");
                }
                else
                {
                    Console.WriteLine("COMMAND FAILED");
                }
            }

            commandString = Console.ReadLine().ToUpper().Trim();

        }while(commandString.Length > 0);


    }

}