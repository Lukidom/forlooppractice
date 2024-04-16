using system 
using System.Collections.Generic;

using System.IO;

namespace forLoop

{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Item> ItemLi= new list<Item>;
            Item item = new Item(50);
            ItemLi.Add(item);
            

            foreach (Item item in ItemLi)
            {
                Console.WriteLine(item.ToString());
            }
        }

    }





}


