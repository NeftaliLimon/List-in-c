using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    internal class LinkedListIterator<T>: Iterator<T>
    {
        private Node<T> currentNode;

        internal LinkedListIterator(Node<T> startNode)
        {
            currentNode = startNode;
        }

      
    public bool hasNext()
        {
            return currentNode != null;
        }

        
    public T next()
        {
            T data = currentNode.data;
            currentNode = currentNode.next;
            return data;
        }
    }
}
