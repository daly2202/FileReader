namespace File_Reader.Service
{
    using static File_Reader.Common;

    /// <summary>
    /// The File reader interface
    /// </summary>
    interface IFileReaderService
    {
        /// <summary>
        /// The path property
        /// </summary>
        string Path { get; set; }

        /// <summary>
        /// The encription 
        /// </summary>
        bool Encryption { get; set; }

        /// <summary>
        /// The file type
        /// </summary>
        FileType FileType { get; set; }


        /// <summary>
        /// The read file method
        /// </summary>
        /// <returns>the file stream</returns>
        string ReadFile();
    }
}
