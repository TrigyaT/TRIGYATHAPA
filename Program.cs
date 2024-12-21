
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortDemo
{
        class Program
        {
            static void Main(string[] args)
            {
                // Array sorting
                int[] numbers = { 51, 36, 58, 11, 25 };
                Console.WriteLine("Before sorting the array: " + string.Join(", ", numbers));

                CustomBubbleSort sorter = new CustomBubbleSort();
                sorter.Sort(numbers); // Calls the overridden method
                Console.WriteLine("After sorting the  array: " + string.Join(", ", numbers));

            
            }
        }
    }

