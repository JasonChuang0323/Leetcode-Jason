/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */

// 解法1 先遍历一次长度，在遍历一次删除倒数第n个节点
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        int i = 0;
        ListNode cur = head;
        while(cur != null){
            i++;
            cur = cur.next;
        }
        if(i == 1) return null;
        
        int target = i - n;
        int count = 0;
        ListNode virtualNode = new ListNode(0);
        virtualNode.next = head;
        cur = virtualNode;
        
        while(cur.next != null){
            if(count == target){
                cur.next = cur.next.next;
            }else{
                cur = cur.next;
            }
            count++;
        }
        
        return virtualNode.next;
    }
}

//解法2 

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */

// 设置p,q双指针，设置好中间的距离为n,当q到达尾巴的时候，p就是要删除的前一个点
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        
        ListNode virtualNode = new ListNode(0);
        virtualNode.next = head;
        ListNode p = virtualNode;
        ListNode q = virtualNode;
        
        for(int i = 0; i < n + 1; i ++){
            q = q.next;
        }
              
        while(q!= null){
            q = q.next;
            p = p.next;
        }
        
        ListNode delnode = p.next;
        p.next = delnode.next;
        
        return virtualNode.next;
    }

}