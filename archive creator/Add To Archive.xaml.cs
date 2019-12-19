using System;
using System.Collections.Generic;
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
    /// Interaction logic for Add_To_Archive.xaml
    /// </summary>
    /// 

    
    public partial class Add_To_Archive : Window
    {
        public string ArchievePathString;
        public string DestinationArchievePathString;
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
            DestinationPath.Text = SearchDirSourceFolderBrowser.SelectedPath + ".zip";
        }

        private void SearchDirDestinationPath_Click(object sender, RoutedEventArgs e)
        {
            //FolderBrowserDialog SearchDirSourceFileBrowser = new FolderBrowserDialog();
            //SearchDirSourceFileBrowser.RootFolder = Environment.SpecialFolder.MyComputer;
            //SearchDirSourceFileBrowser.ShowDialog();
            //DestinationPath.Text = SearchDirSourceFileBrowser.SelectedPath;
        }
    }
    
}
