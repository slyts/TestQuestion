namespace Question1
{
    class CompressionManager
    {
        public static string Compress(string input)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;

            string output = "";
            int counter = 1;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == input[i - 1])
                {
                    counter++;
                }
                else
                {
                    output += input[i - 1];
                    if (counter > 1)
                        output += counter;
                    counter = 1;
                }
            }

            output += input[input.Length - 1];
            if (counter > 1)
                output += counter;
            return output;
        }

        public static string Decompress(string input)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;

            string output = "";
            int i = 0;

            while (i < input.Length)
            {
                string number = "";
                char c = input[i];
                i++;

                while (i < input.Length && char.IsDigit(input[i]))
                {
                    number += input[i];
                    i++;
                }

                int count = number.Length > 0 ? int.Parse(number) : 1;
                output += new string(c, count);

            }
            return output;
        }


    }
}
