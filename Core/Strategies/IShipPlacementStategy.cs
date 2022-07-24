namespace Core.Strategies
{
    interface IShipPlacementStrategy
    {
        public void PlaceShips(int ships, Grid grid);
    }
}