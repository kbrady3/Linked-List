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
            MaxSize = 10;
            ListItems = new double[MaxSize];
        }

        public void AddLast(double item)
        {
            if(ListItems[MaxSize - 1] == 0)
            {
                ListItems[MaxSize - 1] = item;
            }
            else
            {
                throw new Exception("List is full");
            }
        }

        public void Add(int index, double item)
        {
            if(ListItems[index] == 0)
            {
                ListItems[index] = item;
            }
            else
            {
                double[] tempArray = new double[100];
                double[] tempArray2 = new double[100];
                
                if (ListItems[MaxSize - 1] == 0)
                {
                    try
                    {
                        //Array.Copy(originalArray, startIndex, newArray, startIndex, endIndex);

                        Array.Copy(ListItems, 0, tempArray, 0, index); //Copies the first part of the array (up to, but not including index)
                        Array.Copy(ListItems, index, tempArray2, index + 1, MaxSize - 1); //Copies the second part of the array (index inclusive to the end)

                        ListItems[index] = item; //Now that we have a backup of ListItems, we can overwrite the current value in index with the new value

                        Array.Copy(tempArray2, index + 1, tempArray, index + 1, MaxSize - 1); //Now we combine our temp arrays, so now everything is in tempArray, except there's a blank spot at index
                        tempArray[index] = item; //Copy the item to the blank spot

                        ListItems = tempArray; //Assign tempArray to ListItems
                    }
                    catch
                    {
                        throw new Exception("List is full");
                    }
                }
                else
                {
                    throw new Exception("List is full.");
                }
            }
        }

        public double PeekFirst()
        {
            //Looks at the first item in the array
            if(ListItems[0] != 0)
            {
                return ListItems[0];
            }
            else
            {
                throw new Exception("No element at index 0");
            }
        }

        public double RemoveFirst()
        {
            if (ListItems[0] != 0)
            {
                double temp = ListItems[0];
                ListItems[0] = 0;

                double[] tempArray = new double[MaxSize + 1];
                Array.Copy(ListItems, 1, tempArray, 0, MaxSize); //Moves items back one index by copying to tempArray

                ListItems = tempArray;

                return temp;
            }
            else
            {
                throw new Exception("No need to remove first element - no element present");
            }
        }

        public double Remove(int index)
        {
            double removed = ListItems[index];

            if (ListItems[index] == 0)
            {
                throw new Exception("Nothing to remove - no element present at specified index");
            }
            else
            {
                for(int i = index; i < MaxSize; i++)
                {
                    ListItems[i] = ListItems[i + 1]; //Copies items back one index starting at index
                }
            }

            return removed;
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
                concat += item + " ";
            }

            return concat;
        }
    }
}
