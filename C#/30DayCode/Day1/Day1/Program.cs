﻿using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    static void Main(String[] args)
    {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";
        // Declare second integer, double, and String variables.
        int ii, sumi;
        double dd, sumd;
        string ss, sums;
        // Read and save an integer, double, and String to your variables.
        ii=int.Parse(Console.ReadLine());
        dd=double.Parse(Console.ReadLine());
        ss=Console.ReadLine();
        // Print the sum of both integer variables on a new line.
        sumi=i+ii;
        Console.WriteLine(sumi);
        // Print the sum of the double variables on a new line.
        sumd=d+dd;
        Console.WriteLine($"{sumd:F1}");
        // Concatenate and print the String variables on a new line
        sums=s+ss;
        Console.WriteLine(sums);
        // The 's' variable above should be printed first.
    }
}