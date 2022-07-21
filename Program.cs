using Core;

var grid = new Grid(10, 10);
var ships = 3;

for (int i = 1; i <= ships; i++)
{
    bool invalid = true;
    do {
        int row = Print.GetInput("Row: ");
        int column = Print.GetInput("Column: ");
        invalid = !(row >= 1 && column >= 1 && row <= grid.SizeX && column <= grid.SizeY);
        if (invalid)
            Console.WriteLine("Invalid options");
        else
            grid.Occupy(row, column);
    } while (invalid);
}
grid.Display();

//get coordinatines by string
//validation refactoring - where does it belong