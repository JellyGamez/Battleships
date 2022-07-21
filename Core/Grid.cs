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
            for (int i = 0; i < SizeX; i++, Console.Write("\n"))
                for (int j = 0; j < SizeY; j++)
                {
                    Console.Write(Cells[i, j] + " ");
                }
        }
    }
}