public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        int k = 0; // val olmayan elemanları saymak için sayaç

        for (int i = 0; i < nums.Length; i++) // tüm diziyi dolaş
        {
            if (nums[i] != val) // eğer eleman silinecek değer değilse
            {
                nums[k] = nums[i]; // elemanı başa taşı
                k++;               // sayacı artır
            }
        }

        return k; // val olmayan elemanların sayısını döndür
    }
}
