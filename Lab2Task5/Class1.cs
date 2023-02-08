using System;
    namespace Lab2Task5
{  
    public class Class1
    {   /* Carissia Reyes
         * Lab2
         * Task5
         * Cps3330*0 */
        /// <summary>
        /// this method calculates the max
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static void myMax(int num1, int num2)
        {
            if (num1 < num2)
            {
                Console.WriteLine("The maximun = " +num2);
            }
            else
            {
                Console.WriteLine("The maximun = " + num1);
            }
        }
            public static void myMax1(int a, int b, int c)
        {
            int[] myNums = { a, b, c };
            int maximum = myNums.Max();
            Console.WriteLine("Maximum = {0} ", maximum);
            
        }
    }
}


