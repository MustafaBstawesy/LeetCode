/*
  public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
      }
  }*/
 
public class Solution {
  
       public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        if(list1 == null) return list2;
        if(list2 == null) return list1;
        if(list1 == null && list2 == null) return list1; 

        ListNode Head = new ListNode();
        ListNode Current = Head;

        int value = 0;

        while(list1 != null && list2 != null)
        {
            if(list1.val <= list2.val)
            {
                value = list1.val;
                list1 = list1.next;
            }
            else
            {
                value = list2.val;
                list2 = list2.next;
            }
            ListNode temp = new ListNode(value);
            Current.next = temp;
            Current = Current.next;
        }

        if(list1 == null) Current.next = list2;
        else if(list2 == null) Current.next = list1;

        return Head.next;
    }
}