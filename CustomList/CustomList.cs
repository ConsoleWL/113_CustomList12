﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T> : IEnumerable
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
        // Indexer
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
        // helper method. Calls when Array is full
        // SRP 
        void HelperIncreaseArray()
        {
            capacity *= 2;

            T[] tempArray = new T[capacity];

            for (int i = 0; i < count; i++)
            {
                tempArray[i] = items[i];
            }

            items = tempArray;
        }

        // Add item to the list. if List is full calls HelperIncreaseArray()
        public void Add(T item)
        {
            if (count == capacity)
            {
                HelperIncreaseArray();
            }

            items[count] = item;
            count++;
        }

        // If Method returns -1 . Doesn't contain
        // If method returns a number. It's the index in the array where item is
        // SRP
        int HelperContains(T item)
        {
            int contains = -1;
            for (int i = 0; i < count; i++)
            {
                if (items[i].Equals(item))
                {
                    contains = i;
                    i = count;
                }
            }
            return contains;
        }

        // Removes items from the list
        public bool Remove(T item)
        {
            int result = HelperContains(item);

            if (result == -1)
            {
                return false;
            }
            else
            {
                T[] tempArray = new T[capacity];

                for (int i = 0, j = 0; i < count; i++, j++)
                {
                    if (i == result)
                    {
                        i++;
                    }

                    tempArray[j] = items[i];
                }

                count--;
                items = tempArray;
                return true;
            }
        }

        
        public override string ToString()
        {
            string listToString = "";

            for (int i = 0; i < count; i++)
            {
                listToString += $"{items[i]}";
            }
            return listToString;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < items.Length; i++)
            {
                yield return items[i];
            }
        }

        public static CustomList<T> operator +(CustomList<T> firstList, CustomList<T> secondList)
        {
            for (int i = 0; i < secondList.count; i++)
            {
                firstList.Add(secondList[i]);
            }

            return firstList;
        }

        public static CustomList<T> operator -(CustomList<T> firstList, CustomList<T> secondList)
        {
            for (int i = 0; i < secondList.count; i++)
            {
                firstList.Remove(secondList[i]);
            }

            //returns a single CustomList<T> with all items from firstList, EXCEPT any items that also appear in secondList
            return firstList;
        }

        // Zips one item from the first List and one from the second list
        // If item one list is longer. it zips first and then add leftovers
        public void Zip(CustomList<T> zipper)
        {
            T[] tempArray = new T[count + zipper.count];

            int indexTempArray = 0;
            int indexItems = 0;
            int indexZipper = 0;

            for (int i = 0; i < count + zipper.count; i++)
            {
                if (indexItems < count)
                {
                    tempArray[indexTempArray] = items[indexItems];
                    indexTempArray++;
                    indexItems++;
                }

                if (indexZipper < zipper.count)
                {
                    tempArray[indexTempArray] = zipper[indexZipper];
                    indexTempArray++;
                    indexZipper++;
                }
            }

            count += zipper.count;
            items = tempArray;
        }

        // IComparer<T>
        // EqualityComparer<T>.Default
        // IEquatable 
        // I am
        //public void Sort2<T>() where T : IComparable<T>
        //{
        //    T temp;

        //    for (int i = 0; i < count - 1; i++)
        //    {
        //        for (int j = 1; j < count; j++)
        //        {
        //            int result = items[i]);

        //            if (result == 1)
        //            {
        //                temp = list[i];
        //                list[i] = list[j];
        //                list[j] = temp;   
        //            }     
        //        }
        //    }
        //}
        // I am using BubbleSort algorithm . What it does 
        // Comparer<T>.Default
        public CustomList<T> Sort<T>(CustomList<T> list) where T : IComparable<T>
        {
            T temp;

            for (int i = 0; i < list.count - 1; i++)
            {
                for (int j = 1; j < list.count; j++)
                {
                    int result = list[i].CompareTo(list[j]);

                    if (result == 1)
                    {
                        temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }

            return list;
        }
    }
}

