// Easy

// 833

// 65

// Favorite

// Share
// Given a binary tree, return all root-to-leaf paths.

// Note: A leaf is a node with no children.

// Example:

// Input:

//    1
//  /   \
// 2     3
//  \
//   5

// Output: ["1->2->5", "1->3"]

// Explanation: All root-to-leaf paths are: 1->2->5, 1->3






//先找左，在找右，运用递归.



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
    public IList<string> BinaryTreePaths(TreeNode root) {
        var re = new List<string>();
        if (root == null) return re;
        Helper(root, re, "");
        return re;
    }
    
    private void Helper (TreeNode node, List<string> re, string cur){
        // to the leaf
        if (node.left ==null && node.right == null){
            cur += node.val;
            re.Add(cur);
        }
        
        if (node.left != null)  Helper (node.left, re, cur + node.val + "->" );
        if (node.right != null)  Helper (node.right, re, cur + node.val + "->" );


    }
}