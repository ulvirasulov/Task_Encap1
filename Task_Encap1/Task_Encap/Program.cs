
namespace Task_Encap
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string soz = "  necesen dost  ";

            Console.WriteLine("LastIndexOf: "+CustomLastIndexOf(soz, 'o'));

            Console.WriteLine("Contains: " + CustomContains(soz, "dost"));

            Console.WriteLine("Replace: " + CustomReplace(soz, "dost", "boyuk qardas"));

            Console.WriteLine("Substring: " + CustomSubstring(soz, 9, 13));

            Console.WriteLine("Trim:" + CustomTrim(soz));

        }
        // LastIndexOf()
        public static int CustomLastIndexOf(string str, char ch)
        {
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (str[i] == ch)
                    return i;
            }
            return -1;
        }

        // Contains()
        public static bool CustomContains(string str, string substring)
        {
            return CustomIndexOf(str, substring) != -1;
        }
        // Replace()
        public static string CustomReplace(string str, string oldValue, string newValue)
        {
            int index = CustomIndexOf(str, oldValue);
            while (index != -1)
            {
                str = str.Substring(0, index) + newValue + str.Substring(index + oldValue.Length);
                index = CustomIndexOf(str, oldValue);
            }
            return str;
        }

        // Substring()
        public static string CustomSubstring(string str, int startIndex, int length)
        {
            string result = "";
            for (int i = startIndex; i < startIndex + length && i < str.Length; i++)
            {
                result += str[i];
            }
            return result;
        }

        // Trim()
        public static string CustomTrim(string str)
        {
            int start = 0;
            int end = str.Length - 1;

            while (start <= end && char.IsWhiteSpace(str[start]))
            {
                start++;
            }

            while (end >= start && char.IsWhiteSpace(str[end]))
            {
                end--;
            }

            return CustomSubstring(str, start, end - start + 1);
        }

        // IndexOf()
        public static int CustomIndexOf(string str, string substring)
        {
            for (int i = 0; i <= str.Length - substring.Length; i++)
            {
                bool found = true;
                for (int j = 0; j < substring.Length; j++)
                {
                    if (str[i + j] != substring[j])
                    {
                        found = false;
                        break;
                    }
                }
                if (found)
                    return i;
            }
            return -1;
        }
    }
}
