﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.FriendlyTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            double distanceInKm = double.Parse(Console.ReadLine());
            double carCost = double.Parse(Console.ReadLine());
            double priceLiterOfFuel = double.Parse(Console.ReadLine());
            double moneyHave = double.Parse(Console.ReadLine());

            double car = (distanceInKm * carCost) / 100;
            double totalCost = car * priceLiterOfFuel;
            double left = moneyHave - totalCost;
            double need = moneyHave / 5;
            if (moneyHave >= totalCost)
            { 
                Console.WriteLine($"You can take a trip. {left:F2} money left.");
            }
            else 
            {
                Console.WriteLine($"Sorry, you cannot take a trip. Each will receive {need:F2} money.");
            }
        }
    }
}
