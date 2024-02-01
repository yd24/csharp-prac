using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresTest
{
    public class IntLinkedList
    {
        public ListNode? head;
        public IntLinkedList()
        {
            head = null;
        }

        public IntLinkedList(int val)
        {
            ListNode current = new ListNode(val);
            head = current;
        }

        public IntLinkedList(ListNode head)
        {
            this.head = head;
        }

        public void AddLast(ListNode node)
        {
            if (head == null)
            {
                head = node;
                return;
            }

            ListNode? current = head;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = node;
        }

        public void AddLast(int val)
        {
            this.AddLast(new ListNode(val));
        }

        public void AddFirst(ListNode node)
        {
            node.next = head;
            head = node;
        }

        public void AddFirst(int val)
        {
            this.AddFirst(new ListNode(val));
        }

        public void RemoveFirst()
        {
            if (head != null)
            {
                head = head.next;
            } else
            {
                throw new NullReferenceException("There are no nodes left to remove.");
            }
        }

        public void RemoveLast()
        {
            if (head != null)
            {
                ListNode? current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = null;
            }
            else
            {
                throw new NullReferenceException("There are no nodes left to remove.");
            }
        }

        public void Clear()
        {
            head = null;
        }

        public bool Contains(int val)
        {
            ListNode? current = head;
            while (current != null)
            {
                if (current.val == val)
                {
                    return true;
                }
                current = current.next;
            }
            return false;
        }

        public void AddAfter(ListNode node, int val)
        {
            ListNode? current = head;
            while (current != null && current.next != null)
            {
                if (current.next == node)
                {
                    ListNode created = new ListNode(val);
                    created.next = current.next.next;
                    current.next.next = created;
                    return;
                }
                current = current.next;
            }
            Console.WriteLine("Node does not exist.");
        }

        public void AddBefore(ListNode node, int val)
        {
            ListNode? current = head;
            while (current != null && current.next != null)
            {
                if (current.next == node)
                {
                    ListNode created = new ListNode(val);
                    node.next = current.next;
                    current.next = node;
                    return;
                }
                current = current.next;
            }
            Console.WriteLine("Node does not exist.");
        }

        public void Remove(ListNode node)
        {
            ListNode? current = head;
            while (current != null && current.next != null)
            {
                if (current.next == node)
                {
                    current.next = current.next.next;
                    return;
                }
                current = current.next;
            }
            Console.WriteLine("Node does not exist.");
        }
    }
}
