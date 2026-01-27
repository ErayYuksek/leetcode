class Solution {
    public boolean containsNearbyDuplicate(int[] nums, int k) {

        Map<Integer, Integer> lastIndex = new HashMap<>();

         for (int i = 0; i < nums.length; i++) {
            if (lastIndex.containsKey(nums[i])) {
                if (i - lastIndex.get(nums[i]) <= k) {
                    return true;
                }
            }
            // son görülen index'i güncelle
            lastIndex.put(nums[i], i);
        }
        return false;

    }
}