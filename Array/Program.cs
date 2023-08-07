using System;
namespace Array;
class Program
{

    static void Main(string[] args)
    {/*
        //defining array with size 5. add value later on
        int[] inArray = new int[5];
        inArray[0] = 5;
        inArray[1] = 6;
        inArray[2] = 7;
        inArray[3] = 8;
        inArray[4] = 9;
        for (int i = 0; i < 5; i++)
        {
            inArray[i] = i;
            Console.WriteLine(i);

        }

        //defining array with size 5 and adding at the same time
        int[] intArray2  = new int[5] { 1, 2, 3, 4, 5 };
        for (int i = 0; i < 5;  i++) 
        {
            intArray2[i] = i;
            Console.WriteLine(i);

        }

        //defining array with 5 elements which indicate the size of an array
        int[] intArray3 = new int[5] {1,2,3,4,5};
        for (int i = 0; i < 5; i++)
        {
            intArray3[i] = i;
            Console.WriteLine(i);

        }
        */
        int[,] intArray = new int[3, 2]
        {
            {1,2},
            {3,4},
            {5,6},
         };
        foreach (int i in intArray)
        {

            Console.WriteLine(intArray[1, 2]);

        }
        
    }


}
