namespace StringSplitter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] words1 = new String[] { "The", "day", "began", "as", "still", "as", "the", "night", "abruptly", "lighted", "with", "brilliant", "flame" };
            String[] words2 = new String[] { "Hello" };
            String[] words3 = new String[] { "Hello", "Hello" };
            String[] words4 = new String[] { "Well", "Hello", "world" };
            String[] words5 = new String[] { "Hello", "HelloWorld", "Hello", "Hello" };
            String[] words6 = new String[] { "a", "b", "c", "d" };

            string[] result = StringSplitter(words1, 13);
        }

        public static string[] StringSplitter(string[] words, int number)
        {
            var tempString = string.Empty;
            List<string> list = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length <= number)
                {
                    if (words[i].Length + tempString.Length > number)
                    {
                        list.Add(tempString);
                        tempString = string.Empty;
                    }

                    if (tempString.Length == 0)
                    {
                        tempString += words[i];
                    }
                    else
                    {
                        tempString += "-" + words[i];
                    }
                }
            }

            string[] str = list.ToArray();
            return str;
        }
    }
}
