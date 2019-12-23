using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

using System.Windows.Forms;
using System.Windows.Threading;

namespace archive_creator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    ///
    
    public partial class MainWindow : Window
    {


        private delegate void ZipFileDelegate(string inputPath, string destinationPath);

        public string selectedPath;
        public string savedFile;
        public string filePath;


      
        public MainWindow()
        {
     
            InitializeComponent();
       
        }

        private void CreateArchiveButton_Click(object sender, RoutedEventArgs e)
        {
            
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;

            folderBrowserDialog.ShowDialog();

            selectedPath = folderBrowserDialog.SelectedPath;

            if (selectedPath != String.Empty)
            {
                filePath = selectedPath + ".zip";
                Add_To_Archive add_To_Archive = new Add_To_Archive(selectedPath,filePath);
                add_To_Archive.ShowDialog();

            }

        }

        private void ExtractArchiveButton_Click(object sender, RoutedEventArgs e) //TODO add anchor to Extract class
        {

        }
    }
}
