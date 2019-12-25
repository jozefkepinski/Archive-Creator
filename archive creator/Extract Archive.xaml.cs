using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace archive_creator
{
    /// <summary>
    /// Interaction logic for Extract_Archive.xaml
    /// </summary>
    public partial class Extract_Archive : Window
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

        private void ExtractArchiveButton_Click(object sender, RoutedEventArgs e)
        {
            inputFile = Zip_file.Text;
            outputDirectory = Extract_directory.Text;

            try
            {

                var directory = new DirectoryInfo(outputDirectory);

                if (!directory.Exists)
                {
                    directory.Create();
                    ZipFileasync(inputFile, outputDirectory);
                }

                else
                {
                    ZipFileasync(inputFile, outputDirectory);
                    System.Windows.MessageBox.Show("File Extracted!");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task ZipFileasync(string inputFileName, string outputDirectory)//TODO if file exists try overwrite
        {
            await Task.Run(() => {
                System.IO.Compression.ZipFile.ExtractToDirectory(inputFileName, outputDirectory);
                System.Windows.MessageBox.Show("Archive Extracted!");

            });

        }

        private void ZipFileSearchButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileBrowserDialog = new OpenFileDialog();

            fileBrowserDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;

            fileBrowserDialog.ShowDialog();

            Zip_file.Text =  fileBrowserDialog.FileName;
        }

        private void ExtractDirectorySearch_ButtonClick(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;

            folderBrowserDialog.ShowDialog();

            Extract_directory.Text = folderBrowserDialog.SelectedPath;
        }
    }
}
