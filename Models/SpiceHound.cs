using System;

namespace Iron_Ninja.Models
{
    class SpiceHound : Ninja
    {
        // provide override for IsFull (Full at 1200 Calories)
         private int Limit = 1200;
        public override bool IsFull
        {
            get
            {
                return this.calorieIntake >= Limit;
            }
        }
        
        // provide override for Consume
        public override void Consume(IConsumable item)
        {
            if (!IsFull)
            {
                if(item.IsSpicy)
                {
                    calorieIntake -= 5;
                }
                calorieIntake += item.Calories;
                this.ConsumptionHistory.Add(item);
                Console.WriteLine(item.GetInfo());
            }
            else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("SpiceHound is full and cannot eat anymore!");
                Console.ResetColor();
            }
        }
    }
}