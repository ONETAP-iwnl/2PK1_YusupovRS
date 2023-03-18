using Microsoft.Win32;
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
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Path = System.IO.Path;

namespace pz_26
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static readonly string dataFolderPath = @"C:\Users\romka\Source\Repos\ONETAP-iwnl\2PK1_YusupovRS\pz_26\data\";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AboutMenuItem_Click(object sender, RoutedEventArgs e)
        {
            // Создание нового окна
            About aboutWindow = new About();

            // Отображение окна в модальном режиме
            aboutWindow.ShowDialog();
        }


        private void OpenFile_Click(object sender, RoutedEventArgs e)
        {
            
            OpenFileDialog openFileDialog = new OpenFileDialog(); // Открыть диалог выбора файла
            if (openFileDialog.ShowDialog() == true)
            {
                
                string fileContent = File.ReadAllText(openFileDialog.FileName); // Прочитать содержимое файла

                
                rtb.Document.Blocks.Clear(); // Очистить RichTextBox перед вставкой нового текста
                rtb.Document.Blocks.Add(new Paragraph(new Run(fileContent))); // Отобразить содержимое файла в RichTextBox
            }
        }

        private void NewFile_Click(object sender, RoutedEventArgs e)
        {
            NewFileDialog newFiles = new NewFileDialog();
            newFiles.ShowDialog();
        }

        private void SaveFile_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog saveFileDialog = new Microsoft.Win32.SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == true)
            {
                string filename = saveFileDialog.FileName;
                File.WriteAllText(filename, new TextRange(rtb.Document.ContentStart, rtb.Document.ContentEnd).Text);
            }
        }
    }
}
