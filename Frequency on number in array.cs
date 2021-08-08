/********************************************

Author: Peter Welter
Date: 8/8/2021
Project: Find and print the frequency of an integer in an array

********************************************/

using System.IO;
using System;

class Solution
{
    public int[] findFrequency(int []arr, int length, int x)
    {
        //Declare variables
        int i;
        
        //countArr is used to count each occurence of a number.
        //x is used to define the max value that it will find 
        //in a range (in this case 1).
        int []countArr = new int[x];
        //int count = 0;

        for(i = 0; i < length; i++)
        {
            countArr[arr[i]] += 1;
        }
        
        return countArr;
    }
}

class Program
{
    static void Main()
    {
        //Declare variables
        int []arr = new int []{1,1,1,1,1,1};
        int length = arr.Length;
        int x = 1;
        
        Solution s = new Solution();
        
        arr = s.findFrequency(arr, length, x);
        
        Console.WriteLine(arr[1]);
        
        Console.WriteLine("Hello, World!");
    }
}