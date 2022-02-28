using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestMid
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1
            //A format for expressing an ordered list of integers is to use a comma separated list of either
            //Individual integers
            //or a range of integers denoted by the starting integer separated from the end integer in the range by a dash, "-". 
            //The range includes all integers in the interval including both endpoints. It is not considered a 
            //range unless it spans at least 3 numbers. For example "12,13,15-17"

            //Complete the solution so that it takes a list of integers in increasing order and returns a correctly
            //formatted string in the range format.

            //Examples
            //Input: [1, 2]
            //Output: "1,2"

            //Input: [1, 2, 3]
            //Output: "1-3"

            //Input: [1, 2, 3, 4, 5]
            //Output: "1-5"

            //Input: [-6, -3, -2, -1, 1, 3, 4, 5, 7, 8, 9, 10, 11, 14, 15, 17, 18, 19, 20]
            //Output: "-6,-3--1,1,3-5,7-11,14,15,17-20"

            //Exercise 2
            //Given a Sudoku data structure with size NxN, N > 0 and √N == integer, write a method to validate if it 
            //has been filled out correctly.

            //The data structure is a multi-dimensional Array, i.e:

            /*
            [
                [7,8,4,  1,5,9,  3,2,6],
                [5,3,9,  6,7,2,  8,4,1],
                [6,1,2,  4,3,8,  7,5,9],
  
                [9,2,8,  7,1,5,  4,6,3],
                [3,5,7,  8,4,6,  1,9,2],
                [4,6,1,  9,2,3,  5,8,7],
  
                [8,7,6,  3,9,4,  2,1,5],
                [2,4,3,  5,6,1,  9,7,8],
                [1,9,5,  2,8,7,  6,3,4]
            ]
            */

            //Rules for validation

            //Data structure dimension: NxN where N > 0 and √N == integer
            //Rows may only contain integers: 1..N(N included)
            //Columns may only contain integers: 1..N(N included)
            //'Little squares'(3x3 in example above) may also only contain integers: 1..N(N included)

            ////int[] secuence = new[] { -6, -3, -2, -1, 1, 3, 4, 5, 7, 8, 9, 10, 11, 14, 15, 17, 18, 19, 20 };
            
            ////Extract(secuence);

            ////int[][] sudoku = new int[][] {
            ////    new int[] {7,7,4, 1,5,9, 3,2,6},
            ////    new int[] {5,3,9, 6,7,2, 8,4,1},
            ////    new int[] {6,1,2, 4,3,8, 7,5,9},

            ////    new int[] {9,2,8, 7,1,5, 4,6,3},
            ////    new int[] {3,5,7, 8,4,6, 1,9,2},
            ////    new int[] {4,6,1, 9,2,3, 5,8,7},

            ////    new int[] {8,7,6, 3,9,4, 2,1,5},
            ////    new int[] {2,4,3, 5,6,1, 9,7,8},
            ////    new int[] {1,9,5, 2,8,7, 6,3,4}
            ////};

            ////IsValid(sudoku);

            ////Console.ReadKey();
            ///

            OrderedString(new int[] {-6, -5, -4, -1, 1 });
        }

        public static string Extract(int[] data)
        {
            return "";
        }

        public static bool IsValid(int[][] sudokuData)
        {
            return true;
        }

        public static string OrderedString(int[] values)
        {
            //Input: [-6, -3, -2, -1, 1, 3, 4, 5, 7, 8, 9, 10, 11, 14, 15, 17, 18, 19, 20]
            //Input: [-6, -5, -4, -1, 1]
            //Input: [-6, -5, 0, 1, 4]
            //Output: "-6,-3--1,1,3-5,7-11,14,15,17-20"

            var newValues = "";
            var consecutive = 0;

            for(int i = 0; i < values.Length; i++)
            {
                if (i == 0)
                    newValues = values[i].ToString();

                if ( (i+1) > values.Length)
                {
                    newValues += values[i].ToString();
                    return newValues;
                }

                if ((values[i] + 1) == values[i+1])
                {
                    //consecutive++;
                    OrderedString(new ArraySegment<int>(values, i + 1, values.Length - 1).ToArray());
                    newValues += "-" + values[i+1].ToString();
                }
                else
                {
                    newValues += "," + values[i];
                }


                

            }

            return newValues;

        }

    }
}
