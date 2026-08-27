namespace Question3
{
    class Formatter
    {

        public static (List<string> result, List<string> problems) Formatting(List<string> list)
        {
            List<string> resultList = new List<string>();
            List<string> problems = new List<string>();
            for (int i = 0; i < list.Count; i += 5)
            {
                if (i + 4 >= list.Count)
                    break;

                string date = list[i];
                string time = list[i + 1];
                string level = list[i + 2];
                string method = list[i + 3];
                string msg = list[i + 4];

                if (date.Length < 8 || time.Length < 8 || string.IsNullOrEmpty(level))
                {
                    problems.Add($"{date} {time} {level} {method} {msg}");
                    continue;
                }

                string newDate = "";
                for (int j = 0; j < date.Length; j++)
                {
                    if (date[j] == '.')
                        newDate += '-';
                    else
                        newDate += date[j];
                }
                date = newDate;

                if (date[4] == '-')
                {
                    string[] parts = date.Split('-');
                    date = parts[2] + "-" + parts[1] + "-" + parts[0];
                }

                if (level == "INFORMATION") level = "INFO";
                else if (level == "WARNING") level = "WARN";

                if (msg == "DEVICE")
                {
                    if (i + 5 < list.Count)
                        msg = list[i + 5];
                    else
                        msg = "Ошибка: нет сообщения";
                }

                if (method == "VERSION")
                {
                    method = "DEFAULT";
                    msg = "Версия программы: " + msg;
                }

                else if (method.Contains("."))
                {
                    msg = "Код устройства: " + msg;
                }

                string result = date + "\t" + time + "\t" + level + "\t" + method + "\t" + msg;

                resultList.Add(result);
                result = "";
                
            }
            return (resultList, problems);
        }
    }
}