public class Solution {
    public int MaxProduct(int[] nums) {
     int maxProduct = int.MinValue;
        int leftProduct = 1, rightProduct =1;
        for(int i=0; i<nums.Length; i++)
        {
            leftProduct *= nums[i];
            rightProduct *= nums[nums.Length - 1 - i];
            maxProduct = Math.Max(maxProduct, Math.Max(leftProduct, rightProduct));
            leftProduct = leftProduct == 0 ? 1 : leftProduct;
            rightProduct = rightProduct == 0 ? 1 : rightProduct;
        }
        return maxProduct;
    }
}// chia 2 dau