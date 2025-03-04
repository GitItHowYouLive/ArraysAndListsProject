﻿using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            var nums = new int[10];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i+1;
            }

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            var evens = new List<int>();
            var odds = new List<int>();

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */
            foreach(int i in nums)
            {
                if (i%2 == 0)
                {
                    evens.Add(i);
                }
                else
                {
                    odds.Add(i);
                }
            }

            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */

            foreach(int i in evens)
            {
                Console.WriteLine(i);
            }

            foreach(var i in odds)
            {
                Console.WriteLine(i);
            }
        }
    }
}
