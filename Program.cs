using System.Collections;

namespace C_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < ArrayWay().Length; i++)
                Console.WriteLine(ArrayWay()[i]);

            Console.WriteLine(NoArrayWay());

            string filePath = @$"{Environment.CurrentDirectory}/Resources/File.txt"; ;
            int numberOfCases = FileUtils.InsertNumberOfCases();
            FileTask.SelectCases(filePath, numberOfCases);
            Console.ReadLine();
        }

        public static string[] ArrayWay()
        {
            int counter = 0;
            string[] array1 = { "Alex", "Dima", "Kate", "Galina", "Ivan" };
            string[] array2 = { "Dima", "Ivan", "Kate" };
            string[] resultArray = new string[100];
            bool isEqualElemеntExist;
            for (int i = 0; i < array1.Length; i++)
            {
                isEqualElemеntExist = false;
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array1[i].Equals(array2[j]))
                    {
                        isEqualElemеntExist = true;
                    }
                }

                if (isEqualElemеntExist == false)
                {
                    counter++;
                    resultArray[counter] = array1[i];
                }
            }
            return resultArray;

        }


        public static Boolean NoArrayWay()
        {
            var list1 = new List<string>() { "Alex", "Dima", "Kate", "Galina", "Ivan" };
            var list2 = new List<string>() { "Dima", "Ivan", "Kate" };
            bool AreListsEqual = list1.Equals(list2);
            return AreListsEqual;
        }
    }
}

