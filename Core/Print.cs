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
    }
}