/*
    Author: VD
    Date: 9/17/2019
    Comments: This C# Console application code demonstrates the Buble Sort, Selection Sort and Binary Search
              after getting input from users. 

*/

using System;

namespace SortAndBinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter an integer between 1 and 20 to define the size of the array: ");

            try
            {
                string arraysizeinput = Console.ReadLine();
                int array_size = int.Parse(arraysizeinput);
                string sorttype = "new";

                int[] sort_search_array = new int[array_size];

                Random random_number = new Random();

                Console.Write("Your Array is: ");

                for (int i = 0; i < array_size; i++)
                {
                    sort_search_array[i] = random_number.Next(0, 20);
                    Console.Write(sort_search_array[i] + " ");
                };

                if (array_size > 0 && array_size <= 10)
                {
                    //bubble sort code starts
                    sorttype = "Bubble";
                    
                    for (int i = 0; i < array_size; i++)
                    {
                        for (int j = 0; j < array_size - i - 1; j++)
                        {
                            if (sort_search_array[j] > sort_search_array[j + 1])
                            {
                                int temp = sort_search_array[j + 1];
                                sort_search_array[j + 1] = sort_search_array[j];
                                sort_search_array[j] = temp;
                            }
                        } // end for
                    } // end for
                    //bubble sort code ends
                }

                else if (array_size > 10 && array_size <=20)
                {
                    //selection sort code starts
                    sorttype = "Selection";

                    for (int i=0; i < array_size; i++)
                    {
                        for (int j = i+1; j < array_size; j++)
                        {
                            if (sort_search_array[j] < sort_search_array[i])
                            {
                                int temp = sort_search_array[i];
                                sort_search_array[i] = sort_search_array[j];
                                sort_search_array[j] = temp;
                            }
                        } // end for
                    } // end for
                    //selection sort code ends                    
                }

                //Array.Sort(sort_search_array);
                
                Console.WriteLine("");
                Console.Write("Your " + sorttype + " Sorted Array is: ");

                for (int i = 0; i < array_size; i++)
                {
                    Console.Write(sort_search_array[i] + " ");
                };

                Console.WriteLine("");
                Console.Write("Please enter an integer value from the above listed array: ");
                Console.WriteLine("");

                string searchinput = Console.ReadLine();
                int value_of_search = int.Parse(searchinput);

                int low = 0;
                int high = (sort_search_array.Length) - 1;
                int mid = (low + high) / 2;
                int middle_value = 0;
                int track_middle = 0;

                while (low <= high)
                {
                    mid = (low + high) / 2;
                    middle_value = sort_search_array[mid];

                    if (middle_value == value_of_search)
                    {
                        Console.WriteLine("Search Element Found");
                        break;
                    }

                    else if (middle_value > value_of_search && track_middle != middle_value)
                    {
                        high = mid + 1;
                        Console.WriteLine("In Else If Found this integer: " + middle_value + " But that's not it!");
                        track_middle = middle_value;
                    }

                    else
                    {
                        low = mid + 1;
                        Console.WriteLine("In Else Found this integer: " + middle_value + " But that's not it!");
                    }
                }
                if (low > high)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Could not locate your integer value in the search. Please try again... ");
                }
            }
            catch
            {
                Console.WriteLine("Please input integer values only next time...");
                Console.WriteLine("Press any key to exit the program and try again ...");
                Console.ReadKey(true);
            } // End of catch

        }
    }
}
