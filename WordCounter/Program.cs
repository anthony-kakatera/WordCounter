namespace WordCounter
{
    public class WordCounter
    {
        public static void Main(string[] args)
        {
            //ask for path/s
            Console.WriteLine("Provide a valid file path/s and separate any additional paths by comma ','");
            string filePaths = Console.ReadLine();
            //C:\Users\akakatera\Desktop\Angle Dimension Test\5. Word Counter\SampleText.txt

            //spliting string
            string[] Paths = filePaths.Split(',');

            //loop through array and call wordCount method
            for (int i = 0; i < Paths.Length; i++)
            {
                //calling word count
                string printout = wordCount(Paths[i]);
                Console.WriteLine(printout);
            }
            // Keep the console window open in debug mode.
            Console.ReadLine();
        }

        public static string wordCount(String filePath)
        {
            // Read the file as one string.
            string text = System.IO.File.ReadAllText(@filePath);

            //get all lines
            string[] lines = System.IO.File.ReadAllLines(@filePath);

            //get all words
            string[] words = text.Split(' ');

            //getting size in bytes 
            long size = text.Length;

            //print out
            return lines.Length + "  " + words.Length + "  " + size;
        }
    }
}
    