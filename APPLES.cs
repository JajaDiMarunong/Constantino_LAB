using System;

namespace DataTypesApp
{
    public class DataTypesProgram
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the number of apples: ");
            int numberOfApples = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the total price of 6 apples: ");
            double totalPrice = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("=====================================");
            Console.WriteLine("The total price of 6 apples is: " + totalPrice);
            Console.WriteLine("The value of the original price is: " + totalPrice);

            int convertedPrice = (int)totalPrice;
            Console.WriteLine("The value of the converted price is: " + convertedPrice);
            Console.WriteLine("=====================================");
        }
    }
}