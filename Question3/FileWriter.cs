namespace Question3
{
    class FileWriter
    {
        private StreamWriter writer;

        public FileWriter(string path)
        {
            writer = new StreamWriter(path);
        }

        public void SetSource(List<string> source)
        {
            foreach (var item in source)
            {
                writer.WriteLine(item);
            }
            writer.Close();
        }
    }
}