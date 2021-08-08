/********************************************

Author: Peter Welter
Date: 8/7/2021
Project: Reverse given string

********************************************/

using System.IO;
using System;

class Solution
{
    public char [] reverseString(string s, int n)
    {
        
        //Declare variables
        int i;
        int count = 0;
        char []revString = new char[n];
        
		//Loop through string starting at the end of the string (length - 1) and 
		//iterate to the beggining(0). Have another variable called count iterate from 0
		//to the end of the string length to save each characters spot in reverse
        for(i = s.Length - 1; i >= 0; i--, count++)
        {
            revString[count] = s[i];
        }
		
        return revString;
		
    }//End of reverseString method
        
}//End of Solution class

class Program
{
    public static void Main()
    {
        string s = "Geeks";
        int n = s.Length;
        char []tmp = new char[n];
    
        Solution S = new Solution();
        
        tmp = S.reverseString(s, n);
        
        s = string.Join(" ", tmp);
        
        Console.WriteLine(s);
		
    }//end of main method
}//Emd of file