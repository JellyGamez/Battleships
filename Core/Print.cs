namespace Core
{
    class Print
    {

        public static int GetIntegerInput(string message)
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
            string row = " ", column = " ";
            do
            {
                Console.Write("Enter row and column separated by space: ");
                try
                {
                    var input = Console.ReadLine();
                    string[] coordinates = input.Trim().Split(" ");
                    row = coordinates[0];
                    column = coordinates[1];
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
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid input");
                }
            } while (invalid);
            return new KeyValuePair<int, int>(x, y);
        }
    }
}