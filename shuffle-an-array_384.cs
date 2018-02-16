public class Solution {

    int[] array;
    int[] original;

    public Solution(int[] nums) {
        array = nums;
        original = (int[])nums.Clone();
    }

    /** Resets the array to its original configuration and return it. */
    public int[] Reset() {
        array = original;
        original = (int[])original.Clone();
        return original;
    }

    /** Returns a random shuffling of the array. */
    public int[] Shuffle() {
        for(int i=0; i<array.Length; i++)
        {
            int k = rand(0, i);
            int temp = array[k];
            array[k] = array[i];
            array[i] = temp;
        }

        return array;
    }

    private int rand(int lower, int higher) {
        Random r = new Random();
        return lower + (int)(r.Next(higher-lower+1));
    }
}
