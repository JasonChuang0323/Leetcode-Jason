// You are given a binary tree in which each node contains an integer value.

// Find the number of paths that sum to a given value.

// The path does not need to start or end at the root or a leaf, but it must go downwards (traveling only from parent nodes to child nodes).

// The tree has no more than 1,000 nodes and the values are in the range -1,000,000 to 1,000,000.

// Example:

// root = [10,5,-3,3,2,null,11,3,-2,null,1], sum = 8

//       10
//      /  \
//     5   -3
//    / \    \
//   3   2   11
//  / \   \
// 3  -2   1

// Return 3. The paths that sum to 8 are:

// 1.  5 -> 3
// 2.  5 -> 2 -> 1
// 3. -3 -> 11



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
    public int PathSum(TreeNode root, int sum) {
        if (root == null) return 0;
        
        // 从root开始找
        int res = Helper (root, sum);
        //从root.left 开始找
        res += PathSum(root.left, sum);
        //从root.right 开始找
        res += PathSum(root.right, sum);
        
        return res;
    }
    
    private int Helper (TreeNode node, int sum){
        
        if (node == null) return 0;
        
        int res = 0;
        //这里不能立刻return,因为有负数，所以可能当前符合，后面还可以继续符合；
        if(node.val == sum)  res+=1;
        
        res += Helper(node.left, sum - node.val);
        res += Helper(node.right, sum - node.val);
        
        return res;
    }
}