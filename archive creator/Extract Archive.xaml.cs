using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace archive_creator
{
    /// <summary>
    /// Interaction logic for Extract_Archive.xaml
    /// </summary>
    public partial class Extract_Archive : Window //TODO Finish this class
    {

        private string inputFile { get; set; }
        private string outputDirectory { get; set; }


        public Extract_Archive()
        {
            InitializeComponent();
        }


        public Extract_Archive(string zipInputDirectory, string zipOutputDirectory)
        {
            InitializeComponent();

           inputFile = zipInputDirectory;
           outputDirectory = zipOutputDirectory;

            Activated += Extract_Archive_Activated;

        }

        private void Extract_Archive_Activated(object sender, EventArgs e)
        {
            Zip_file.Text = inputFile;
            Extract_directory.Text = outputDirectory;
        }
    }
}
