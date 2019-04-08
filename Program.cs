using System;

namespace bubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generate Random Number
            Random random = new Random();
            int randLength = random.Next(4,12); // Random 4 - 12

            int [] numArray = new int[randLength];

            // Assign Value
            for (int count = 0; count!=randLength; count++)
            {
                numArray[count] = random.Next(1, 100); // Random 1 -100
            }

            // Print
            Console.WriteLine("Array: ");
            for (int count = 0; count!= randLength; count++)
            {
                Console.WriteLine(numArray[count]);
            }

            Console.WriteLine("==========Bubble Sort=====================");
             
            // Initialize and Copy Array
            int [] sortedArray = new int[randLength];
            sortedArray = CopyArray(numArray, randLength);
            sortedArray = BubbleSort(sortedArray, randLength);

            // Print
            Console.WriteLine("\nSorted Array: ");
            for (int count = 0; count!=randLength; count++)
            {
                Console.WriteLine(sortedArray[count]);
            }

            Console.WriteLine("==========Optimized Bubble Sort===============");
            
            // Initialize and Copy Array
            sortedArray = new int[randLength];
            sortedArray = CopyArray(numArray, randLength);
            sortedArray = OptimizedBubbleSort(sortedArray, randLength);

            // Print
            Console.WriteLine("\nSorted Array: ");
            for (int count = 0; count != randLength; count++)
            {
                Console.WriteLine(sortedArray[count]);
            }
        } // END Main()

        private static int[] BubbleSort(int[] inNumArray, int inLength)
        {
            for (int i = 0;i < inLength-1;i++) // Scan the Array
            {
                Console.WriteLine("Scan " + (i+1) + ":");
                for (int j = 0;j < inLength-i-1; j++) // Compare Value
                {
                    // IF [j] > [j+1], Swap Position
                    if (inNumArray[j] > inNumArray[j+1])
                    {
                        Console.WriteLine("......inNumArray["+j+"]:" + inNumArray[j] + " > inNumArray[" + (j+1) + "]:" + inNumArray[j+1]);
                        int temp = inNumArray[j];
                        inNumArray[j] = inNumArray[j+1];
                        inNumArray[j+1] = temp;
                    } // END IF
                } // END FOR j
            } // END FOR i

            return inNumArray;

        } // END BubbleSort()

        private static int[] OptimizedBubbleSort(int[] inNumArray, int inLength)
        {
            bool swap = false;

            for (int i = 0;i < inLength-1;i++)
            {
                swap = false;
                Console.WriteLine("Scan " + (i+1) + ":");

                for (int j = 0; j < inLength - i - 1; j++)
                {
                    if (inNumArray[j] > inNumArray[j+1])
                    {
                        Console.WriteLine("......inNumArray["+j+"]:" + inNumArray[j] + " > inNumArray[" + (j+1) + "]:" + inNumArray[j+1]);
                        int temp = inNumArray[j];
                        inNumArray[j] = inNumArray[j+1];
                        inNumArray[j+1] = temp;
                        swap = true;
                    } // END IF
                } // END FOR j

                // IF the inner loop no longer get any swap, stop the loop.
                if (swap == false)
                {
                    return inNumArray;
                } 
            } // END for i
     
            return inNumArray;
        } // END OptimizedBubbleSort()

        private static int[] CopyArray(int[] inNumArray, int inLength)
        {
            int[] tempArray = new int[inLength];

            for (int count = 0; count!=inLength; count++)
            {
                tempArray[count] = inNumArray[count]; 
            } // END FOR
            return tempArray;
        } // END CopyArray()
    }
}
