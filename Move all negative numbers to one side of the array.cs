/***************************************************************************

Author: Peter Welter
Date: 8/10/2021
Project: Move all negative numbers to one side of the array 

***************************************************************************/


using System.IO;
using System;

class Solution
{
    
    public int [] moveNegativeNumbersInArray(int [] unsortedArr, int length)
    {
        //Declare variables 
        int []tmp = new int [length];
        int i;
        int j = 0;
        
        //Loop to move all positve numbers to one side of the array
        for(i = 0; i < length; i++)
        {
            if(unsortedArr[i] > 0)
            {
                tmp[j++] = unsortedArr[i];
            }
        }
        
        //Check to see if any postive numbers were found in the loop.
        //if not then we can return the tmp array since the negative
        //numbers are already on one side.
        if(tmp == null || tmp.Length == 0)
            return tmp;
            
        //Loop to move all negative numbers to one side of the array
        for(i = 0; i < length; i++)
        {
            if(unsortedArr[i] < 0)
            {
                tmp[j++] = unsortedArr[i];
            }
        }
        
        return tmp;
    }
    

}

class Program
{
    static void Main()
    {
        //Declare variables
        int []unsortedArr = new int []{1, -1, 3, 2, -7, -5, 11, 6};
        int length = unsortedArr.Length;
        int i;
        
        Solution s = new Solution();
        
        unsortedArr = s.moveNegativeNumbersInArray(unsortedArr, length);
        
        for(i = 0; i < length; i++)
        {
            Console.WriteLine(unsortedArr[i]);
        }
        
    }
}