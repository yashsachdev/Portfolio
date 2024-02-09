using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1
{
    internal class BinarySearch
    {
        public int Binarysearch(int[] arr, int start, int end,int element)
        {
            if (end >= start)
            {
                int mid = (start + (end - start) / 2);// To avoid overflow
                if (arr[mid] == element)
                    return mid;

                else if (arr[mid] > element)
                {
                    
                    return Binarysearch(arr, start, end-1, element);
                }
                else if (arr[mid] < element) 
                {
                    return Binarysearch(arr, mid+1, end, element);
                }
            }
            return -1;
        }

    }
}
