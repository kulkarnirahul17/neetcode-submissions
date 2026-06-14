class Solution:
    def longestConsecutive(self, nums: List[int]) -> int:
        if len(nums) == 0:
            return 0
        
        nums = sorted(nums)

        curr_len, maximum = 0,1

        for i in range(len(nums)):
            curr, curr_len = nums[i], 1
            for j in range(i+1, len(nums)):
                if nums[j] == curr + 1:
                    curr = curr + 1
                    curr_len = curr_len + 1
                maximum = max(curr_len, maximum)
        return maximum