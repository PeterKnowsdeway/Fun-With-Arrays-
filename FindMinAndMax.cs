/********************************************

Author: Peter Welter
Date: 8/7/2021
Project: Find the maximum and minimum values in an array

********************************************/

using System.IO;
using System;

class Solution
{
    public int [] findMinMax(int []arr, int n)
    {
        //Declare variables
        int i;
        int min = 0; 
        int max = 0;
        int temp = arr[0];
        int []tmp = new int[2];
        
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
        
        tmp[0] = max;
        tmp[1] = min;
       
        return tmp;
        
    }//end of findMinMax
}//end of class

class Program
{
    public static void Main()
    {
        //Declare varaibles
        int i;
        int []arr = new int []{3, 2, 1, 56, 10000, 167};
        int n = arr.Length;
        
        Solution s = new Solution();
        
        arr = s.findMinMax(arr, n);
        
        for(i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
        
    }
}