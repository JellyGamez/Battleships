namespace Core 
{
    class User
    {
        public string Name {get; private set;}
        
        public User(string name)
        {
            Name = name;
        }
        
        public bool LoseCondition()
        {
            return false;
        }

        public override string ToString()
        {
            return String.Empty;
        }
    }
}