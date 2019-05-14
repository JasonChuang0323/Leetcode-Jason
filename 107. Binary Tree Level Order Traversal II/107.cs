// Given a binary tree, return the bottom-up level order traversal of its nodes' values. (ie, from left to right, level by level from leaf to root).

// For example:
// Given binary tree [3,9,20,null,null,15,7],

//     3
//    / \
//   9  20
//     /  \
//    15   7
// return its bottom-up level order traversal as:

// [
//   [15,7],
//   [9,20],
//   [3]
// ]


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
    public List<IList<int>> LevelOrderBottom(TreeNode root) {
        List<IList<int>> re = new List<IList<int>>();
        var queue = new Queue<TreeNode>();
        if(root== null) return re;
        
        queue.Enqueue(root);
        while(queue.Count > 0){
            int c = queue.Count;
            var list = new List<int>();
            for(int i = 0; i < c; i++){
                var node = queue.Dequeue();
                list.Add(node.val);
                if(node.left != null) queue.Enqueue(node.left);
                if(node.right != null) queue.Enqueue(node.right);
            }
            re.Add(list);
        }
        re.Reverse();
        return re;
        
        
    
    }
}