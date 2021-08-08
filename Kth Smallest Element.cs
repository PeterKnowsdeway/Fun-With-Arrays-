/************************************************************

Author: Peter Welter
Date: 8/8/2021
Project: Kth smallest element
Description: Given an array arr[] and a number K where K is smaller 
than size of array, the task is to find the Kth smallest element 
in the given array. It is given that all array elements are distinct.

************************************************************/

using System.IO;
using System;

class Solution
{
    public int kThSmallestElement(int []arr, int n, int k)
    {
        //Declare Variables
        int i;
        int answer = 0;

        //Using the built in Sort method(Quick way to use quick sort)
        //will try and implement quicksort in a later project
        Array.Sort(arr);
        
        //Loop that will run one iteration. i starts at the tail of the array
        //and iterates down only to the previous element. 
        //Since we are assuming every element in the array is unique
        //we can take the length of the array and subtract it by
        //the kTh value (since the array is sorted by asec. 7 is the thrd
        //largest value in the array)
        
        for(i = n; i > n-1; i--)
        {
            answer = arr[i - k];
        }
        
        return answer;
        
    }
}

class Program
{
    static void Main()
    {
        //Declare variables
        int []arr = new int[]{7,10,4,3,0,15};
        int n = arr.Length;
        int k = 3;
        
        Solution s = new Solution();
        
        k = s.kThSmallestElement(arr, n, k);
        
        Console.WriteLine(k);
        
    }
}