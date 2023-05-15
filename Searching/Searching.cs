using System;


namespace Searching
{
    public class Searching
    {
        public int linearSearch(int[] array, int key)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == key)
                {
                    return i;
                }
            }
            return -1;
        }
        public int linearSearch(string[] array, string key)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (String.Equals(array[i], key))
                {
                    return i;
                }
            }
            return -1;
        }
        public int binarySearch(int[] array, int key)
        {
            int left = 0, right = array.Length - 1; //left will be leftmost and right will be right will be rightmost
            while (left <= right) // until left wont cross right if left cross right then we are done with searching
            {
                int mid = (left + right) / 2; //finding mid
                if (key == array[mid])
                {
                    return mid;
                }
                else if (key < array[mid])  // if key element is smaller than mid search in left part
                {
                    right = mid - 1;
                }
                else                        // if key element is bigger than mid then search in right part
                {
                    left = mid + 1;
                }
            }
            return -1;
        }

        public int binarySearch(string[] array, string key)
        {
            int left = 0, right = array.Length - 1; //left will be leftmost and right will be right will be rightmost
            while (left <= right) // until left wont cross right if left cross right then we are done with searching
            {
                int mid = (left + right) / 2; //finding mid
                if (String.Equals(key, array[mid]))
                {
                    return mid;
                }
                else if (String.Compare(key, array[mid]) > 0)  // if key element is smaller than mid search in left part
                {
                    right = mid - 1;
                }
                else                      // if key element is bigger than mid then search in right part
                {
                    left = mid + 1;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            Searching search = new Searching();
            Console.WriteLine("Enter the number of element in Array:");
            int noOfElements = System.Int32.Parse(Console.ReadLine());
            Console.WriteLine("Element are Integer or String? 0 for integer 1 for string :");
            int typeOfArray = System.Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter your choice of Search :");
            Console.WriteLine(string.Format("1.Linear Search \n2.Binary Search "));
            int typeOfSearch = System.Int32.Parse(Console.ReadLine());
            if (typeOfArray == 0)
            {
                int[] arr = new int[noOfElements];
                int result = 0;
                Console.WriteLine("Enter the element ");
                for (int i = 0; i < noOfElements; i++)
                {
                    arr[i] = System.Int32.Parse(Console.ReadLine());
                }
                Console.WriteLine("Enter the element to be search : ");
                int key = System.Int32.Parse(Console.ReadLine());
                switch (typeOfSearch)
                {
                    case 1:
                        result = search.binarySearch(arr, key);
                        break;
                    case 2:
                        result = search.linearSearch(arr, key);
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        break;

                }
                if (result == -1)
                {
                    Console.WriteLine("Key not found!!!");
                }
                else
                {
                    Console.WriteLine("Key is found at index " + result);
                }
                Console.ReadLine();
            }
            else
            {
                string[] arr = new string[noOfElements];
                int result = 0;
                Console.WriteLine("Enter the element ");
                for (int i = 0; i < noOfElements; i++)
                {
                    arr[i] = Console.ReadLine();
                }
                Console.WriteLine("Enter the element to be search : ");
                string key = Console.ReadLine();
                switch (typeOfSearch)
                {
                    case 1:
                        result = search.binarySearch(arr, key);
                        break;
                    case 2:
                        result = search.linearSearch(arr, key);
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        break;

                }
                if (result == -1)
                {
                    Console.WriteLine("Key not found!!!");
                }
                else
                {
                    Console.WriteLine("Key is found at index " + result);
                }
                Console.ReadLine();
            }


        }
    }
}

