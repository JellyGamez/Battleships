namespace Core 
{
    class Menu
    {
        public List<MenuItem> Items {get; private set;} = new List<MenuItem>();
        public string Name {get; private set;}

        public Menu(string name)
        {
            Name = name;
        }

        public Menu(string name, List<MenuItem> items)
        {
            Name = name;
            Items = items;
        }
        
        public override string ToString()
        {
            return Name;
        }

        public void Show(string label) 
        {
            Console.WriteLine(label);
            foreach (MenuItem item in Items)
            {
                Console.WriteLine(item);
            }
        }

        public string Choose()
        {
            string? UserOption;
            bool invalidOption = false;

            do {

                UserOption = Console.ReadLine();
                invalidOption = !IsValid(UserOption);
                
                if (invalidOption) 
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid option");
                }

            } while(invalidOption);

            return String.IsNullOrEmpty(UserOption) ? String.Empty : UserOption;
        }

        public bool IsValid(string? id)
        {
            if (String.IsNullOrEmpty(id))
                return false;
            foreach (MenuItem item in Items)
            {
                if (item.Id == id)
                    return true;
            }
            return false;
        }
    }
}