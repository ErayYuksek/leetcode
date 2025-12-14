public class Solution {
    public string ReverseVowels(string s) {
        

        // Sesli harfleri tutacagımız kutu

        List<char> vowels=new List<char>();

        //Sesli harf kontrolu 

       bool IsVowel(char c)
        {
            return "aeiouAEIOU".Contains(c);
        }

        // Tüm sesli harfleri kutuya at

        foreach (char c in s)
        {
            if (IsVowel(c))
                vowels.Add(c);
        }

        char[] arr = s.ToCharArray();

            int index = vowels.Count - 1;
            
       //  Seslileri tersten geri koy

        for (int i = 0; i < arr.Length; i++)
        {
            if (IsVowel(arr[i]))
            {
                arr[i] = vowels[index];
                index--;
            }
        }

        //  Yeni string'i döndür
        return new string(arr);


    }
}