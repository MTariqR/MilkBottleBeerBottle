﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MilkBottleBeerBottle
{
    internal class MilkSong
    {
        public static string Beer() 
        {
            int amount = 99;
            string bottles = "bottles";
            while (amount > 0)
            {
                if (amount == 1)
                {
                    bottles = "bottle";
                    Console.WriteLine($"{amount} {bottles} of beer on the wall, {amount} {bottles} of beer.");
                    break;
                }
                Console.WriteLine($"{amount} {bottles} of beer on the wall, {amount} {bottles}  of beer.");
                if (amount - 1 == 1)
                {
                    bottles = "bottle";
                    Console.WriteLine($"Take one down and pass it around, {amount - 1} {bottles} of beer on the wall.\n");
                }
                else
                    Console.WriteLine($"Take one down and pass it around, {amount - 1} {bottles} of beer on the wall.\n");
                amount--;
            }
            return "";
        }
    }
}
