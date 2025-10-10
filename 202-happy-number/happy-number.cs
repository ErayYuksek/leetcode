public class Solution {
    public bool IsHappy(int n) {
        var seen = new HashSet<int>();
        // Daha önce gördüğümüz sayıları tutan küme; aynı sayıyı tekrar görürsek döngü vardır.

        while (n != 1 && !seen.Contains(n)) {
            // n, 1 olmadığı ve bu n'yi daha önce görmediğimiz sürece devam et.

            seen.Add(n);
            // Bu n'yi 'gördüm' diye işaretle (döngü kontrolü için).

            int next = 0;
            // Rakamların kareleri toplamını toplayacağımız değişken.

            while (n > 0) {
                // n'in tüm rakamlarını bitirene kadar dön.

                int digit = n % 10;
                // n'in son rakamını al.

                next += digit * digit;
                // O rakamın karesini toplama ekle.

                n /= 10;
                // Son rakamı sayıdan at; bir sonraki rakama geç.
            }

            n = next;
            // Bu turda oluşan toplam artık yeni n olur (bir sonraki tura bununla devam).
        }

        return n == 1;
        // Döngü 1'e ulaştığı için mi bitti? Evetse mutlu (true), değilse döngü yakalandı (false).
    }
}
