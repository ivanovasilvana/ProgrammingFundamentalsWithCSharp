﻿using System;

namespace _02PrintNumbersInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] num = new int[n];
            for (int i = 0; i < n; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }
            for (int i = num.Length - 1; i >= 0; i--)
            {
                Console.Write(num[i] + " ");
            }
        }
    }
}
