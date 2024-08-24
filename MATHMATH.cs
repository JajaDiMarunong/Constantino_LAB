using System;
using System.Linq;

class LabMath {
    static void Main() {
        Console.WriteLine("Enter your grades: ");
        double[] grades = new double[5];

        for (int i = 0; i < grades.Length; i++) {
            grades[i] = double.Parse(Console.ReadLine());
        }

        double average = grades.Average();
        int roundedAverage = (int)Math.Round(average);

        Console.WriteLine("The average is " + average + " and rounded off to " + roundedAverage);
    }
}