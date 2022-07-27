namespace Core.Strategies
{
    class RandomShipPlacementStrategy : IShipPlacementStrategy
    {
        public Dictionary<int, int> Ships = new Dictionary<int, int>(){
            {1, 4},
            {2, 3},
            {3, 2},
            {4, 1}
        };
        public void PlaceShips(Grid grid)
        {
            foreach (KeyValuePair<int, int> element in Ships)
            {
                List<KeyValuePair<int, int>> CurrentShip = new List<KeyValuePair<int, int>>();
                for (int i = 1; i <= element.Value; i++)
                {
                    bool invalid = true;
                    do
                    {
                        KeyValuePair<int, int> Coordinates = grid.GetRandomCoordinates();
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