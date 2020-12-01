using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_to_ar
{
    class Class1
    {
        //get the length
        public static int Len(int[] arr)
        {
            int count = 0;
            foreach(int x in arr)
            {
                count++;
            }
            return count;
               
        }
        //get the index
        public static int IndexOf(int[] arr,int name)
        {
            foreach (int x in arr)
            {
                if(arr[x] == name)
                {
                    return x;
                }
            }
            return 1;
        }
        //bubble sort descending
        public static int Bsort_desc(int[] arr, int temp = 0)
        {
            for (int j = 0; j < arr.Length - 1; j++)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i + 1] > arr[i])
                    {
                        temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                    }
                }

            }
            foreach (int x in arr)
            {
                Console.WriteLine(x);
            }
            return 1;
        }
        // bsort ascending
        public static int Bsort_asc(int[] arr, int temp = 0)
        {
            for (int j = 0; j < arr.Length - 1; j++)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                    }
                }

            }
            foreach (int x in arr)
            {
                Console.WriteLine(x);
            }
            return 1;
        }
        //adding
        public static int[] Addvalue(int[] arr,int value)
        {
            int[] array = new int[arr.Length + 1];
            array[arr.Length] = value;
             for(int x = 0;x < array.Length - 2; x++)
            {
                array[x] = arr[x];
            }   
            return array;
        }
        //removing
        public static int[] RemoveValue(int[] arr, int value)
        {
            int[] array = new int[arr.Length - 1];

            for (int x = 0; x < array.Length; x++)
            {
                array[x] = arr[x];
            }
            return array;
        }
    }
}
