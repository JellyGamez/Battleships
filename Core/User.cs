namespace Core
{
    class User
    {
        public string Name { get; private set; }
        public Grid Grid, AttackGrid;

        public User(string name)
        {
            Name = name;
            Grid = new Grid(10, 10);
            AttackGrid = new Grid(10, 10);
        }

        public override string ToString()
        {
            return String.Empty;
        }

        public void Attack(int x, int y, User enemy)
        {
            switch (enemy.Grid.GetCellType(x, y))
            {
                default:
                case CellType.empty:
                    AttackGrid.Occupy(x, y, CellType.miss);
                    break;
                case CellType.ship:
                    AttackGrid.Occupy(x, y, CellType.hit);
                    break;
            }
        }

        public void Attack(KeyValuePair<int, int> coordinates, User enemy)
        {
            int x = coordinates.Key, y = coordinates.Value;
            Attack(x, y, enemy);
        }

        public void PlaceShipsRandomly(int ships)
        {
            for (int i = 1; i <= ships; i++)
                Grid.Occupy(Grid.GetRandomCoordinates(), CellType.ship);
        }

        public void AttackRandomly(User enemy)
        {
            Attack(AttackGrid.GetRandomCoordinates(), enemy);
        }
    }
}