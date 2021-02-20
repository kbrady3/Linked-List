using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class LinkedList
    {
        private int First { get; set; }
        private int MaxSize { get; set; }
        private double[] ListItems { get; set; }

        public LinkedList() {
            First = -1;
            MaxSize = 5;
            ListItems = new double[MaxSize];
            ListItems = [9, 8, 7, 6, 5];
        }

        public LinkedList(int maxSize)
        {
            First = -1;
            MaxSize = maxSize;
            ListItems = new double[maxSize];
        }

        public void AddLast(double item)
        {
            //Use Add method but have next point to null
        }

        public void Add(int index, double item)
        {
            if(ListItems[index] == 0)
            {
                ListItems[index] = item;
            }
            else
            {
                //Array.Copy to new array, move up one index from index, copy item to index of original array, then concatenate the arrays
                double[] tempArray = new double[MaxSize + 1];

                //Array.Copy(originalArray, startIndex, newArray, startIndex, endIndex);
                //ARRAY MUST BE RESIZED SINCE EVERYTHING HAS TO BE SHIFTED UP
                //Array.Resize(ref ListItems, MaxSize + 1);
                Array.Copy(ListItems, 0, tempArray, 0, MaxSize); 

                ListItems[index] = item;

                Array.Copy(tempArray, index + 1, ListItems, index + 1, MaxSize - 1);
            }

            //Add check for full array
        }

        public double PeekFirst()
        {
            //Looks at the first item in the array
            if(ListItems[0] != 0)
            {
                return ListItems[MaxSize - 1];
            }
            else
            {
                throw new Exception("List is empty");
            }
        }

        public double RemoveFirst()
        {
            if (ListItems[0] != 0)
            {
                double temp = ListItems[0];
                ListItems[0] = 0;
                return temp;
            }
            else
            {
                throw new Exception("List is empty");
            }
        }

        public double Remove(int index)
        {
            return -1;
        }

        public int Size()
        {
            int counter = 0;

            if (ListItems[0] != 0)
            {
                for(int i = 0; i < MaxSize; i++)
                {
                    if(ListItems[i] != 0)
                    {
                        counter++; //Counts each nonzero item in array
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else
            {
                throw new Exception("List is empty");
            }

            return counter;
        }
     
        public string Print()
        {
            string concat = "";
            foreach(double item in ListItems)
            {
                concat += item;
            }
            return concat;
        }
    }
}
