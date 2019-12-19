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
        public string ArchievePathString;
        public string DestinationArchievePathString;
        FileInfo fileInfo;
        public Add_To_Archive()
        {
            InitializeComponent();
            
        }


        public Add_To_Archive(string archivePath, string destinatnionstring)
        {
            InitializeComponent();
            ArchievePathString = archivePath;
            DestinationArchievePathString = destinatnionstring;
            Activated += Add_To_Archive_Activated;
        }

        private void Add_To_Archive_Activated(object sender, EventArgs e)
        {
            ArchivePath.Text = ArchievePathString;
            DestinationPath.Text = DestinationArchievePathString;
            
        }

        private void SearchDirSourcePath_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog SearchDirSourceFolderBrowser = new FolderBrowserDialog();
            SearchDirSourceFolderBrowser.RootFolder = Environment.SpecialFolder.MyComputer;
            SearchDirSourceFolderBrowser.ShowDialog();
            ArchivePath.Text = SearchDirSourceFolderBrowser.SelectedPath;
            //DestinationPath.Text = SearchDirSourceFolderBrowser.SelectedPath + ".zip";
        }

        private void SearchDirDestinationPath_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog FileDirFolderBrowser = new FolderBrowserDialog();
            FileDirFolderBrowser.RootFolder = Environment.SpecialFolder.MyComputer;
            FileDirFolderBrowser.ShowDialog();
            fileInfo = new FileInfo(ArchivePath.Text);
            string fileName = fileInfo.Name;
          
            DestinationPath.Text = FileDirFolderBrowser.SelectedPath + fileName + ".zip";
            DestinationArchievePathString = DestinationPath.Text;
        }

        private void Create_Archive_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!Ionic.Zip.ZipFile.IsZipFile(DestinationPath.Text))
                {
                    System.IO.Compression.ZipFile.CreateFromDirectory(ArchivePath.Text, DestinationPath.Text);
                    System.Windows.MessageBox.Show("Archive Created!");
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
                            Ionic.Zip.ZipFile.FixZipDirectory(DestinationPath.Text);
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
    }
    
}
