/********************************************

Author: Peter Welter
Date: 8/9/2021
Project: Sort an array of os, 1s and 2s

********************************************/

using System.IO;
using System;

class Solution
{
    //Method to find max value in the array 
    public int findMaxValueInArray(int []unsortedArray, int max, int length)
    {
        //Declare variables
        int temp = unsortedArray[0];
        int i;
        
        for(i = 0; i < length; i++)
        {
           if(temp < unsortedArray[i])
            {
                temp = unsortedArray[i];
                max = temp;
            } 
        }
        
        return max;
    }
    
    //Counter sort method 
    public int [] sortArr(int []unsortedArr, int length, int max)
    {
        //Declare variables
        int []sortedArr = new int [length];
        //Not sure why the counter array needs to initialized with the plus 3
        //as it was th eonly way I could get it to work without throwing an
        //index error.
        int []countArr = new int [max + 3];
        int sortPos = 0;
        int i;
        int j;
        
        sortedArr = unsortedArr;
        //Loop to count how many times each integers appear in the array
        for(i = 0; i < length; i++)
        {
            countArr[sortedArr[i]] += 1;
            //Console.WriteLine(countArr[i]);
        }
        
        //Fill the new array with the sorted numbers by each number position
        for(i = 0; i <= max; i++)
        {
            for(j = 0; j < countArr[i]; j++)
            {
                sortedArr[sortPos] = i;
                sortPos += 1;
            }
        }
        
        return sortedArr;
        
    }
    
    //Method to print the array
    public void printArr(int []sortedArr, int length)
    {
        int i;
        
        for(i = 0; i < length; i++)
        {
            Console.WriteLine(sortedArr[i]);
        }
    }
}

class Program
{
    static void Main()
    {
        //Declare variables
        int []unsortedArr = new int []{0,2,1,2,0,0,3,5,6,99};
        int length = unsortedArr.Length;
        int max = 0;
        
        Solution s = new Solution();
        
        max = s.findMaxValueInArray(unsortedArr, max, length);
        
        unsortedArr = s.sortArr(unsortedArr, length, max);
        
        s.printArr(unsortedArr, length);
        
    }
}