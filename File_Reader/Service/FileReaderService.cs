namespace File_Reader.Service
{
    using System.IO;
    using System.Text;
    using System.Xml.Linq;
    using static File_Reader.Common;
    using Extensions;

    /// <summary>
    ///  File reader class
    /// </summary>
    public class FileReaderService : IFileReaderService
    {
        /// <summary>
        /// The file path property
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// The encription 
        /// </summary>
        public bool Encryption { get; set; }

        /// <summary>
        /// The file type
        /// </summary>
        public FileType FileType { get; set; }

        /// <summary>
        /// The read file method
        /// </summary>
        /// <returns>the file stream</returns>
        public string ReadFile()
        {
            if (!string.IsNullOrEmpty(Path))
            {
                switch(FileType)
                {
                    case FileType.Txt:
                        return ReadTxtFile();
                    case FileType.Xml:
                        return ReadXmlFile();
                    case FileType.Json:
                        return ReadJsonFile();
                    default:
                        return string.Empty;
                }
            }
            else
                return "Path is empty";
        }

        /// <summary>
        /// Read text file method
        /// </summary>
        /// <returns>the text file string</returns>
        private string ReadTxtFile()
        {
            StringBuilder sb = new StringBuilder();
            using (var sr = new StreamReader(Path))
            {
                string line = sr.ReadToEnd();
                return Encryption ? line.ToEncryptedString() : line;
            }
        }

        /// <summary>
        /// Read xml file method
        /// </summary>
        /// <returns>the xml file string</returns>
        private string ReadXmlFile()
        {
            var str = XDocument.Load(Path).ToString();
            return str.ToEncryptedString();
        }

        /// <summary>
        /// Read json file method
        /// </summary>
        /// <returns></returns>
        private string ReadJsonFile()
        {
            return ReadTxtFile();
        }
    }
}
