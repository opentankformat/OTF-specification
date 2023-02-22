using otfSampleDataGenerator.sampleClasses;

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
            string targetFolder = "c:\\temp\\";
            otf20SampleClasses.GenerateSampleMessages(targetFolder);
        }
    }
}