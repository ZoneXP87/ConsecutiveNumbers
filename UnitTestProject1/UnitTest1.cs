using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestMid;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsCorrectSecuence()
        {
            //test 1
            var actual = new[] { -6, -3, -2, -1, 1, 3, 4, 5, 7, 8, 9, 10, 11, 14, 15, 17, 18, 19, 20 };
            var expected = "-6,-3--1,1,3-5,7-11,14,15,17-20";

            string output = Program.Extract(actual);

            Assert.AreEqual(expected, output);

            //test 2
            var actual2 = new[] { 1, 2 };
            var expected2 = "1,2";

            string output2 = Program.Extract(actual2);

            Assert.AreEqual(expected2, output2);
        }

        [TestMethod]
        public void IsValidSudoku()
        {
            //test 1
            var sudoku = new int[][] {
                new int[] {7,8,4, 1,5,9, 3,2,6},
                new int[] {5,3,9, 6,7,2, 8,4,1},
                new int[] {6,1,2, 4,3,8, 7,5,9},

                new int[] {9,2,8, 7,1,5, 4,6,3},
                new int[] {3,5,7, 8,4,6, 1,9,2},
                new int[] {4,6,1, 9,2,3, 5,8,7},

                new int[] {8,7,6, 3,9,4, 2,1,5},
                new int[] {2,4,3, 5,6,1, 9,7,8},
                new int[] {1,9,5, 2,8,7, 6,3,4}
            };

            var expected = true;
            bool output = Program.IsValid(sudoku);

            Assert.AreEqual(expected, output);

            //test 2

            var sudoku2 = new int[][] {
                new int[] {7,7,4, 1,5,9, 3,2,6},
                new int[] {7,3,9, 6,7,2, 8,4,1},
                new int[] {6,1,2, 4,3,8, 7,5,9},

                new int[] {9,2,8, 7,1,5, 4,6,3},
                new int[] {3,5,7, 8,4,6, 1,9,2},
                new int[] {4,6,1, 9,2,3, 5,8,7},

                new int[] {8,7,6, 3,9,4, 2,1,5},
                new int[] {2,4,3, 5,6,1, 9,7,8},
                new int[] {1,9,5, 2,8,7, 6,3,4}
            };

            var expected2 = false;
            bool output2 = Program.IsValid(sudoku2);

            Assert.AreEqual(expected2, output2);
        }
    }
}
