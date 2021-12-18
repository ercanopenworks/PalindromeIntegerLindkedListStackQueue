using System;
using System.Collections.Generic;

namespace PalindromeIntegerLindkedListStackQueue
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    class Program
    {
        

        static Stack<int> myStack = new Stack<int>();
        static Queue<int> myQue = new Queue<int>();

        static void pushCharacter(int ch)
        {
            myStack.Push(ch);

        }

        static void enqueueCharacter(int ch)
        {
            myQue.Enqueue(ch);
        }

        static int popCharacter()
        {
            return myStack.Pop();

        }

        static int dequeueCharacter()
        {
            return myQue.Dequeue();
        }

        static bool IsPalindrome(ListNode head)
        {
            var current = head;

            if (head.val == null)
                return false;

            if (current.next == null)
                return true;

            pushCharacter(head.val);
            enqueueCharacter(head.val);

            while (current.next != null)
            {
                pushCharacter(current.next.val);
                enqueueCharacter(current.next.val);
                current = current.next;

            }
            bool isPalindrome = true;

            for (int i = 0; i < myStack.Count; i++)
            {
                if (popCharacter() != dequeueCharacter())
                {
                    isPalindrome = false;

                    break;
                }
            }

            return isPalindrome;

        }
        static void Main(string[] args)
        {

            //[1,1,2,1]

            ListNode myList = new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(1))));
            

            Console.WriteLine(IsPalindrome(myList));
        }
    }
}
