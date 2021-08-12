/*******************************************************************************

<summary>
Author: Peter Welter
Date: 8/11/2021
Project: Union of two arrays
Description: A union is the joining of two seperate sets. Any common elements
             from another set are not joined and only elements that are uniqe
             to the set that is joining another set is added.
</summary>

*******************************************************************************/



using System.IO;
using System;
using System.Collections.Generic; 

class Solution
{
    public void unionOfTwoArrays(int []a, int []b, int lengthOfA, int lengthOfB)
    {
        //Declare variables
        HashSet<int> union = new HashSet<int>();
        int i;
        
        //Loop to add array a to a HashSet
        for(i = 0; i < lengthOfA; i++)
        {
            union.Add(a[i]);
        }
        
        //Check to see if anytihng in array b in unique only to array b.
        for(i = 0; i < lengthOfB; i++)
        {
            //If the HashSet contains a value that is found in b then 
            //we don't add to the hash set.
            if(union.Contains(b[i]) == false)
            {
                union.Add(b[i]);
            }
        }
        
        foreach(int u in union) 
        {  
            Console.WriteLine(u);  
        }  
       
        
        
    }
}
class Program
{
    static void Main()
    {
        int []a = new int[]{};
        int []b = new int[]{};
        int lengthOfA = a.Length;
        int lengthOfB = b.Length;
        
        Solution s = new Solution();
        
        s.unionOfTwoArrays(a, b, lengthOfA, lengthOfB);
    }
}