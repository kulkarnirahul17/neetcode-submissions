public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        // First calculate the max value of bananas
        int max = 0;
        for (int i =0; i < piles.Length; i++) {
            max = Math.Max(piles[i], max);
        }

        int low = 1, high = max;
        while(low <= high) {
            int mid = low + (high - low) / 2;
            // Calculate hours required at mid speed
            int totalHours = 0;
            for(int i = 0; i < piles.Length; i++) {
               totalHours += (int)Math.Ceiling((double)piles[i] / mid);
            }
            if(totalHours > h) 
            {
                // This means we are slow and need faster speed
                low = mid + 1;
            }
            else
            {
                // need to find the lowest in the lower half
                high = mid - 1;
            }
        }
        return low;
    }
}
