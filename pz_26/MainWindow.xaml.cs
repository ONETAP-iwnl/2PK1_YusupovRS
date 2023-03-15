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

        private void NewFileMenuItem_Click(object sender, RoutedEventArgs e)
        {
            var newFileDialog = new NewFileDialog();
            if (newFileDialog.ShowDialog() == true)
            {
                string fileName = newFileDialog.FileName;
                FileHandler.CreateFile(fileName);
                listbox.Items.Add(Path.GetFileName(fileName));
                rtb.Document.Blocks.Clear();
            }
        }
        
    }
}
