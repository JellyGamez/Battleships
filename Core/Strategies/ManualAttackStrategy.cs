namespace Core.Strategies
{
    class ManualAttackStrategy : AttackStrategy
    {
        public override void Attack(IUser enemy, Grid attackGrid)
        {
            var position = Print.GetValidCoordinates(attackGrid);
            Attack(position, enemy, attackGrid);
        }
    }
}