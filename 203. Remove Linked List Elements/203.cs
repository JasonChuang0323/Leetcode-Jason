
// 设置一个虚拟头指针，然后往下遍历，只要值相同，就跳过这个指针，直接
//指向下一个指针,这样就不用单独操作头结点。
// virtualnode -> 1 -> 2 -> 1- > 3
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode RemoveElements(ListNode head, int val) {
        ListNode virtualNode = new ListNode(0);
        virtualNode.next = head;
        ListNode cur = virtualNode;
        
        while( cur.next != null){
            if(cur.next.val == val){
                ListNode tempNode = cur.next;
                cur.next = tempNode.next;
            }else{
                cur = cur.next;
            }
        }
        
        return virtualNode.next;
        
    }
}