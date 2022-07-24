namespace Core.Strategies
{
    class ManualShipPlacementStrategy : IShipPlacementStrategy
    {
        public void PlaceShips(int ships, Grid grid)
        {
            for (int i = 1; i <= ships; i++)
                grid.Occupy(Print.GetValidCoordinates(grid), CellType.ship);
        }
    }
}