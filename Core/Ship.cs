namespace Core {
    class Ship {
        public string Name {get; private set;}
        public int Width {get; private set;}

        public int Amount {get; private set;}


        public Ship(string name) {
            Name = name;
            Amount = 1;
            Width = 1;
        }

        public Ship(string name, int width) {
            Name = name;
            Amount = 1;
            Width = width;
        }

         public Ship(string name, int width, int amount) {
            Name = name;
            Amount = amount;
            Width = width;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}