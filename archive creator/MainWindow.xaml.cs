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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Thread op = new Thread(() =>
            {
                ZipFile.CreateFromDirectory(selectedPath, savedFile);
            });
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;

            folderBrowserDialog.ShowDialog();

            selectedPath = folderBrowserDialog.SelectedPath;

            if (selectedPath != String.Empty)
            {
                filePath = selectedPath + ".zip";
                Add_To_Archive add_To_Archive = new Add_To_Archive(selectedPath,filePath);
                //add_To_Archive.ArchivePath.Text = filePath;
                add_To_Archive.ShowDialog();

                



                //SaveFileDialog saveFileDialog = new SaveFileDialog();
                ////saveFileDialog.FileOk += SaveFileDialog_FileOk;
                //saveFileDialog.DefaultExt = "zip";
                //saveFileDialog.Filter = "Archive Creator (*.zip)|*.zip";
                //saveFileDialog.FileName = "Archive Creator";
                //saveFileDialog.InitialDirectory = selectedPath;
                //DialogResult result = saveFileDialog.ShowDialog();
                //savedFile = saveFileDialog.FileName;
                    //savedFileInfo = new FileInfo(saveFileDialog.FileName);
                    //savedFilePath = savedFile;
                    //saveFileDialog.ShowDialog();
               
                //string converted = result.ToString();

                //if (converted == "OK")
                //{
                //    op.Start();
                //    op.Join();

                //    //ZipFile.CreateFromDirectory(selectedPath, savedFilePath);
                //}
            }




        }

        //private void SaveFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    //Dispatcher.Invoke(DispatcherPriority.Send, new ZipFileDelegate(Zip), selectedPath, savedFilePath);
        //    Thread op = new Thread(() =>
        //    {
        //        ZipFile.CreateFromDirectory(selectedPath, savedFilePath);
        //    });

        //    op.Start();
            
            
        //}

        //public void Zip(string input, string output)
        //{
        //    DispatcherOperation op = Dispatcher.BeginInvoke((Action)(()=>
        //   {
        //       ZipFile.CreateFromDirectory(input, output);
        //   }));

        //}
        //public void Zip(string input, string output)
        //{
        //    ZipFile.CreateFromDirectory(input, output);
        //}
    }
}
