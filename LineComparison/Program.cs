using System;
namespace LineComparison
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Problem");
            Operation operation1 = new Operation(2, 1, 4, 3);
            Operation operation2 = new Operation(6, 4, 2, 3);
            double line1= operation1.CalculateLength();
            double line2 = operation2 .CalculateLength(); 
            //Equals -UC2
            if (line1.Equals(line2))
                Console.WriteLine("Line1 and Line2 are equal");
            else
                Console.WriteLine("Line1 and Line2 are not equal");
            //CompareTo - UC3
            if (line1.CompareTo(line2) == 0)
                Console.WriteLine("Both Line Are Equal");
            if (line1.CompareTo(line2) > 0)
                Console.WriteLine("Line1 > Line2");
            if (line1.CompareTo(line2) < 0)
                Console.WriteLine("Line1 < Line2");
        }
    }

}

