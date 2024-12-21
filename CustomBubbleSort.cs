namespace BubbleSortDemo
{
    public class CustomBubbleSort : BubbleSortBase
    {
        // Override the Sort method for integers
        public override void Sort(int[] array)
        {
            System.Console.WriteLine("Sorting the array:");
            base.Sort(array); // Call the base class method
        }

        
    }
}
