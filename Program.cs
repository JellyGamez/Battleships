using Core;
using Core.Strategies;


var ships = new List<Ship>();

ships.Add(new Ship("Cruiser", 3));
ships.Add(new Ship("Fishing Boat", 1, 2));
ships.Add(new Ship("Battleship", 5));
ships.Add(new Ship("Destroyer", 2));

var player = new User("player", ships);
player.AttackStrategy = new ManualAttackStrategy();


var ai = new User("AI", ships);


var players = new List<IUser>() {
    player,
    ai,
};




///// TODO: Allow user to choose to place ships manually or randomly.
///// TODO: Implement feature to play against AI
// TODO: Different ship sizes
// TODO: Ship orientation
///// TODO: Implement win/lose feature
// TODO: Explain Design Pattern for Attack strategy for AI
// TODO: Implement rounds + score (Optional)
// TODO: Improve UI using colors, dividers, etc. (Optional) 

Console.WriteLine("Place ships randomly? y/n");
var input = Console.ReadLine();
if (input == "y")
    player.ShipPlacementStrategy = new RandomShipPlacementStrategy();
else
    player.ShipPlacementStrategy = new ManualShipPlacementStrategy();

foreach (var user in players)
{
    user.PlaceShips();
}


bool isRunning = true;

while (isRunning)
{

    // Update data / Do stuff
    // Check Conditions Win/Lose, /Alive/Dead
    // Display UI / Render UI
    foreach(var user in players){
        Print.Header($"{user.Name} Grid");
        user.AttackGrid.Display();
    }

    foreach(var user in players){ 
        foreach(var enemy in players) {
            if(user != enemy){
                user.Attack(enemy);
            }
        }

    }

    foreach(var user in players){
        if (user.HasLost)
        {
            isRunning = false;
            Console.WriteLine($"{user.Name} lost");
        }
    }
}