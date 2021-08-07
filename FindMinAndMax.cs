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
        
        for(i = 1; i < n; i++)
        {
            if(temp < arr[i])
            {
                temp = arr[i];
                max = temp;
            }
            
        }
        
        for(i = 1; i < n; i++)
        {
            if(temp > arr[i])
            {
                temp = arr[i];
                min = temp;
            }
            
        }
        
        return new int [] {max,min};
    }
}
class Program
{
    static void Main()
    {
        //Declare varaibles
        int []arr = new int [3, 2, 1, 56, 10000, 167];
        int n = arr.Length;
        
        arr = findMinMax(arr, n);
        
        Console.WriteLine("Hello, World!");
    }
}