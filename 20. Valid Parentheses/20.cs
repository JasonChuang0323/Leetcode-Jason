
// Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

// An input string is valid if:

// Open brackets must be closed by the same type of brackets.
// Open brackets must be closed in the correct order.
// Note that an empty string is also considered valid.

// Example 1:

// Input: "()"
// Output: true
// Example 2:

// Input: "()[]{}"
// Output: true
// Example 3:

// Input: "(]"
// Output: false

// 运用stack.




public class Solution {
    public bool IsValid(string s) {
        Stack <char> stack = new Stack <char>();
        for(int i = 0; i < s.Length; i++){
            if(s[i] == '(' || s[i] == '{' || s[i] == '['){
                stack.Push(s[i]);
            }else{
                if(stack.Count == 0) return false;
                char c = stack.Peek();
                stack.Pop();
                char target = ')';
                Console.WriteLine(s[i]);
                
                if(s[i] == ')')
                    target='(';
                if(s[i] == '}')
                    target='{';                
                if(s[i] == ']')
                    target='[';
                Console.WriteLine(target);
                if(c != target)
                    return false;
                
            }
        }
        return stack.Count == 0;
    }
}