


public class Solution {
    public string AddBinary(string a, string b) {

	•	Solution adında bir sınıf tanımlanıyor.
	•	AddBinary adında bir metot var, parametre olarak ikilik sayıyı temsil eden iki string (a ve b) alıyor ve sonucunu string olarak döndürüyor.

⸻


        int i = a.Length - 1;
        int j = b.Length - 1;

	•	i, string a’nın son indeksini tutar.
	•	j, string b’nin son indeksini tutar.
👉 Bu, binary toplamayı en sağdaki (en düşük basamak) rakamdan başlatmak için yapılıyor.

⸻


        int carry = 0;

	•	carry taşımayı (eldeyi) temsil eder. Başlangıçta 0’dır.

⸻


        var result = new System.Text.StringBuilder();

	•	StringBuilder, sonucu verimli bir şekilde oluşturmak için kullanılır. (String concatenation daha yavaş olurdu.)

⸻


        while (i >= 0 || j >= 0 || carry > 0) {

	•	Döngü şu koşullardan biri sağlandığı sürece devam eder:
	•	i hâlâ a içinde geçerli bir indisi işaret ediyorsa,
	•	j hâlâ b içinde geçerli bir indisi işaret ediyorsa,
	•	veya elde (carry) sıfırdan farklıysa.

👉 Böylece her iki sayı da bitse bile elde varsa devam ediliyor.

⸻


            int sum = carry;

	•	Her adımda toplama işlemi carry ile başlatılır.

⸻


            if (i >= 0) sum += a[i--] - '0';
            if (j >= 0) sum += b[j--] - '0';

	•	Eğer i halen geçerliyse (a stringinden bir basamak varsa):
	•	a[i] karakteri alınır.
	•	'0' çıkarılarak sayıya çevrilir (örneğin '1' - '0' = 1).
	•	sum’a eklenir.
	•	i bir azaltılır (bir basamak sola kayılır).
	•	Aynı şey j için de yapılır (b stringi).

⸻


            result.Insert(0, (sum % 2).ToString());

	•	sum % 2, binary toplamda bulunduğumuz basamağın sonucu olur (0 veya 1).
	•	Bu değer stringe çevrilir ve Insert(0, ...) ile sonuca en başa eklenir.
👉 Çünkü toplama işlemi sağdan sola yapılırken StringBuilder sonucu soldan sağa kurmak zorunda.

⸻


            carry = sum / 2;

	•	sum / 2 işlemiyle yeni elde hesaplanır.
	•	Eğer sum 2 veya 3 olursa elde 1 olur.
	•	Eğer sum 0 veya 1 ise elde 0 olur.

⸻


        }

	•	Döngü biter.

⸻


        return result.ToString();
    }
}

	•	StringBuilder’ın sonucu stringe çevrilip döndürülür.

⸻

Örnek Çalışma

a = "1011"
b = "1101"

	•	Sağdan başlanır:
	•	1 + 1 = 2 → basamak: 0, elde: 1
	•	carry + 1 + 1 = 3 → basamak: 1, elde: 1
	•	carry + 0 + 1 = 2 → basamak: 0, elde: 1
	•	carry + 1 + 1 = 3 → basamak: 1, elde: 1
	•	elde 1 kaldı → basamak: 1

Sonuç: "11000"

⸻


