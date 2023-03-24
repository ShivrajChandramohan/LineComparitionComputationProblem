using NonStaticLineComparision;

namespace LineComparisionComputationProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Line Computation Problems");
            //LineDifference Difference = new LineDifference();
            //Difference.LineDistance();

            // CkeckLineEquality Equality = new CkeckLineEquality();
            // Equality.LineEquality();

            CompareTwoLines twoLines = new CompareTwoLines();
            twoLines.CompareLines();
        }
    }
}