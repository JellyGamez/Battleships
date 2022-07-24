using Core;

var ships = 3;
var user = new User("player");
var AI = new User("AI");

AI.PlaceShipsRandomly(ships);

///// TODO: Allow user to choose to place ships manually or randomly.
// TODO: Implement feature to play against AI
// TODO: Different ship sizes
// TODO: Ship orientation
// TODO: Implement win/lose feature
// TODO: Explain Design Pattern for Attack strategy for AI
// TODO: Implement rounds + score (Optional)
// TODO: Improve UI using colors, dividers, etc. (Optional) 

Console.WriteLine("Place ships manually? y/n")
bool invalid = true;
do
{
    
} while (true);
user.PlaceShipsManually(ships);
user.Grid.Display();
AI.Grid.Display();
while (true)
{
    user.AttackGrid.Display();
    var coordinates = Print.GetValidCoordinates(user.AttackGrid);
    user.Attack(coordinates, AI);
}