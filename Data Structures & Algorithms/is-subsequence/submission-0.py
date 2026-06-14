class Solution:
    def isSubsequence(self, s: str, t: str) -> bool:
        if len(s) > len(t):
            return False
        s_ind, match = 0,0
        for i in range(len(t)):
            if s_ind < len(s) and t[i] == s[s_ind]:                
                match = match + 1
                s_ind = s_ind + 1
        
        return match == len(s)

