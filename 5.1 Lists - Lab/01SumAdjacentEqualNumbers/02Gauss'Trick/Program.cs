﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _02Gauss_Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            int maxIndex = input.Count / 2;

            for (int i = 0; i < maxIndex; i++)
            {
                input[i] += input[input.Count - 1];
                input.RemoveAt(input.Count - 1);
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
