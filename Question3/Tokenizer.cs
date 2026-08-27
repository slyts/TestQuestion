using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Question3
{
    class Tokenizer
    {
        public static List<string> Tokenize(List<string> list)
        {
            List<string> tokenList = new();
            for (int i = 0; i < list.Count; i++)
            {
                string line = list[i];
                string current = "";

                for (int j = 0; j < line.Length; j++)
                {
                    char c = line[j];

                    if (c == ' ' || c == '|')
                    {
                        if (current.Length > 0)
                        {
                            tokenList.Add(current);
                            current = "";
                        }
                    }
                    else
                    {
                        current += c;
                    }
                }

                if (current.Length > 0)
                    tokenList.Add(current);
            }
            var listToken = SwitchWords(tokenList);
            return listToken;
        }

        private static List<string> SwitchWords(List<string> list)
        {
            List<string> result = new List<string>();

            for (int i = 0; i < list.Count; i++)
            {
                string word = list[i];

                if (word == "Версия" && i + 1 < list.Count && list[i + 1] == "программы:")
                {
                    result.Add("VERSION");
                    i++;
                }

                else if (word == "Код" && i + 1 < list.Count && list[i + 1] == "устройства:")
                {
                    result.Add("DEVICE");
                    i++;
                }
                else
                {
                    result.Add(word);
                }
            }

            return result;
        }
    }
}
