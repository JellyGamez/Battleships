namespace Core
{
    class Print
    {

        public static int GetInput(string message)
        {
            Console.Write(message);
            var number = Console.ReadLine();
            return number == null ? 0 : Int32.Parse(number);
        }

        public static void PrintCurrentRound(int round)
        {
            Console.WriteLine($"Round #{round}\n");
        }

        public static KeyValuePair<int, int> GetValidCoordinates(Grid grid)
        {
            int x = 0, y = 0;
            bool invalid = true;
            do
            {
                Console.Write("Enter row and column separated by space: ");
                var input = Console.ReadLine();
                if (input == null)
                    continue;

                string[] coordinates = input.Trim().Split(" ");
                string row = coordinates[0], column = coordinates[1];

                try
                {
                    x = Int32.Parse(row);
                    y = Int32.Parse(column);
                    grid.ValidateCoordinates(x, y);
                    invalid = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (invalid);
            return new KeyValuePair<int, int>(x, y);
        }
    }
}