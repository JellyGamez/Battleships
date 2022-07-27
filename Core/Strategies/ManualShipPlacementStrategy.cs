namespace Core.Strategies
{
    class ManualShipPlacementStrategy : IShipPlacementStrategy
    {
        public Dictionary<int, int> Ships = new Dictionary<int, int>(){
            {4, 1},
            {3, 2},
            {2, 3},
            {1, 4}
        };
        public void PlaceShips(Grid grid)
        {
            foreach (KeyValuePair<int, int> element in Ships)
            {
                for (int i = 1; i <= element.Key; i++)
                {
                    Console.WriteLine("Ship size = " + element.Value);
                    List<KeyValuePair<int, int>> CurrentShip = new List<KeyValuePair<int, int>>();
                    for (int j = 1; j <= element.Value; j++)
                    {
                        bool invalid = true;
                        do
                        {
                            KeyValuePair<int, int> Coordinates = Print.GetValidCoordinates(grid);
                            if (grid.ValidOrientation(CurrentShip, Coordinates))
                            {
                                grid.Occupy(Coordinates, CellType.ship);
                                CurrentShip.Add(Coordinates);
                                invalid = false;
                            }
                        } while (invalid);
                        grid.Display();
                    }
                }
            }
        }
    }
}