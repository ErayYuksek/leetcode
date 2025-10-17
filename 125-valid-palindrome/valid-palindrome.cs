public class Solution {
    public bool IsPalindrome(string s) {
        string temiz = "";
        s = s.ToLower();

        foreach (char harf in s) {
            if (char.IsLetterOrDigit(harf)) {
                temiz += harf;
            }
        }

        string ters = new string(temiz.Reverse().ToArray());
        return temiz == ters;
    }
}
