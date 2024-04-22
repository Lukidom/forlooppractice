

    public class Program
    // program class is the base class for the program
    {
        public static void Main(string[] args)
        {
            // new list and instance

            // For loop iterates through and creates five instances of item which is added to the list ItemLi than printed with a foreach loop
            for (int i = 0; i < 5; i++)
                {
                    List<Item> ItemLi= new List<Item>();
                    Item item = new Item(50);
                    ItemLi.Add(item);

                    foreach (Item thing in ItemLi)
                    {
                        Console.WriteLine(thing.ToString());
                    }

                };

            for (int i = 0; i < 5; i++)
            {
                List<string> StringList= new List<string>();
                StringList.Add("Hello World");
                StringList.Add("I am a string."); 

                foreach (string str in StringList)
                {
                    Console.WriteLine();
                }
            }


            
        }




    }







