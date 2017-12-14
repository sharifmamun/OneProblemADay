public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        return Subsets(nums, 0);
    }

    public IList<IList<int>> Subsets(int[] nums, int index) {
        IList<IList<int>> allSubSets = new List<IList<int>>();
        if (nums.Length == index) {
            IList<int> subSet = new List<int>();
            allSubSets.Add(subSet);
        } else {
            allSubSets = Subsets(nums, index + 1);
            int item = nums[index];

            IList<IList<int>> moreSubsets = new List<IList<int>>();
            foreach(var subSet in allSubSets) {
                IList<int> s = new List<int>();
                //s.AddRange(subSet);
                ((List<int>)s).AddRange(subSet);
                s.Add(item);
                moreSubsets.Add(s);
            }

            //allSubSets.Add(moreSubsets);
            allSubSets.AddRange(moreSubsets);
        }

        return allSubSets;
    }
}