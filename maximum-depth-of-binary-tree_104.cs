/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    // Height of a Tree
    public int MaxDepth(TreeNode root) {
        if (root == null)
            return 0;

        int leftHeight = MaxDepth(root.left) + 1;
        int rightHeight = MaxDepth(root.right) + 1;

        return Math.Max(leftHeight, rightHeight);
    }
}