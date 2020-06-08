using System;
using Iron_Ninja.Models;

namespace Iron_Ninja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet menu = new Buffet();
            SweetTooth sweet = new SweetTooth();
            SpiceHound spice = new SpiceHound();
            while (!sweet.IsFull)
            {
                sweet.Consume(menu.Serve());
            }
            if (sweet.IsFull)
            {
                sweet.Consume(menu.Serve());
            }
            Console.WriteLine("================================================================");
            while (!spice.IsFull)
            {
                spice.Consume(menu.Serve());
            }
            if (spice.IsFull)
            {
                spice.Consume(menu.Serve());
            }
            Console.WriteLine("================================================================");
            if(sweet.ConsumptionHistory.Count > spice.ConsumptionHistory.Count)
            {
                Console.WriteLine($"Ninja had {sweet.ConsumptionHistory.Count} items of SweetTooth!");
            }
            else
            {
                Console.WriteLine($"Ninja had {spice.ConsumptionHistory.Count} items of SpiceHound!");
            }
        }
    }
}
