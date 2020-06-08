using System;
using System.Collections.Generic;

namespace Iron_Ninja.Models
{
    public class Buffet
    {
        public List<IConsumable> Menu;
        public static Random rand = new Random();
        
        public Buffet()
        {
            Menu = new List<IConsumable>()
            {
                new Food("Pizza", 200, false, false),
                new Food("Hamburger", 600, false, true),
                new Food("Drunken Noodle", 550, true, false),
                new Drink("Coke", 100, false, true),
                new Food("Fish & Chips", 800, false, false),
                new Drink("Sprite", 100, false, true),
                new Food("Ice Cream", 250, false, true),
            };
          
            
        }
     
        public IConsumable Serve()
        {
            Random rand = new Random();
            return Menu[rand.Next(Menu.Count)];
        }
    }
}