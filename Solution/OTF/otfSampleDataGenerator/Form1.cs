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
            if (!Directory.Exists(targetFolder))
            {
                Directory.CreateDirectory(targetFolder);
            }

            otf20SampleClasses.GenerateSampleMessages(targetFolder);
            Process.Start("explorer.exe", targetFolder);
            Application.Exit();

        }
    }
}