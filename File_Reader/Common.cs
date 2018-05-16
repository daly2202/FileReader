namespace File_Reader
{
    /// <summary>
    /// Consts
    /// </summary>
    public static class Common
    {
        public const string TxtFilter = "Txt files (*.txt)|*.txt";
        public const string XmlFilter = "Xml files (*.xml)|*.xml";
        public const string JsonFilter = "Json files (*.json)|*.json";
        public const string TxtExtension = ".txt";
        public const string XmlExtension = ".xml";
        public const string JsonExtension = ".json";
        public const string AdminRoleFilter = "*Admin*";
        public const string OtherRoleFilter = "*Other*";
        public enum FileType { Txt, Xml, Json };
    }
}
