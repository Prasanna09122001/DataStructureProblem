using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblem.UnorderedList
{
    internal class List<T>
    {
        internal Node<T> head;
        internal void Add(T data)
        {
            Node<T> node = new Node<T>(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            // Console.WriteLine("{0} inserted into linked list", node.data);
        }
        internal void AddInReverseOrder(T data)
        {
            Node<T> newnode = new Node<T>(data);
            if (this.head == null)
            {
                this.head = newnode;
            }
            else
            {
                Node<T> temp = this.head;
                head = newnode;
                head.next = temp;
            }
        }
        internal Node<T> InserAtParticularPosition(int position, T data)
        {
            Node<T> newestnode = new Node<T>(data);
            if (this.head == null)
            {
                return newestnode;
            }
            if (position == 0)
            {
                newestnode.next = this.head;
                this.head = newestnode;
                return this.head;
            }
            Node<T> prev = null;
            Node<T> current = this.head;
            int count = 0;
            while (current != null && count < position)
            {
                prev = current;
                current = current.next;
                count++;
            }
            newestnode.next = prev.next;
            prev.next = newestnode;
            return this.head;
        }
        internal void Display()
        {
            Node<T> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is Empty");
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        internal Node<T> RemoveFirstNode()
        {
            if (this.head == null)
            {
                return null;
            }
            this.head = this.head.next;
            return this.head;
        }
        internal Node<T> RemoveLastNode()
        {
            if (head == null)
            {
                return null;
            }
            if (head.next == null)
            {
                return null;
            }
            Node<T> newnode = head;
            while (newnode.next.next != null)
            {
                newnode = newnode.next;
            }
            newnode.next = null;
            return head;
        }
        internal int search(T value)
        {
            bool isFound = false;
            Node<T> node = this.head;
            int count = 0;
            while (node != null)
            {
                if (node.data.Equals(value))
                {
                    isFound = true;
                    return count;
                }
                node = node.next;
                count++;
            }
            if (isFound)
                return count;
            else
                return -1;
        }
        internal void DeleteNodeAtParticularPosition(int position)
        {
            if (this.head == null)
            {
                Console.WriteLine("The Linked List is Empty");
                return;
            }
            Node<T> temp = this.head;
            if (position == 0)
            {
                this.head = temp.next;
                return;
            }
            for (int i = 0; temp != null && i < position - 1; i++)
            {
                temp = temp.next;
            }
            if (temp == null || temp.next == null)
            {
                return;
            }
            Node<T> next = temp.next.next;
            temp.next = next;
        }
        public void Operation(T word)
        {
            int position = search(word);
            if (position == -1)
            {
                Add(word);
            }
            else
            {
                DeleteNodeAtParticularPosition(position);
            }
        }
    }
}
