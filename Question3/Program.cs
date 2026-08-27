namespace Question3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileReader reader = new("log.txt");
            FileWriter writer = new("validlogs.txt");

            var list = Tokenizer.Tokenize(reader.GetSource());
            var (output, problems) = Formatter.Formatting(list);

            writer.SetSource(output);

            if (problems.Count > 0)
            {
                FileWriter problemWriter = new("problems.txt");
                problemWriter.SetSource(problems);
            }
        }
    }
}
