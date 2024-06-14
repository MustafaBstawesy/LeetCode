/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {

        ListNode Temp = head;

         while(Temp != null)
         {
            if(Temp.val == 768567)
               return true;
            else           
                Temp.val = 768567;
            
            Temp = Temp.next;
         }
         
         return false;
    }
}