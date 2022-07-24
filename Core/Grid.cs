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
        public KeyValuePair<int, int> GetRandomCoordinates()
        {
            var random = new Random();
            bool invalid = true;
            int x = 0, y = 0;
            do
            {
                x = random.Next(1, SizeX);
                y = random.Next(1, SizeY);
                try
                {
                    ValidateCoordinates(x, y);
                    invalid = false;
                }
                catch (Exception e)
                { }
            } while (invalid);
            return new KeyValuePair<int, int>(x, y);
        }
        public CellType GetCellType(int x, int y)
        {
            return Cells[x - 1, y - 1].Type;
        }

        public CellType GetCellType(KeyValuePair<int, int> coordinates)
        {
            return GetCellType(coordinates.Key, coordinates.Value);
        }
    }
}