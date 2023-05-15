using System;
using System.Runtime.Remoting.Services;

namespace Sorting
{
    public class Sorting
    {
        public int[] selectionSort(int[] arr)
        {
            int temp = 0;   // for swapping logic
            for (int i = 0; i < arr.Length; i++)    // outer loop for number who is going to get its fix value at final
            {
                for (int j = i + 1; j < arr.Length; j++)  // for comparison to other elements
                {
                    if (arr[i] > arr[j])    // swap logic
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }
        public string[] selectionSort(string[] arr)
        {
            string temp;  // for swapping logic
            for (int i = 0; i < arr.Length; i++)  // outer loop for number who is going to get its fix value at final
            {
                for (int j = i + 1; j < arr.Length; j++)  // for comparison to other elements
                {
                    if (String.Compare(arr[i], arr[j]) > 0)  // swap logic
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }
        public int[] bubbleSort(int[] arr)
        {
            int temp = 0;
            bool changed = false;
            for (int i = 0; i < arr.Length - 1; i++)  // for iteration
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)  // for comparing two elements
                {
                    if (arr[j] > arr[j + 1])  // swap logic
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        changed = true;
                    }
                }
                if (changed == false)  // if no swapping is done in one pass already sorted
                {
                    break;
                }
            }
            return arr;
        }
        public string[] bubbleSort(string[] arr)
        {
            string temp;
            bool changed = false;
            for (int i = 0; i < arr.Length - 1; i++) // for iteration
            {
                for (int j = 0; j < arr.Length - 1 - i; j++) // for comparing two elements
                {
                    if (String.Compare(arr[j], arr[j + 1]) > 0)  // swap logic
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        changed = true;
                    }
                }
                if (changed == false) // if no swapping is done in one pass already sorted
                {
                    break;
                }
            }
            return arr;
        }
        public int[] insertionSort(int[] arr)
        {
            int i, j;
            for (i = 1; i < arr.Length; i++)  // outer loop for iteration 
            {
                int key = arr[i];
                for (j = i - 1; j >= 0 && key < arr[j]; j--)  // for comparing key element with previous selements
                {
                    arr[j + 1] = arr[j];
                }
                arr[j + 1] = key;
            }
            return arr;
        }
        public string[] insertionSort(string[] arr)
        {
            int i, j;
            for (i = 1; i < arr.Length; i++)  // outer loop for iteration 
            {
                string key = arr[i];
                for (j = i - 1; j >= 0 && String.Compare(key, arr[j]) < 0; j--)  // for comparing key element with previous selements
                {
                    arr[j + 1] = arr[j];
                }
                arr[j + 1] = key;
            }
            return arr;
        }
        public void mergeSort(int[] arr, int left, int right)
        {
            //if single element or invalid part , do nothing
            if (left >= right)
            {
                return;
            }
            //find mid
            int mid = (left + right) / 2;
            //sort left partition
            mergeSort(arr, left, mid);
            //sort right partition
            mergeSort(arr, mid + 1, right);
            //allocate temporary array
            int[] temp = new int[right - left + 1];
            //merge both the parts into single partition 
            int i = left, j = mid + 1, k = 0;
            while (i <= mid && j <= right)
            {
                if (arr[i] < arr[j])
                {
                    temp[k] = arr[i];
                    i++;
                    k++;
                }
                else
                {
                    temp[k] = arr[j];
                    j++;
                    k++;
                }
            }
            while (i <= mid)
            {
                temp[k] = arr[i];
                i++;
                k++;
            }
            while (j <= right)
            {
                temp[k] = arr[j];
                j++;
                k++;
            }
            //copy temp array back to original
            for (i = 0; i < temp.Length; i++)
            {
                arr[left + i] = temp[i];
            }


        }
        public void mergeSort(string[] arr, int left, int right)
        {
            //if single element or invalid part , do nothing
            if (left >= right)
            {
                return;
            }
            //find mid
            int mid = (left + right) / 2;
            //sort left partition
            mergeSort(arr, left, mid);
            //sort right partition
            mergeSort(arr, mid + 1, right);
            //allocate temporary array
            string[] temp = new string[right - left + 1];
            //merge both the parts into single partition 
            int i = left, j = mid + 1, k = 0;
            while (i <= mid && j <= right)
            {
                if (String.Compare(arr[i], arr[j]) < 0)
                {
                    temp[k] = arr[i];
                    i++;
                    k++;
                }
                else
                {
                    temp[k] = arr[j];
                    j++;
                    k++;
                }
            }
            while (i <= mid)
            {
                temp[k] = arr[i];
                i++;
                k++;
            }
            while (j <= right)
            {
                temp[k] = arr[j];
                j++;
                k++;
            }
            //copy temp array back to original
            for (i = 0; i < temp.Length; i++)
            {
                arr[left + i] = temp[i];
            }


        }
        public void quickSort(int[] arr, int left, int right)
        {
            if (left >= right)
            {
                return;
            }
            int i = left, j = right, temp;
            while (i < j)
            {
                //find greater element than pivot
                while (i <= right && arr[i] <= arr[left])
                {
                    i++;
                }
                //find lower element than pivot
                while (arr[j] > arr[left])
                {
                    j--;
                }
                // found both greater and lower then swap 
                if (i < j)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            //swap pivot element with jth element
            temp = arr[left];
            arr[left] = arr[j];
            arr[j] = temp;
            quickSort(arr, left, j - 1);
            quickSort(arr, j + 1, right);

        }
        public void quickSort(string[] arr, int left, int right)
        {
            if (left >= right)
            {
                return;
            }
            int i = left, j = right;
            string temp;
            while (i < j)
            {
                //find greater element than pivot
                while (i <= right && (String.Compare(arr[i], arr[left]) < 0 || String.Compare(arr[i], arr[left]) == 0))
                {
                    i++;
                }
                //find lower element than pivot
                while (String.Compare(arr[j], arr[left]) > 0)
                {
                    j--;
                }
                // found both greater and lower then swap 
                if (i < j)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            //swap pivot element with jth element
            temp = arr[left];
            arr[left] = arr[j];
            arr[j] = temp;
            quickSort(arr, left, j - 1);
            quickSort(arr, j + 1, right);

        }
        static void Main(string[] args)
        {
            //int[] arr = { 55, 44, 33, 22, 11 };
            //string[] strArray = { "abc", "xyz", "pqr", "lmn" };
            Sorting sort = new Sorting();
            Console.WriteLine("Enter the number of element in Array:");
            int noOfElements = System.Int32.Parse(Console.ReadLine());
            Console.WriteLine("Element are Integer or String? 0 for integer 1 for string :");
            int typeOfArray = System.Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter your choice of sort :");
            Console.WriteLine(string.Format("1.Selection Sort \n2.Bubble Sort \n3.Insertion Sort \n4.Merge Sort \n5.Quick Sort"));
            int typeOfSort = System.Int32.Parse(Console.ReadLine());
            if (typeOfArray == 0)
            {
                int[] arr = new int[noOfElements];
                int[] sortedArray = new int[noOfElements];
                Console.WriteLine("Enter the element ");
                for (int i = 0; i < noOfElements; i++)
                {
                    arr[i] = System.Int32.Parse(Console.ReadLine());
                    //Console.ReadLine();
                }
                switch (typeOfSort)
                {
                    case 1:
                        sortedArray = sort.selectionSort(arr);
                        break;
                    case 2:
                        sortedArray = sort.bubbleSort(arr);
                        break;
                    case 3:
                        sortedArray = sort.insertionSort(arr);
                        break;
                    case 4:
                        sort.mergeSort(arr, 0, arr.Length - 1);
                        break;
                    case 5:
                        sort.quickSort(arr, 0, arr.Length - 1);
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        break;

                }
                Array.ForEach(arr, (num) => { Console.Write(num + ", "); });
                Console.ReadLine();
            }
            else
            {
                string[] arr = new string[noOfElements];
                string[] sortedArray = new string[noOfElements];
                Console.WriteLine("Enter the element ");
                for (int i = 0; i < noOfElements; i++)
                {
                    arr[i] = Console.ReadLine();
                    //Console.ReadLine();
                }
                switch (typeOfSort)
                {
                    case 1:
                        sortedArray = sort.selectionSort(arr);
                        break;
                    case 2:
                        sortedArray = sort.bubbleSort(arr);
                        break;
                    case 3:
                        sortedArray = sort.insertionSort(arr);
                        break;
                    case 4:
                        sort.mergeSort(arr, 0, arr.Length - 1);
                        break;
                    case 5:
                        sort.quickSort(arr, 0, arr.Length - 1);
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        break;

                }
                Array.ForEach(arr, (num) => { Console.Write(num + ", "); });
                Console.ReadLine();
            }

        }
    }
}

