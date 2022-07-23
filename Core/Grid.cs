namespace Core
{
    class Grid
    {
        public int SizeX {get; private set;}
        public int SizeY {get; private set;}


        public Cell[,] Cells {get; private set;}
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
        public void Occupy(int x, int y)
        {
            if (x >= 1 && y >= 1 && x <= SizeX && y <= SizeY)
            {
                if (Cells[x - 1, y - 1].Type == CellType.empty)
                    Cells[x - 1, y - 1].Type = CellType.ship;
                else
                    throw new Exception("Cell is already occupied");
            }
            else
                throw new Exception("Invalid options (out of bounds)");
        }
    }
}