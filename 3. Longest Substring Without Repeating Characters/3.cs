// Given a string, find the length of the longest substring without repeating characters.

// Example 1:

// Input: "abcabcbb"
// Output: 3 
// Explanation: The answer is "abc", with the length of 3. 
// Example 2:

// Input: "bbbbb"
// Output: 1
// Explanation: The answer is "b", with the length of 1.
// Example 3:

// Input: "pwwkew"
// Output: 3
// Explanation: The answer is "wke", with the length of 3. 
//              Note that the answer must be a substring, "pwke" is a subsequence and not a substring.

// 移动窗口，然后在ferq的list里找是否有存在，有存在则l++，不然就r++继续加长，找到最长的那串



public class Solution {
    public int LengthOfLongestSubstring(string s) {
          int[] freq = new int[256];
        // c# 设置好长度后，每个默认位0
        
        int l = 0, r = -1;
        int length = 0;
        
        while(l < s.Length){
            if (r+1 < s.Length && freq[s[r+1]] == 0){
                r++;
                freq[s[r]]++;
            }else{
                freq[s[l]]--;
                l++;
            }
            length = Math.Max(length, r-l+1);
        }
        
        return length;
        
    }
}