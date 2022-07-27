namespace Core
{
    class Grid
    {
        public int SizeX { get; private set; }
        public int SizeY { get; private set; }


        public Cell[,] Cells { get; private set; }
        public Grid(int sizex, int sizey)
        {
            SizeX = sizex;
            SizeY = sizey;
            Cells = new Cell[SizeX, SizeY];
            Build();
        }

        private void Build()
        {
            for (int i = 0; i < SizeX; i++)
                for (int j = 0; j < SizeY; j++)
                {
                    Cells[i, j] = new Cell();
                }
        }
        public void Display()
        {
            Console.Write("  ");
            for (int i = 1; i <= SizeX; i++)
                Console.Write(i + " ");
            Console.WriteLine();
            for (int i = 0; i < SizeX; i++, Console.WriteLine())
            {
                Console.Write(i + 1 + " ");
                for (int j = 0; j < SizeY; j++)
                {
                    Console.Write(Cells[i, j] + " ");
                }
            }
        }
        public bool IsEmpty(int x, int y)
        {
            return Cells[x - 1, y - 1].Type == CellType.empty;
        }

        public bool IsOutOfBounds(int x, int y)
        {
            return !(x >= 1 && y >= 1 && x <= SizeX && y <= SizeY);
        }
        public void Occupy(int x, int y, CellType type)
        {
            Cells[x - 1, y - 1].Type = type;
        }

        public void Occupy(KeyValuePair<int, int> coordinates, CellType type)
        {
            Occupy(coordinates.Key, coordinates.Value, type);
        }

        public void Occupy(Vector2 coordinates, CellType type)
        {
            Occupy(coordinates.X, coordinates.Y, type);
        }

        public void ValidateCoordinates(int x, int y)
        {
            if (IsOutOfBounds(x, y))
                throw new Exception("Invalid input (out of bounds)");
            if (!IsEmpty(x, y))
                throw new Exception("Cell is already occupied");
        }
        public void ValidateCoordinates(KeyValuePair<int, int> coordinates)
        {
            ValidateCoordinates(coordinates.Key, coordinates.Value);
        }

        public void ValidateCoordinates(Vector2 coordinates)
        {
            ValidateCoordinates(coordinates.X, coordinates.Y);
        }

        public KeyValuePair<int, int> GetRandomCoordinates()
        {
            var position = new Vector2();
            bool invalid = true;
            
            do
            {
                position = Vector2.Random(SizeX, SizeY);
        
                try
                {
                    ValidateCoordinates(position.X, position.Y);
                    invalid = false;
                }
                catch (Exception e)
                { }
            } while (invalid);

            return position.ToKeyValuePair();
        }


        public CellType GetCellType(int x, int y)
        {
            return Cells[x - 1, y - 1].Type;
        }

        public CellType GetCellType(KeyValuePair<int, int> coordinates)
        {
            return GetCellType(coordinates.Key, coordinates.Value);
        }

        public bool ValidOrientation(List<KeyValuePair<int, int>> ships, KeyValuePair<int, int> ship)
        {
            switch (ships.Count)
            {
                case 0:
                    return true;
                case 1:
                    if (ships[0].Value == ship.Value)
                    {
                        if (ships[0].Key == ship.Key - 1 || ships[0].Key == ship.Key + 1)
                            return true;
                    }
                    else if (ships[0].Key == ship.Key)
                    {
                        if (ships[0].Value == ship.Value - 1 || ships[0].Value == ship.Value + 1)
                            return true;
                    }
                    return false;
                default:
                    if (ships[0].Value == ships[1].Value)
                    {
                        if (ship.Value != ships[0].Value)
                            return false;
                        foreach (KeyValuePair<int, int> element in ships)
                        {
                            if (element.Key == ship.Key - 1 || element.Key == ship.Key + 1)
                                return true;
                        }
                    }
                    else if (ships[0].Key == ships[1].Key)
                    {
                        if (ship.Key != ships[0].Key)
                            return false;
                        foreach (KeyValuePair<int, int> element in ships)
                        {
                            if (element.Value == ship.Value - 1 || element.Value == ship.Value + 1)
                                return true;
                        }
                    }
                    return false;
            }
        }
    }
}