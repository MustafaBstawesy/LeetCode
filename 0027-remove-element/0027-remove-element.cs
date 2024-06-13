public class Solution {
    public int RemoveElement(int[] nums, int val) {
       
    if (nums.Length == 0)
      return 0;

   short counter = 0;
   for (short i = 0; i < nums.Length; i++)
   {
       if (nums[i] != val)
       {
           nums[counter] = nums[i];
           counter++;
       }
   }
   return counter;
    }
}