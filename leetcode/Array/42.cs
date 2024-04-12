public class Solution {
    public int Trap(int[] height) {
        int l = 0, r = height.Length - 1, sum = 0,
        leftBar = height[l], rightBar = height[r];
        
        while (l < r) {

            if (leftBar <= rightBar) {
                sum += leftBar - height[l];
                l++;
                leftBar = Math.Max(leftBar, height[l]);
            } else {
                sum += rightBar - height[r];
                r--;
                rightBar = Math.Max(rightBar, height[r]);
            }

        }

        return sum;
    }
}