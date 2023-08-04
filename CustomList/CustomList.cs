using System;
using System.Collections;
using System.Collections.Generic;
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

        // If Method returns -1 . Doesn't contain
        // Id method returns a number it means the spot where is the same item;
        int HelperEquals(T item)
        {
            int number = -1;
            for (int i = 0; i < count; i++)
            {
                if (items[i].Equals(item))
                {
                    number = i;
                    i = count;
                }
            }
            return number;
        }
        public bool Remove(T item)
        {
            int result = HelperEquals(item);

            if (result == -1)
            {
                return false;
            }
            else
            {
                T[] tempArray = new T[capacity];
                int tempCount = 0;

                for (int i = 0; i < result; i++)
                {
                    tempArray[i] = items[i];
                    tempCount++;
                }

                for (int i = tempCount; i < count - 1; i++)
                {
                    tempArray[i] = items[tempCount + 1];
                    tempCount++;
                }
                count = tempCount;
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

        public void Zip(CustomList<T> zipper)
        {
            //CustomList<T> tempList = new CustomList<T>();

            

            //for (int i = 0; i < count; i++)
            //{
            //    tempList.Add(items[i]);
            //}

            //for (int i = 0; i < zipper.count; i++)
            //{
            //    tempList.Add(zipper[i]);
            //}

            //T[] tempArray = new T[tempList.count];

            //for (int i = 0; i < tempList.count; i++)
            //{
            //    tempArray[i] = tempList[i];
            //}



            // what the hell!!!!
            //if (tempArray[1] > tempArray[2])

            //HelperIntArraySort(tempArray);



            //int length = count + zipper.count;

            //T[] tempArray = new T[length];

            //int counter = 0;

            //for (int i = 0; i < count; i++)
            //{
            //    tempArray[i] = items[i];
            //    counter++;
            //}

            //for (int j = 0; j < zipper.count; j++)
            //{
            //    tempArray[counter] = zipper[j];
            //    counter++;
            //}

            //capacity = length;

            //items = tempArray;

            //HelperIntArraySort(items);

            //for (int i = 0; i < count; i++)
            //{
            //    zipper.Add(items[i]);
            //}
            //count = zipper.count + count;
            //items = zipper;
        }

        void HelperIntArraySort(int[] toSort)
        {
            int temp;
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    if (toSort[i] > toSort[j])
                    {
                        temp = toSort[i];
                        toSort[i] = toSort[j];
                        toSort[j] = temp;
                    }
                }
            }
        }
    }
}
