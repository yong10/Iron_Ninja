using System;

namespace Iron_Ninja.Models
{
    class SweetTooth : Ninja
    {
        // provide override for IsFull (Full at 1500 Calories)
        private int Limit = 1500;
        public override bool IsFull
        {
            get
            {
                return calorieIntake >= Limit;
            }
        }
        
        public override void Consume(IConsumable item)
        {
            // provide override for Consume
            if (!IsFull)
            {
                if(item.IsSweet)
                {
                    calorieIntake += 10;
                
                }
                calorieIntake += item.Calories;
                this.ConsumptionHistory.Add(item);
                Console.WriteLine(item.GetInfo());
            }
            else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("SweetTooth is full and cannot eat anymore!");
                Console.ResetColor();
            }
        }
    }
}