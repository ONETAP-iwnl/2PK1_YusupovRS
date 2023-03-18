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
using System.Windows.Shapes;

namespace pz_26
{
    /// <summary>
    /// Логика взаимодействия для NewFileDialog.xaml
    /// </summary>
    public partial class NewFileDialog : Window
    {
        public static readonly string dataFolderPath = @"C:\Users\romka\Source\Repos\ONETAP-iwnl\2PK1_YusupovRS\pz_26\data\";

        public NewFileDialog()
        {
            InitializeComponent();
        }

        private void NewFile_Click(object sender, RoutedEventArgs e)
        {

            //я не понимаю как сделать открытие файл
            
        }
    }
}
