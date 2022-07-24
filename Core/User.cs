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
        public User(string name)
        {
            Name = name;
            Grid = new Grid(10, 10);
            AttackGrid = new Grid(10, 10);
            ShipCount = 3;
        }

       public void Attack(IUser enemy){
            AttackStrategy.Attack(enemy, AttackGrid);
       }

        public override string ToString()
        {
            return String.Empty;
        }

        public void PlaceShips(int ships)
        {
            ShipPlacementStrategy.PlaceShips(ships, Grid);
        }
    }
}