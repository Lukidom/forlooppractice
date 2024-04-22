

using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

public class Program
    // program class is the base class for the program
    {
        public static void Main(string[] args)
        {
            function();
            
        }

        public static void function()
        {
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
                    Console.WriteLine(str);
                }
            }


        }
        
    }







