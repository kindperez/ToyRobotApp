# TOY ROBOT SIMULATOR

This application aims to simulate the placement and movement of a robot using .NET 6

## Installation


Use the [.NET Core CLI Tool](https://learn.microsoft.com/en-us/dotnet/core/install/windows?tabs=net70) to build the application

1. Using the command line, navigate to the project folder.

2. Run the command to build the application

```cmd
dotnet build ToyRobotApp.csproj
```

3. Publish the app to the publish folder

```cmd
dotnet publish ToyRobotApp.csproj
```

4. Navigate to the publish folder and run ToyRobotApp.exe


## Usage

Before giving any other commands, it is required to place the robot first by providing the X and Y coordinate and default direction
```cmd
PLACE 0,0,NORTH
```

Use MOVE to instruct the robot to move 1 step in the direction it is facing.
```cmd
MOVE
```

Use LEFT to instruct the robot to rotate 90° anticlockwise/counterclockwise.
```cmd
LEFT
```

Use RIGHT to instruct the robot to rotate 90° clockwise.
```cmd
RIGHT
```

Use REPORT to display the robot's current location on the tabletop and the direction it is facing in words
```cmd
REPORT
```

Use DISPLAY to display the robot's current location on the tabletop and the direction it is facing.
```cmd
DISPLAY
```