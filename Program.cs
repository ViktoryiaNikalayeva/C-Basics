using System.Collections;

namespace C_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < ArrayWay().Length; i++)
                Console.WriteLine(ArrayWay()[i]);

            foreach (string element in NoArrayWay())
                Console.WriteLine(element);

            string filePath = "C:\\Users\\v2.nikolaeva\\Visual Studio Projects\\C_Basics\\File.txt";
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


        public static IList NoArrayWay()
        {
            ArrayList list1 = new ArrayList() { "Alex", "Dima", "Kate", "Galina", "Ivan" };
            ArrayList list2 = new ArrayList() { "Dima", "Ivan", "Kate" };

            Boolean isEqualNameExist;
            ArrayList resultList = new ArrayList();
            foreach (string element in list1)
            {
                isEqualNameExist = false;
                foreach (string element2 in list2)
                {
                    if (element.Equals(element2))
                    {
                        isEqualNameExist = true;
                    }
                }
                if (isEqualNameExist == false)
                {
                    resultList.Add(element);
                }
            }
            return resultList;
        }
    }
}

