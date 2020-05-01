using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace add_two_numbers
{
    public class Program
    {
        public static void Main(String[] args)
        {
            var item1L3 = new ListNode(3, null);
            var item1L2 = new ListNode(4, item1L3);
            var item1L1 = new ListNode(2, item1L2);
            
            var item2L3 = new ListNode(4, null);
            var item2L2 = new ListNode(6, item2L3);
            var item2L1 = new ListNode(5, item2L2);

            var solution = new Solution();

            var result = solution.AddTwoNumbers(item1L1, item2L1);

            Assert.Equal(7, result.val);
        }
    }

    public class Solution 
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
            var listNodeOne = new List<int>();
            var listNodeTwo = new List<int>();
            
            var actualNode = l1;
            do {
                if(actualNode != null){
                    listNodeOne.Add(actualNode.val);
                    actualNode = actualNode.next;
                } else {
                    break;
                }
            } while(actualNode != null);

            actualNode = l2;
            do {
                
                if(actualNode != null){
                    listNodeTwo.Add(actualNode.val);
                    actualNode = actualNode.next;
                } else {
                    break;
                }
            } while(actualNode != null);

            listNodeOne.Reverse();
            listNodeTwo.Reverse();

            var stringListNodeOne = string.Empty;
            var stringListNodeTwo = string.Empty;

            foreach(var number in listNodeOne){
                stringListNodeOne += number;
            }

            foreach(var number in listNodeTwo){
                stringListNodeTwo += number;
            }

            var nodeSumResult = Int64.Parse(stringListNodeOne) + Int64.Parse(stringListNodeTwo);

            ListNode newListNode = null;
            ListNode nextListNode = null;
            ListNode nodeToReturn = null;
            int count = 1;
            var nodesCharArray = nodeSumResult.ToString().ToCharArray();
            var nodesLength = nodesCharArray.Length;
            foreach(var number in nodeSumResult.ToString().ToCharArray()){
                newListNode = new ListNode(Int32.Parse(number.ToString()), nextListNode);
                nextListNode = newListNode;
                if(count == nodesLength) nodeToReturn = newListNode;
                count++;
            }

            return nodeToReturn;
        }
        
    }

    public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
      }
  }
}
