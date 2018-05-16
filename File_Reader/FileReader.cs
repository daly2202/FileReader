using File_Reader.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
namespace File_Reader
{
    using System.IO;
    using System.Windows.Forms;
    using static File_Reader.Common;

    public partial class FileReader : Form
    {
        public OpenFileDialog dialog = new OpenFileDialog() { InitialDirectory = Path.GetFullPath(@"..\..\Files") };
        public FileReader()
        {
            InitializeComponent();
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            RTBox.Text = string.Empty;
            txtBoxPath.Text = string.Empty;
            try
            {
                dialog.FileName = rbRoleOthers.Checked ? OtherRoleFilter : "";
                dialog.FileName += rbTxtFileType.Checked ? TxtExtension : rbXmlFileType.Checked ? XmlExtension : JsonExtension;

                dialog.Filter = rbTxtFileType.Checked? TxtFilter : rbXmlFileType.Checked ? XmlFilter : JsonFilter;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtBoxPath.Text = dialog.FileName;
                    Service.IFileReaderService service = new FileReaderService
                    {
                        Path = dialog.FileName,
                        Encryption = ckBoxEncryotion.Checked,
                        FileType = rbTxtFileType.Checked ? FileType.Txt : rbXmlFileType.Checked ? FileType.Xml : FileType.Json
                    };
                    RTBox.Text = service.ReadFile();
                }
            }
            catch(Exception ex)
            {
                RTBox.Text = $"The text file could not be read | Error : {ex}";
            }
        }
    }
}
