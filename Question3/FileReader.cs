namespace Question3
{
    class FileReader(string path)
    {
        public List<string> GetSource()
        {
            string source = "";
            while ((source = file.ReadLine()) != null)
            {
                if (source != null)
                {
                    fileInfo.Add(source);
                } 
            }
            return fileInfo;
        }

        private List<string> fileInfo = new();
        private StreamReader file = new(path);
    }
}
