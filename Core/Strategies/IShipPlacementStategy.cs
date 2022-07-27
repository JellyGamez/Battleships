namespace Core.Strategies
{
    interface IShipPlacementStrategy
    {
        public void PlaceShips(Grid grid, List<Ship> ships);
    }
}