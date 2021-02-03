//Two Sum
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int num = nums[i];
            int comp = target - num;
            
            if (dict.TryGetValue(comp, out int index))
            {
                return new int[] {i,index};
            }

            dict[num] = i;
        }
        return null;
    }
}