// 7. Reverse Integer
// Easy

// 2140

// 3240

// Favorite

// Share
// Given a 32-bit signed integer, reverse digits of an integer.

// Example 1:

// Input: 123
// Output: 321
// Example 2:

// Input: -123
// Output: -321
// Example 3:

// Input: 120
// Output: 21

// 比较简单


public class Solution {
    public int Reverse(int x) {
        long re = 0;
        bool flag = true;
        if(x < 0){
            x *= -1;
            flag = false;
        }
            
        
        while(x > 0){
            int temp = x % 10;
            re*=10;
            re+= temp;
            x /= 10;
            if(re > int.MaxValue) return 0;
        }
        return (int)(flag ? re : -re);
    }
}