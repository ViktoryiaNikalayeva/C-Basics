using System.Text;

namespace C_Basics
{
    class FileTask
    {
        public static void SelectCases(string filePath, int numberOfRequiredCases = 10)
        {
            //read input file
            var FileTxtLines = File.ReadAllLines(filePath, Encoding.UTF8);
            if (FileTxtLines.Length - 1 < numberOfRequiredCases)
            {
                Console.WriteLine("The number of required cases is more than number cases in File.txt.");
                return;
            }
            //cut required line numbers
            var selectedCases = new List<string>();
            var random = new Random();
            var indices = new List<int>();
            while (indices.Count < numberOfRequiredCases)
            {
                int index = random.Next(1, FileTxtLines.Length);
                if (indices.Count == 0 || !indices.Contains(index))
                {
                    indices.Add(index);
                    selectedCases.Add(FileTxtLines[index]);
                }
            }
            //save input file without cut lines
            var remainedLinesInFileTxt = FileTxtLines.Except(selectedCases).ToArray();
            selectedCases.Insert(0, FileTxtLines[0]);
            var extension = Path.GetExtension(filePath);
            var resultFilePath = filePath.Replace(extension, $"_res{extension}");
            File.WriteAllLines(filePath, remainedLinesInFileTxt);
            //write cut lines to a new file
            File.WriteAllLines(resultFilePath, selectedCases);
            //return the path of the new file
            Console.WriteLine($"New File path: {resultFilePath}");
        }
    }

}