// Given a string, determine if it is a palindrome, considering only alphanumeric characters and ignoring cases.

// Note: For the purpose of this problem, we define empty string as valid palindrome.

// Example 1:

// Input: "A man, a plan, a canal: Panama"
// Output: true
// Example 2:

// Input: "race a car"
// Output: false

//设置头尾指针，只要是Palindrome的肯定是头尾对称，
//记住只算字母和数字
//api IsLetterOrDigit可以用来判断

public class Solution {
    public bool IsPalindrome(string s) {
        int l = 0;
        int r = s.Length - 1;
        s = s.ToUpper();
        while(l < r){
            if(!Char.IsLetterOrDigit(s[l])){
                l++;
                continue;
            }else if (!Char.IsLetterOrDigit(s[r])){
                r--;
                continue;
            }else if (s[l] != s[r]){
                Console.WriteLine(s[l]);
                Console.WriteLine(s[r]);
                return false;
            }
            l++;
            r--;
        }
        return true;
    }
}