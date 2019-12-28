using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
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

        //public string selectedPath;
        //public string savedFile;
        
        private string selectedPath { get; set; }
        public string filePath { get; set; }


        public MainWindow()
        {
     
            InitializeComponent();
            CustomizeDesign();
       
        }

        private void CustomizeDesign()
        {
            archiveOptionsSubenu.Visibility = Visibility.Collapsed;
            aboutSubenu.Visibility = Visibility.Collapsed;
        }

        private void HideSubmenu()
        {
            if (archiveOptionsSubenu.IsVisible==true)
            {
                archiveOptionsSubenu.Visibility = Visibility.Collapsed;
            }
            if (aboutSubenu.IsVisible == true)
            {
                aboutSubenu.Visibility = Visibility.Collapsed;
            }
        }


        private void ShowSubMenu(DockPanel submenu)
        {
            if (submenu.IsVisible==false)
            {
                HideSubmenu();
                submenu.Visibility = Visibility.Visible;
            }
            else
            {
                submenu.Visibility = Visibility.Collapsed;
            }
        }

        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm!=null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.DataContext = childForm;
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
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
                //Add_To_Archive add_To_Archive = new Add_To_Archive(selectedPath,filePath);
                //add_To_Archive.ShowDialog();
                //OpenChildForm(new Add_To_Archive(selectedPath,filePath));
                

            }
            HideSubmenu();
        }

        private void ExtractArchiveButton_Click(object sender, RoutedEventArgs e) 
        {
            OpenFileDialog fileBrowserDialog = new OpenFileDialog();

            fileBrowserDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;

            fileBrowserDialog.ShowDialog();

            selectedPath = fileBrowserDialog.FileName;

            if (selectedPath != String.Empty)
            {
                filePath = selectedPath.Substring(0,selectedPath.Length-4);
                Extract_Archive extract_Archive = new Extract_Archive(selectedPath, filePath);
                extract_Archive.ShowDialog();

            }
            HideSubmenu();
        }

        private void btnArchive_Click(object sender, RoutedEventArgs e)
        {
            ShowSubMenu(archiveOptionsSubenu);
        }

        private void about_Click(object sender, RoutedEventArgs e)
        {
            ShowSubMenu(aboutSubenu);
        }
    }
}
