Given a binary search tree (BST), find the lowest common ancestor (LCA) of two given nodes in the BST.

According to the definition of LCA on Wikipedia: “The lowest common ancestor is defined between two nodes p and q as the lowest node in T that has both p and q as descendants (where we allow a node to be a descendant of itself).”

Given binary search tree:  root = [6,2,8,0,4,7,9,null,null,3,5]



// 利用search binary tree 的特性， 如果都小于当前root一定在左边
// 大于的话 都在右边
// 如果一大一小，肯定在2边，这时候 当前root就是答案.
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
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if (root == null) return null;
        
        if (p.val > root.val && q.val > root.val)  return LowestCommonAncestor(root.right, p, q);
        if (p.val < root.val && q.val < root.val) return LowestCommonAncestor(root.left, p, q);
        // 下面这个判断可以不写，但是写出来更好理解.
        if ((p.val < root.val && q.val > root.val) || (p.val > root.val && q.val < root.val) ) return root;
        
        return root;
    }
}