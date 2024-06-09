public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length == 0)
        return 0;

        if(nums.Length == 1)
        return 1;

    int Counter = 0;
    for (short i = 0; i < nums.Length - 1; i++) {
        if (nums[i] != nums[i + 1])
        {
            nums[Counter] = nums[i];
            Counter++;
        }
    }
        nums[Counter] = nums[nums.Length - 1];
        Counter++;
    return Counter;
    }
}