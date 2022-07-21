namespace Core
{
    class Cell
    {
        public CellType Type {get; private set;}
        
        public Cell()
        {
            Type = CellType.empty;
        }

        public override string ToString()
        {
                switch (Type)
                {
                    default:
                    case CellType.empty:
                        return "*";
                    case CellType.hit:
                        return "@";
                    case CellType.miss:
                        return "x";
                }
        }
    }
}