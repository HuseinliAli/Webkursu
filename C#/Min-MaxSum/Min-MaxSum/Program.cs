using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        long min = long.MaxValue;
        long max = int.MinValue;
        long sum = 0;
        long sumMin = 0;
        long sumMax = 0;
        for (int i = 0; i < arr.Count; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        for (int i = 0;i < arr.Count; i++)
        {
            if(arr[i] < min)
            {
                min = arr[i];
            }
        }
        for(int i = 0; i<arr.Count; i++)
        {
            sum+=arr[i];
        }
        sumMax=sum-min;
        sumMin=sum-max;
        Console.WriteLine(sumMin+" "+sumMax);
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);

        Console.ReadKey();
    }
}
