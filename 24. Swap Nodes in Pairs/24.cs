// Given a linked list, swap every two adjacent nodes and return its head.

// You may not modify the values in the list's nodes, only nodes itself may be changed.

 

// Example:

// Given 1->2->3->4, you should return the list as 2->1->4->3.

//设立头指针，然后进行变换.



/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode SwapPairs(ListNode head) {
        ListNode virtualNode = new ListNode(0);
        virtualNode.next = head;
        ListNode p = virtualNode;
        
        while(p.next != null && p.next.next != null){
            ListNode node1 = p.next;
            ListNode node2 = node1.next;
            ListNode next = node2.next;
            
            node2.next = node1;
            node1.next = next;
            p.next = node2;
                
            p = node1;
        }
        
        return virtualNode.next;
    }
}