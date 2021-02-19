using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class LinkedList
    {
        private int First { get; set; }
        private int Size { get; set; }
        private int MaxSize { get; set; }
        private string[] ListItems { get; set; }

        public LinkedList() {
            First = -1;
            MaxSize = 5;
            ListItems = new string[MaxSize];
        }

        public LinkedList(int maxSize)
        {
            First = -1;
            MaxSize = 5;
            ListItems = new string[maxSize];
        }

        public void AddLast(double item)
        {

        }

        public void Add(int index, double item)
        {

        }

        public double PeekFirst()
        {

        }

        public double RemoveFirst()
        {

        }

        public double Remove(int index)
        {

        }

        public int Size()
        {

        }
     
        public string Print()
        {

        }
    }
}
