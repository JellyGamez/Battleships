namespace Core.Strategies
{
    class RandomShipPlacementStrategy : IShipPlacementStrategy
    {
        public void PlaceShips(int ships, Grid grid)
        {
            for (int i = 1; i <= ships; i++)
                grid.Occupy(grid.GetRandomCoordinates(), CellType.ship);
        }
    }
}