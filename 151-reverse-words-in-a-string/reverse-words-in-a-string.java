class Solution {
    public String reverseWords(String s) {

        // String'i kelimelere ayır
        String[] words = s.trim().split("\\s+");

        // Sonucu birleştirmek için
        StringBuilder sb = new StringBuilder();

        //  Kelimeleri sondan başa doğru gez
        for (int i = words.length - 1; i >= 0; i--) {

            sb.append(words[i]); // kelimeyi ekle

            //  Son kelime değilse boşluk ekle
            if (i != 0) {
                sb.append(" ");
            }
        }

        //  StringBuilder → String
        return sb.toString();
    }
}
