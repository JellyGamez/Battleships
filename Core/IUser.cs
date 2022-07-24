using Core.Strategies;

namespace Core {

    interface IUser {
        public string Name { get; }
        public int ShipCount {get; set;}
        public Grid Grid {get; set;}
        public Grid AttackGrid {get; set;}
        public bool HasLost {get;}
        public IAttackStrategy AttackStrategy {get; set;}
        public IShipPlacementStrategy ShipPlacementStrategy {get; set;}

        abstract public void Attack(IUser enemy);

        public void PlaceShips(int ships);
    }

}