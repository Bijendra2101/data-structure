using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//-------------------------------------------------------------------------------------------------------

namespace test1
{

    /*Finding an element in given array*/

    #region
    //    class Program  
    //    {
    //        
    //        // recursive Binary Search 
    //        static int binarySearch(int[] arr, int l, int r, int findelement)
    //        {
    //            if (r >= l)
    //            {
    //                int mid = l + (r - l) / 2;

    //                if (arr[mid] == findelement)
    //                    return mid;

    //                if (arr[mid] > findelement)
    //                    return binarySearch(arr, l, mid - 1, findelement);

    //                // Else the element can only be present 
    //                // in right subarray 
    //                return binarySearch(arr, mid + 1, r, findelement);
    //            }
    //            return -1;
    //        }
    //        

    //        // Iterative Binary Search 
    //        static int binarySearch(int[] arr, int x)
    //        {
    //            int l = 0, r = arr.Length - 1;
    //            while (l <= r)
    //            {
    //                int m = l + (r - l) / 2;

    //                if (arr[m] == x)
    //                    return m;

    //                if (arr[m] < x)
    //                    l = m + 1;

    //                else
    //                    r = m - 1;
    //            }
    //            return -1;
    //        }

    //        public static void Main()
    //        {

    //            int[] arr = {10, 20, 30, 40, 50, 60};
    //            int n = arr.Length;
    //            int findelement = 50;

    //            //recursive
    //           // int result = binarySearch(arr, 0, arr.Length - 1, findelement);
    //            //iterative
    //            int result = binarySearch(arr, findelement); 


    //            if (result == -1)
    //                Console.WriteLine("Element not present");
    //            else
    //                Console.WriteLine("Element found at index " + result);

    //            Console.ReadLine();
    //        } 

    //    }
    //}

    //---------------------------------------------------------------------------------------------------

    #endregion

    #region

    /*Finding an Max value in given array*/

    //class Program
    //{

    //    static int[] arr = { 60, 50, 80, 40, 15, 12, 89, 70 };

    //    static int largest()
    //    {
    //        int i;

    //        int max = arr[0];


    //        for (i = 1; i < arr.Length; i++)
    //        {
    //            if (arr[i] > max)
    //            {
    //                max = arr[i];
    //            }
    //        }

    //        return max;
    //    }

    //    public static void Main()
    //    {
    //        Console.WriteLine("Max value in given array is " + largest());
    //        Console.ReadLine();
    //    }
    //}

    /*Finding an Min value in given array*/
    //class Program
    //{

    //    static int[] arr = { 60, 50, 80, 40, 15, 12, 89, 70 };

    //    static int largest()
    //    {
    //        int i;

    //        int Min = arr[0];


    //        for (i = 1; i < arr.Length; i++)
    //        {
    //            if (arr[i] < Min)
    //            {
    //                Min = arr[i];
    //            }
              
    //        }

    //        return Min;
    //    }

    //    public static void Main()
    //    {
    //        Console.WriteLine("Min value in given array is " + largest());
    //        Console.ReadLine();
    //    }
    //}

    #endregion


    /*Finding an Min and max value in given array*/

    #region



    class Program
    {
        static int getMin(int[] arr, int n)
        {
            int res = arr[0];

            for (int i = 1; i < n; i++)
                res = Math.Min(res, arr[i]);
            return res;
        }

        static int getMax(int[] arr, int n)
        {
            int res = arr[0];

            for (int i = 1; i < n; i++)
                res = Math.Max(res, arr[i]);
            return res;
        }

        public static void Main(String[] args)
        {
            int[] arr = { 20, 45, 66, 4, 9, 89, 55 };
            int n = arr.Length;
            Console.Write("Minimum element of array: " + getMin(arr, n) + "\n");
            Console.Write("Maximum element of array: " + getMax(arr, n));
            Console.ReadLine();
        }
    }

 
    #endregion

}
