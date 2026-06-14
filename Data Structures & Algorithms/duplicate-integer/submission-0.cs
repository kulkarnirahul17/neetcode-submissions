public class Solution {
    public bool hasDuplicate(int[] nums) {
        // Using hashset

        HashSet<int> hash = new();

        foreach(int number in nums) {
            if(hash.Contains(number)) {
                return true;
            }        
            hash.Add(number);    
        }
        return false;
    }
}
