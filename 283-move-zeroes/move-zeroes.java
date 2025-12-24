class Solution {
    public void moveZeroes(int[] nums) {

        int i = 0;        // okuyan index
        int write = 0;    // yazan index

        // 1) Diziyi gez, 0 olmayanları başa yaz
        while (i < nums.length) {
            if (nums[i] != 0) {
                nums[write] = nums[i];
                write++;
            }
            i++;
        }

        // 2) Sona kalan yerleri 0 yap
        while (write < nums.length) {
            nums[write] = 0;
            write++;
        }
    }
}
