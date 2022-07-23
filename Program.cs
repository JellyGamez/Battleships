using Core;

var grid = new Grid(10, 10);
var ships = 3;


for (int i = 1; i <= ships; i++)
{
    grid.Display();
    bool invalid = true;
    do {
        Console.Write("Enter row and column separated by space: ");
        string[] input = Console.ReadLine().Split(" ");
        string row = input[0], column = input[1];
        try 
        {
            int x = Int32.Parse(row);
            int y = Int32.Parse(column);
            grid.Occupy(x, y);
            invalid = false;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    } while (invalid);
}
grid.Display();