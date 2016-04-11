namespace SinglyLinkedListProject
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class SinglyLinkedList
    {
        private Node head;
        private List<Node> linkList;

        public SinglyLinkedList()
        {
            this.linkList = new List<Node>();
        }

        public void printAllNodes()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }

        public int Count
        {
            get { return linkList.Count; }
        }

        public void Append(Object data)
        {
            Node node = new Node();

            node.data = data;
            node.next = head;

            head = node;
            this.linkList.Add(node);
        }      

        public void Delete(object forDeleting)
        {
            if (linkList.Count == 0)
            {
                throw new InvalidOperationException(
                    "Deleting item from epty list is not possible");
            }
            foreach (var item in linkList)
            {
                if (item.data.Equals(forDeleting))
                {
                    this.linkList.Remove(item);
                    return;
                }
            }           
        }
    }
}