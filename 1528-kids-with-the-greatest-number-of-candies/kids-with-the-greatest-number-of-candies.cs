public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) 
    {
        // 1) Dizideki en büyük şeker sayısını bul
        int max = 0;
        foreach (int c in candies)
        {
            if (c > max)
                max = c;
        }

        // 2) Sonuçları tutmak için bir liste oluştur
        List<bool> result = new List<bool>();

        // 3) Her çocuk için kontrol et
        foreach (int c in candies)
        {
            int newAmount = c + extraCandies; // Bu çocuğa tüm extraCandies'i verirsek

            if (newAmount >= max)
                result.Add(true);  // En çok şekere sahip olabilir
            else
                result.Add(false); // Yine de en çok olamıyor
        }

        // 4) Sonuç listesini geri döndür
        return result;
    }
}
