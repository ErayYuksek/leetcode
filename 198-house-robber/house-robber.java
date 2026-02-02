class Solution {
    public int rob(int[] nums) {
        int prev2 = 0; // iki ev önceye kadar en fazla para
        int prev1 = 0; // bir ev önceye kadar en fazla para

        for (int i = 0; i < nums.length; i++) {
            int current = Math.max(prev1, prev2 + nums[i]);
            prev2 = prev1;
            prev1 = current;
        }

        return prev1;
    }
}
