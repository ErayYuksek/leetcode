class Solution {
    public boolean increasingTriplet(int[] nums) {
        long first = Long.MAX_VALUE;
        long second = Long.MAX_VALUE;

        for (int x : nums) {
            if (x <= first) {
                first = x;
            } else if (x <= second) {
                second = x;
            } else {
                return true;
            }
        }

        return false;
    }
}
