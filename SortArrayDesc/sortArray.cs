using System;

namespace SortArrayDesc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 36, 75, 20, 34, 19, 17, 58, 46, 80, 90 };
            //int numHolder;
            int x = myArray.Length;
            



                for (int i = 0; i < x- 1; i++)
                {
                    if (myArray[i] < myArray[i + 1])
                    {
                        int numHolder = myArray[i];
                        myArray[i] = myArray[i + 1];
                        myArray[i + 1] = numHolder;
                    i = -1;
                    
                    }

                }

               Console.WriteLine(string.Join(",", myArray));

            
        }
    }
}
