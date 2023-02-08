/*Carissia Reyes
 * Lab2Task7
 * cps3330*03
 * */
namespace Lab2Task5
{  

    public class TestL2tt
    {
        public static void Main()
        {
            Console.WriteLine("Enter a value for a");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a value for b");
            int b = Convert.ToInt32(Console.ReadLine());

            Class1.myMax(a, b);

            Console.WriteLine("Enter a value for x");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a value for y");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a value for z");
            int z = Convert.ToInt32(Console.ReadLine());

            int[] k = { x, y, z };

            Class1.myMax1(x, y, z);
        }
    }
}