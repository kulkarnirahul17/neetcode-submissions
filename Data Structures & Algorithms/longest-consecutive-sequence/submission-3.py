class Solution:
    def longestConsecutive(self, nums: List[int]) -> int:
        if len(nums) == 0:
            return 0
        
        nums_set = set(nums)

        maximum = 1

        for i in range(len(nums)):
           curr_num = nums[i]
           # This is the beginning of a set
           if curr_num - 1 not in nums_set:
                curr_len = 1
                # while curr_num+1 in set increase curr_num, curr_len, update maximum
                while curr_num + 1 in nums_set:
                    curr_len = curr_len + 1
                    curr_num = curr_num + 1
                maximum = max(curr_len, maximum)
        return maximum