namespace Core 
{
    class MenuItem
    {
        public string Label {get; private set;}
        public string Id {get; private set;}
        
        public MenuItem(string id, string label)
        {
            Label = label;
            Id = id;
        }

        public override string ToString()
        {
            return $"{Id} = {Label}";
        }
    }
}