/********************************************

Author: Peter Welter
Date: 8/7/2021
Project: Find the maximum and minimum values in an array

********************************************/

using System.IO;
using System;

class Solution
{
    public int findMinMax(int []arr, int n)
    {
        //Declare variables
        int i;
        int min, max;
        int temp = arr[0];
        
        //Loop to find the largest element in the array.
        //Have temp be the first element in the array
        //then check to see if the next element in the array
        //starting at one is bigger than temp. If temp is 
        //smaller then we set temp to the ith index in the array.
        for(i = 1; i < n; i++)
        {
            if(temp < arr[i])
            {
                temp = arr[i];
                max = temp;
            }
            
        }//end of loop
        
        //Loop to find the smallest element in the array.
        //Have temp be the first element in the array
        //then check to see if the next element in the array
        //starting at one is smaller than temp. If temp is 
        //larger then we set temp to the ith index in the array.
        for(i = 1; i < n; i++)
        {
            if(temp > arr[i])
            {
                temp = arr[i];
                min = temp;
            }
            
        }//end of loop
        
        return new int [] {max,min};
        
    }//end of findMinMax
}//end of class
class Program
{
    static void Main()
    {
        //Declare varaibles
        int i;
        int []arr = new int [3, 2, 1, 56, 10000, 167];
        int n = arr.Length;
        
        arr = findMinMax(arr, n);
        
        for(i = 0; i < n; i++)
        {
            Console.WriteLine(arr[i]);
        }
        
    }
}