class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        map = {}
        for i, num in enumerate(nums):
            remainder = target - num
            if remainder in map:
                return [map[remainder], i]
            map[num] = i
        return []