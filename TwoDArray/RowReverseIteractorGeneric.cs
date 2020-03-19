//
// ICT2106 Software Design - 2D array example
//
// Implementation of a basic two-dimensional array.
//
// Author: Nicholas Sheppard
//
using System;
namespace TwoDArray
{
    class RowReverseIteractorGeneric<T> : ITwoDIterator<T>
    {
        // the collection being iterated through
        TwoDArrayGeneric<T> collection;

        // counters
        private int i, j;

        // constructor
        public RowReverseIteractorGeneric(TwoDArrayGeneric<T> collectionIn)
        {
            collection = collectionIn;
            i = 0;
            j = 0;
            Console.WriteLine("total col = " + collection.Columns());
            Console.WriteLine("total row = " + collection.Rows());
        }

        // get the current element of the iteration
        public T Current()
        {
            return collection.Get(i, j);
        }

        // move to the next element of the iteration
        public void Next()
        {
           // Console.WriteLine("row = " + i + " col = " + j);
            if (i % 2 == 0)
            {
                if (j >= collection.Rows())
                {
                    i++;
                    j = 2;
                }
                else
                {
                    j++;
                }
            }
            else
            {
                if (j == 0)
                {
                    i++;
                    j = 0;
                }
                else
                {
                    j--;
                }
            }

        }

        // test whether or not the iteration has finished
        public bool IsDone()
        {
            return i >= collection.Rows();
        }
    }
}
