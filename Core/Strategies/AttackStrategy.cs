namespace Core.Strategies {

    abstract class AttackStrategy : IAttackStrategy {

        protected void Attack(KeyValuePair<int, int> position, IUser enemy, Grid attackGrid){
            switch (enemy.Grid.GetCellType(position))
            {
                default:
                case CellType.empty:
                    attackGrid.Occupy(position, CellType.miss);
                    break;
                case CellType.ship:
                    attackGrid.Occupy(position, CellType.hit);
                    enemy.ShipCount--;
                    break;
            }
        }

        abstract public void Attack(IUser enemy, Grid attackGrid);
    }
}