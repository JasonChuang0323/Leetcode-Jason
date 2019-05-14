
// Given a binary tree, return the level order traversal of its nodes' values. (ie, from left to right, level by level).

// For example:
// Given binary tree [3,9,20,null,null,15,7],

//     3
//    / \
//   9  20
//     /  \
//    15   7
// return its level order traversal as:

// [
//   [3],
//   [9,20],
//   [15,7]
// ]

// 利用队列，进行遍历
// List 是一个类 而IList 是一个借口
//使用IList <Class1> IList11 =new List <Class1>(); 
// 方便后期的修改，当你不在使用List 要使用其他类型的时候 
// 只需要修改这一处地方就可以了 
// 不用修改过多的 地方 




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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        var re = new List<IList<int>>();
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
        
        return re;
        
        
    }
}