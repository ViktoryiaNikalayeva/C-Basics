
namespace C_Basics
{
    class FileUtils
    {
        private static int numberOfCases;

        public static int InsertNumberOfCases()
        {
            Console.WriteLine("Enter required number of cases:");
            bool converted = int.TryParse(Console.ReadLine(), out numberOfCases);
            if (!converted || numberOfCases < 1)
            {
                numberOfCases = 10;
            }
            return numberOfCases;
        }
    }
}
