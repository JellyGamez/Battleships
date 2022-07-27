using Core.Strategies;

namespace Core
{
    class User : IUser
    {
        public string Name { get; protected set; }
        public Grid Grid {get; set;}
        public Grid AttackGrid {get; set;}
        public int ShipCount {get; set;}
        public bool HasLost {get => ShipCount == 0;}
        public IAttackStrategy AttackStrategy {get; set;}
        public IShipPlacementStrategy ShipPlacementStrategy {get; set;}
        public List<Ship> Ships {get; set;}
        public User(string name, List<Ship> ships)
        {
            Name = name;
            Grid = new Grid(10, 10);
            AttackGrid = new Grid(10, 10);
            Ships = ships;
            ShipCount = ships.Count;
            AttackStrategy = new RandomAttackStrategy();
            ShipPlacementStrategy = new RandomShipPlacementStrategy();
           
        }

       public void Attack(IUser enemy){
            AttackStrategy.Attack(enemy, AttackGrid);
       }

        public override string ToString()
        {
            return String.Empty;
        }

        public void PlaceShips()
        {
            ShipPlacementStrategy.PlaceShips(Grid, Ships);
        }
    }
}