using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    internal class ArrayListIterator<T>: Iterator<T>
    {
        private ArrayList<T> arrayList;
        private int currentItem;

        public ArrayListIterator(ArrayList<T> arrayList)
        {
            this.arrayList = arrayList;
        }

       
    public bool hasNext()
        {
            return currentItem < arrayList.getSize();
        }

        
    public T next()
        {
            T data = arrayList.getAt(currentItem);
            currentItem++;
            return data;
        }
    }
}
