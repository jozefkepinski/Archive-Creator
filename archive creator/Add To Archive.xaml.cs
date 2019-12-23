using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
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
using Ionic;

namespace archive_creator
{
    /// <summary>
    /// Interaction logic for Add_To_Archive.xaml
    /// </summary>
    /// 

    
    public partial class Add_To_Archive : Window
    {
        public string archievePathString;
        public string destinationArchievePathString; //TODO change global used variables to Fields
        FileInfo fileInfo;
        public string inputDirectory;
        public string compressionLevelString;
        public CompressionLevel compressionLevel { get; set; }




        public Add_To_Archive()
        {

            InitializeCbCompresiontype();
            InitializeComponent();
            


        }


        public Add_To_Archive(string archivePath, string destinatnionstring)
        {
            InitializeComponent();
            InitializeCbCompresiontype();
            archievePathString = archivePath;
            destinationArchievePathString = destinatnionstring;
            Activated += Add_To_Archive_Activated;
           


        }

        private void Add_To_Archive_Activated(object sender, EventArgs e)
        {
            ArchivePath.Text = archievePathString;
            DestinationPath.Text = destinationArchievePathString;
            
        }

        private void SearchDirSourcePath_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog SearchDirSourceFolderBrowser = new FolderBrowserDialog();
            SearchDirSourceFolderBrowser.RootFolder = Environment.SpecialFolder.MyComputer;
            SearchDirSourceFolderBrowser.ShowDialog();
            ArchivePath.Text = SearchDirSourceFolderBrowser.SelectedPath;
            
        }

        private void SearchDirDestinationPath_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog FileDirFolderBrowser = new FolderBrowserDialog();
            FileDirFolderBrowser.RootFolder = Environment.SpecialFolder.MyComputer;
            FileDirFolderBrowser.ShowDialog();
            fileInfo = new FileInfo(ArchivePath.Text);
            string fileName = fileInfo.Name;
          
            DestinationPath.Text = FileDirFolderBrowser.SelectedPath +"\\"+ fileName + ".zip";
            destinationArchievePathString = DestinationPath.Text;
        }

        private void Create_Archive_Click(object sender, RoutedEventArgs e)
        {
            destinationArchievePathString = DestinationPath.Text;
            compressionLevelString = CbCompresiontype.Text;
            CompressionLevelFunc(compressionLevelString);
            try
            {
                if (!Ionic.Zip.ZipFile.IsZipFile(destinationArchievePathString))
                {
                    inputDirectory = ArchivePath.Text;
                    ZipFileasync(inputDirectory, destinationArchievePathString,compressionLevel);

                }
                else
                {
                    MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Do you want rewrite existing file?","Rewrite Confirmation", MessageBoxButton.YesNoCancel);

                    switch (messageBoxResult)
                    {
                        //case MessageBoxResult.None:
                        //    break;
                        //case MessageBoxResult.OK:
                        //    break;
                        case MessageBoxResult.Cancel:
                            break;
                        case MessageBoxResult.Yes:
                            Ionic.Zip.ZipFile.FixZipDirectory(destinationArchievePathString);
                            System.Windows.MessageBox.Show("File rewrited!");
                            break;
                        case MessageBoxResult.No:
                            break;
                        default:
                            break;
                    }

                    
                }
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        public async Task ZipFileasync(string inputFolder, string outputFile, CompressionLevel compressionLevel)
        {
            await Task.Run( ()=> {
                System.IO.Compression.ZipFile.CreateFromDirectory(inputFolder, outputFile,compressionLevel,true);
                System.Windows.MessageBox.Show("Archive Created!");

            });
    
        }


        private void InitializeCbCompresiontype()
        {
            string[] compressionLevel = new string[] { "Optimal", "Fastest", "NoCompression" };
            foreach (var item in compressionLevel)
            {
                CbCompresiontype.Items.Add(item);
            }
            
        }


        public CompressionLevel CompressionLevelFunc(string compLevel)
        {
            switch (compLevel)
            {
                case "Optimal":
                    compressionLevel = CompressionLevel.Optimal;
                    break;

                case "Fastest":
                    compressionLevel = CompressionLevel.Fastest;
                    break;
                case "NoCompression":
                    compressionLevel = CompressionLevel.NoCompression;
                    break;

            }
            return compressionLevel;
        }

        private void CbCompresiontype_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CbCompresiontype.Items.Refresh();
            compressionLevelString = CbCompresiontype.Text;
        }
    }
    
}
