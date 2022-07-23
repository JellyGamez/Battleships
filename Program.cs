using Core;

var grid = new Grid(10, 10);
var ships = 3;

for (int i = 1; i <= ships; i++)
{
    bool invalid;
    do {
        invalid = false;
        Console.Write("Enter row and column separated by space: ");
        string[] input = Console.ReadLine().Split(" ");
        string row = input[0], column = input[1];
        try 
        {
            grid.Occupy(row, column);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            invalid = true;
        }
    } while (invalid);
}
grid.Display();

//get coordinatines by string
//validation refactoring - where does it belong