/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */


 // 3个指针 pre cur next 依次更改就好
 
public class Solution {
    public ListNode ReverseList(ListNode head) {
        ListNode pre = null;
        ListNode cur = head;
        
        while(cur != null){
            ListNode next = cur.next;
            
            cur.next = pre;
            pre = cur; 
            cur = next;
        }
        // cur最后肯定是Null，所以返回头指针就是当前最后一个指针 为 pre
        return pre;
        
    }
}