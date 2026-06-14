class Solution:
    def hasDuplicate(self, nums: List[int]) -> bool:
        s = sorted(nums)

        for i in range(1, len(s)):
            if s[i] == s[i-1]:
                return True        
        return False
        