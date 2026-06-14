class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        map = {}
        for word in strs:
            freq = [0] * 26
            for c in word:
                index = ord(c) - ord('a')
                freq[index] = freq[index] + 1
            key = "".join([f"{chr(ord('a') + ind)}{cnt}" for ind, cnt in enumerate(freq)])
            map.setdefault(key, []).append(word)
        return list(map.values())
