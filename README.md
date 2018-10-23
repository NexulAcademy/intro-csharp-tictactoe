# intro-csharp-tictactoe
Introductory presentation project to learn some C#. This project is a tic tac toe game as a windows console project to learn object oriented design concepts.

# Workshop Steps
This workshop is intended to compliment an in-person instructor demo.

Each step of the workshop is contained in commits to this repository, so you can see the exact lines of code that changed. You can see all the commit steps or follow the links in each step.

[All commits](https://github.com/NexulAcademy/intro-csharp-tictactoe/commits/master)

## Step 1: Create a Console project

Create a Console App project using .NET Core with either the 'dotnet' command line or the Visual Studio new project dialog.

Name the project 'TicTacToe.ConsoleApp' in a folder where you can find it later.

Run the project and ensure it builds and runs.

## Step 2: Display and Inputs

The default project writes a simple message to the output window. Change the message.  Try the following methods:

	Console.Write();
	Console.WriteLine();

	Console.Read();
	Console.ReadLine();
	
## Step 3: Design the game model

This is a good time to figure out what the application will do and break that down into 'models' to represent the data of the application. A game might consist of the following:

### class GameBoard

to contain the game state data.

### class Grid

to contain a 2D grid of cells to be claimed by players

### class GridCell

to represent the claim status of each cell in the grid.

### class Player

to contain the name of a player and the marker placed on the board for claimed cells.

## Step 4: Properties and member accessibility

Remember the structure of the class descriptions above. What data properties makes up each class?  Classes may contain data properties as basic types like 'int' or 'string' or may also use yuor custom types 'GridCell' or a list (or array) of such cells.

Consider member accessibility of each class and property.  Options include:

'private': only can be seen and used within the declaring scope (class or project)
'public': can be seen anywhere the declaring scope can be seen (class or project).

'internal': less used, can be seen within the same project only, not from referencing projects.
'protected': private, but can also been seen from derived types.
'protected internal': combination of the two.

Try adding properties and then compare your answer to commit labelled ['step004'](https://github.com/NexulAcademy/intro-csharp-tictactoe/commit/744fe06cd1a9f90f311d6f68dd3133543f48dafa).

## Step 5 to 6: Instantiate a class structure - Gameboard

Now that class types are defined, use those types to build an instance of a Gameboard with all the cells populated with a grid size of 3x3 cells.

Make it easy to use this instantiation logic by enclosing it in a method and using the method from the static Main method.

Compare your answer to a combination of commits ['Step005'](https://github.com/NexulAcademy/intro-csharp-tictactoe/commit/1515bd65b284fad8a693ddb1edb20629552c838a) and ['Step006'](https://github.com/NexulAcademy/intro-csharp-tictactoe/commit/913f820fd6fa048b7fca6028b1756d469c6811d9).

## Step 7: Using constructors

Classes can have complex logic that should be 'encapsulated' so the calling code doesn't need to know internal implementation details. Move some of the implementation logic to the class constructors.

Compare your answer to commit ['Step007'](https://github.com/NexulAcademy/intro-csharp-tictactoe/commit/243f7ec5c1cfbb78bc543cf4fd8d785d11472002).

## Step 8: Encapsulate generation logic

Go further than step 7 by moving the Gameboard generation logic from the static Main class into the class that makes the most sense. Remove the logic from the Main class.

In the future, we may want a custom size board. Make the new generation logic take parameters for the width and height of the grid.

Compare your answer to commit ['Step008'](https://github.com/NexulAcademy/intro-csharp-tictactoe/commit/1bd904de102a780d3d6e005f82794368e5566567).

## Step 9: Ensuring 'clean' user inputs

Users can enter bad data. Your code should guard against invalid values.  Add prompts for the user to enter the number of columns and rows for the grid.

int.TryParse(): if the value isn't an integer, inform them of the problem and re-prompt for a value.

Use the user specified grid size to generate the game board.

Compare your answer to commit ['Step009'](https://github.com/NexulAcademy/intro-csharp-tictactoe/commit/b8fddbfb6c6a65c8d356bde0ec31456c15a1bc46).

## Step 10: DRY user inputs

DRY means "Don't Repeat Yourself."

You may have found some repeating code patterns in your solution. Create a helper method to prompt the user for an integer value, and use that method to prompt for both integer values.

Compare your answer to commit ['Step010'](https://github.com/NexulAcademy/intro-csharp-tictactoe/commit/fcd8d9484f3fd0f00d75cf1a6f2b414debb51018).

## Step 11: Initialize players

Before the game can be played, the game needs to know the quantity and names of players.  Add a prompt in the Main class for this information and use it to initialize the players list of the gameboard.

Compare your answer to commit ['Step011'](https://github.com/NexulAcademy/intro-csharp-tictactoe/commit/cb02da0797d6d9881b67e0ad860c572ce04b3a78).

## Step 12: Extract rendering of the GameBoard 

The rendering logic is currently hard-coded into the Main class. Before the logic is improved, move it to a new location to improve maintainability of the application. This will also allow for a later improvement to change the renderer to a new type for a different style of display.

Compare your answer to commit ['Step012'](https://github.com/NexulAcademy/intro-csharp-tictactoe/commit/e6910161e586a45bebd841c71c140dbed491eb07).

## Step 13: Fun with ASCII Art

The gameboard could use some improvement in display.  Use normal keyboard characters to render a game board similar to the following for a 1 row, 3 column layout:

	_____________
	|   |   |   |
	| x | o |   |
	|___|___|___|

	Player 1: x
	Player 2: o

Build the rendering logic to work for any number of user specified rows and columns.

Compare your answer to commit ['Step013'](https://github.com/NexulAcademy/intro-csharp-tictactoe/commit/b4b4ceab681937ba437683486b896c1279dee224).

## Step 14 to 15: Building a game loop

Now that the board can render any single point in a game, think of where to create a loop that runs until an end game condition is met.

Each turn consists of each player picking a row and column number to place their next marker, validation that the location is valid (and not taken), and then rendering the updated board. Defer adding the move validation logic for the next step.

The game could be exited when a user presses a particular key.  For safety, you may want to confirm the early exit is desired before terminating the game loop.

Compare your answer to commit ['Step014'](https://github.com/NexulAcademy/intro-csharp-tictactoe/commit/2e29e69f568701d3469e149d626518c5371dc3bc) and ['Step015'](https://github.com/NexulAcademy/intro-csharp-tictactoe/commit/4b19313110d51fdf39f977161b53541465f11a97).

## Step 16: Move Validation

The GameBoard should know how to save a move by the player. Add a Move method to the GameBoard to accept a players move request. This logic should also trigger any validation required.

In the Program class, add the user inputs and pass them into the new GameBoard Move method.

Compare your answer to commit ['Step016'](https://github.com/NexulAcademy/intro-csharp-tictactoe/commit/303fb6353ddb5d855b717ddae38d8829d718b6eb)

# Extended exercises

This application is an open grid game design. The engine still needs a way to determine if the game has been won, and if so render a winning game effect of some kind.

This was not a lesson on good game design, but rather how to evolve an application and OOP object model as usage requirements change.
