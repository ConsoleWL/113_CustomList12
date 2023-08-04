using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        //Member Variables (HAS A)
        private T[] items;
        private int capacity;
        private int count;

        public int Count { get => count; }
        public int Capacity { get => capacity; private set => capacity = value; }

        //Constructor
        public CustomList()
        {
            count = 0;
            capacity = 4;
            items = new T[capacity];
        }

        //Member Methods (CAN DO)
        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < count)
                    return items[index];
                else
                    throw new Exception($"Can't get an item. Out of list range. The length of list is {items.Length}");
            }
            set
            {
                if (index >= 0 && index < count)
                    items[index] = value;
                else
                    throw new Exception($"Can't set an item. Out of list range. The length of list is {items.Length}");
            }
        }

        public void HelperIncreaseArray()
        {
            T[] tempArray = new T[capacity * 2];

            for (int i = 0; i < count; i++)
            {
                tempArray[i] = items[i];
            }

            capacity *= 2;

            items = tempArray;
        }

        public void Add(T item)
        {
            if (count == capacity)
            {
                HelperIncreaseArray();
            }

            items[count] = item;
            count++;
        }

        public bool Remove(T item)
        {
            //If 'item' exists in the 'items' array, remove its first instance
            //Any items coming after the removed item should be shifted down so there is no empty index.
            //If 'item' was removed, return true. If no item was removed, return false.
            return false;
        }

        public override string ToString()
        {
            //returns a single string that contains all items from array
            return "";
        }

        public static CustomList<T> operator +(CustomList<T> firstList, CustomList<T> secondList)
        {
            //returns a single CustomList<T> that contains all items from firstList and all items from secondList 
            return null;
        }

        public static CustomList<T> operator -(CustomList<T> firstList, CustomList<T> secondList)
        {
            //returns a single CustomList<T> with all items from firstList, EXCEPT any items that also appear in secondList
            return null;
        }


    }
}
