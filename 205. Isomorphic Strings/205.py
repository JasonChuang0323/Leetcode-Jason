# Given two strings s and t, determine if they are isomorphic.

# Two strings are isomorphic if the characters in s can be replaced to get t.

# All occurrences of a character must be replaced with another character while preserving the order of characters. No two characters may map to the same character but a character may map to itself.

# Example 1:

# Input: s = "egg", t = "add"
# Output: true
# Example 2:

# Input: s = "foo", t = "bar"
# Output: false
# Example 3:

# Input: s = "paper", t = "title"
# Output: true


判断出现的位置，然后存在字典里。




class Solution:
    def isIsomorphic(self, s: str, t: str) -> bool:
        sDic, tDic = {}, {}
        if(len(s) != len(t)): 
            return false
        
        for i in range(len(s)):
            if s[i] not in sDic:
                sDic[s[i]] = [i]
            else:
                sDic[s[i]] += [i]
            if t[i] not in tDic:
                tDic[t[i]] = [i]
            else:
                tDic[t[i]]+=[i]
        return sorted(sDic.values()) == sorted(tDic.values())



coooool!!
// solution 2 更好的方法
如果 s对应的字母不是t 或者 t已经对应到别的字母，都是false

class Solution:
    def isIsomorphic(self, s: str, t: str) -> bool:
        d = {}
        for i in range(len(s)):
            if (s[i] not in d and t[i] not in d.values()):
                d[s[i]] = t[i]
            //如果 s对应的字母不是t 或者 t已经对应到别的字母，都是false
            if (s[i] in d and d[s[i]] != t[i] ):
                return False
            if (s[i] not in d and t[i] in d.values()):
                return False
            
        return True
                