namespace Core.Strategies
{
    interface IAttackStrategy
    {
        public void Attack(IUser enemy, Grid attackGrid);
    }
}