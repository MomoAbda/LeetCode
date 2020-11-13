using System.Collections;


namespace LeetCode.Problem
{
    //https://leetcode.com/problems/two-sum/
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {

            Hashtable hashTable = new Hashtable();

            for (int i = 0; i < nums.Length; i++)
            {
                if (hashTable.ContainsKey(nums[i]))
                {
                    hashTable[nums[i]] = i;
                }
                else
                {
                    hashTable.Add(nums[i], i);

                }

            }


            for (int j = 0; j < nums.Length; j++)
            {

                int resteToAdd = target - nums[j];
                if (hashTable.ContainsKey(resteToAdd) && j != (int)hashTable[resteToAdd])
                {

                    return new int[] { j, (int)hashTable[resteToAdd] };
                }


            }



            return null;


        }


    }
}
