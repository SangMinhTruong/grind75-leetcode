/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public bool IsBalanced(TreeNode root) {
        if (root == null) {
            return true;
        }

        var heightDiff = TreeHeight(root.left) - TreeHeight(root.right);
        return heightDiff >= -1 && heightDiff <= 1 
            && IsBalanced(root.left) && IsBalanced(root.right);
    }

    public int TreeHeight(TreeNode root) {
        if (root == null) {
            return 0;
        }

        var leftHeight = TreeHeight(root.left);
        var rightHeight = TreeHeight(root.right);

        return leftHeight >= rightHeight ? leftHeight + 1 : rightHeight + 1; 
    }
}