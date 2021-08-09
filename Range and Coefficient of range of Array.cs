/******************************************************

Author: Peter Welter
Date: 8/9/2021
Project: Range and Coefficient of range of Array
Description: 

Given an array arr of integer elements, the task is to find
the range and coefficient of range of the given array where: 

Range: Difference between the maximum value and the minimum value in the distribution. 
Coefficient of Range: (Max – Min) / (Max + Min).

******************************************************/

using System.IO;
using System;

class Solution
{
    
    public void findPrintRange(float max, float min)
    {
        //Declare variables 
        float range = 0;
        
        range = (max - min);
        
        Console.WriteLine(range);
        
        coefficientOfRange(max, min);
    }
    
    public void coefficientOfRange(float max, float min)
    {
        float coefOfRange = 0;
        
        coefOfRange = (max - min)/(max + min);
        
        Console.WriteLine(coefOfRange);
    }
}

class Program
{
    static void Main()
    {
        //Declare variables
        int []arr = new int[]{15, 16, 10, 9, 6, 7, 17};
        int length = arr.Length;
        float max = 0;
        float min = 0;
        
        Solution s = new Solution();
        
        //By sorting the array in asscending order the max value is at
        //the tail and the min value is at the head of the array
        Array.Sort(arr);
        
        //Grab the max value at the tail end. I'm using length here to get
        //this value as it will always have the tail index. For min we can
        //simply use the starting index to grab the value.
        max = arr[length - 1];
        min = arr[0];
        
        //Call the method to find the range and coefficent of the range
        s.findPrintRange(max, min);
        
    }
}