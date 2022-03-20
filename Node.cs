using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    internal class Node<T>
    {
        internal T data;
        internal Node<T> next;
        internal Node<T> previous;

        internal Node(T data)
        {
            this.data = data;
        }
    }
}
