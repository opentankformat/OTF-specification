using otfSampleDataGenerator.sampleClasses;
using System.Diagnostics;

namespace otfSampleDataGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string targetFolder = string.Format("{0}{1}", Application.StartupPath, "samples");

            //Generate versions
            otf20SampleClasses.GenerateSampleMessages(testFolder(string.Format("{0}\\{1}\\", targetFolder, "otf20")));
            otf21SampleClasses.GenerateSampleMessages(testFolder(string.Format("{0}\\{1}\\", targetFolder, "otf21")));

            //Jump to explorer where generated files are shown
            Process.Start("explorer.exe", targetFolder);
            Application.Exit();

        }

        private string testFolder(string folder) 
        {
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
            return folder;
        }

    }
}