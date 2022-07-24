namespace Core.Strategies
{
    class RandomAttackStrategy : AttackStrategy
    {
        public override void Attack(IUser enemy, Grid attackGrid)
        {
            var position = attackGrid.GetRandomCoordinates();

            Attack(position, enemy, attackGrid);
        }
    }
}