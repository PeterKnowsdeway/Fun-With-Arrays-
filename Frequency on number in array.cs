/********************************************

Author: Peter Welter
Date: 8/8/2021
Project: Find and print the frequency of an integer in an array

********************************************/

using System.IO;
using System;

class Solution
{
    public int findFrequency(int []arr, int length, int x)
    {
        //Declare variables
        int i;
        int count = 0;

        for(i = 0; i < length; i++)
        {
            if(arr[i] == x)
            {
                count++;
            }
        }
        
        return count;
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
        
        x = s.findFrequency(arr, length, x);
        
        Console.WriteLine(x);
        
        Console.WriteLine("Hello, World!");
    }
}