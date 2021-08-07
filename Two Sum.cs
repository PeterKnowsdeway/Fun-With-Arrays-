/*************************************************

Author: Peter Welter
Date:8/6/2021
Project: Two Sum
Problem Description(

Given an array of integers nums and an integer target, 

return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.)

*************************************************/

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        //Declare Variables
        var i = 0;
        var complement = 0;
        var numbers = new Dictionary<int, int>();
        
        for(i = 0; i < nums.Length; i++)
        {
			//take the complement of the target numbers and value in array.
			//If that value is found in the dictionary then save the index of the complements location.
			//Return the index of complement and the ith iteration if found.
			//If a complement is not found and the value from the array
			//is not in the dictionary then add the value from the array and the ith iteration.
			
            complement = target - nums[i];
            var index = 0;
            if(numbers.TryGetValue(complement, out index))
            {
                return new int[] {index, i};
            }
        
            if(numbers.ContainsKey(nums[i]) == false)
            {
                numbers.Add(nums[i], i);
            }
        }
        
        return null;
        
    }
}