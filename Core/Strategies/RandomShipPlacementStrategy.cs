namespace Core.Strategies
{
    class RandomShipPlacementStrategy : IShipPlacementStrategy
    {

        public void PlaceShips(Grid grid, List<Ship> ships)
        {
            foreach (var ship in ships)
            {
                for (int i = 1; i <= ship.Amount; i++)
                {
                    Console.WriteLine($"{ship} size = {ship.Width}");
                    var CurrentShip = new List<KeyValuePair<int, int>>();

                    for (int j = 1; j <= ship.Width; j++)
                    {
                        var Coordinates = FindValidPosition(grid, CurrentShip);
                        grid.Occupy(Coordinates, CellType.ship);
                        CurrentShip.Add(Coordinates);

                        grid.Display();
                    }
                }
            }
        }


        private KeyValuePair<int, int> FindValidPosition(Grid grid, List<KeyValuePair<int, int>> currentShip)
        {
            bool invalid = true;
            KeyValuePair<int, int> coordinates = new KeyValuePair<int, int>();

            do
            {
                coordinates = grid.GetRandomCoordinates();
                invalid = !grid.ValidOrientation(currentShip, coordinates);

            } while (invalid);

            return coordinates;
        }
    }
}