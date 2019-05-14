public class Solution {
    public IList<string> LetterCombinations(string digits) {
        
        var re = new List<string>();
        Helper(digits, 0, "", re);
        
        return re;
       
    }
    private static string[] arr = new[]{
            " ",
            "",
            "abc",
            "def",
            "ghi",
            "jkl",
            "mno",
            "pqrs",
            "tuv",
            "wxyz"
        };

    // 利用递归，让Index每次+1，一直到字母的长度，然后可以得到不同的结果。
    private List<string> Helper (string digits, int index, string cur, List<string> re){
        if (digits.Length == 0) return re;
        if (index == digits.Length){
            re.Add(cur);
            return re;
        }
        char c = digits[index];  // 哪个数字
        string letters = arr[c - '0'];
        
        for(int i = 0; i < letters.Length; i++)
            Helper(digits, index + 1, cur+ letters[i], re);
        
        return re;
    }
}