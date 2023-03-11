using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Reflection.PortableExecutable;
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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Collections.Specialized.BitVector32;

namespace calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            foreach (UIElement el in main.Children)
            {
                if (el is Button)
                {
                    ((Button)el).Click += Button_Click;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string stoka = (string)((Button)e.OriginalSource).Content;
            if (stoka == "AC")
            {
                text.Text = "";
            }
            else if (stoka == "=")
            {
                string value = new DataTable().Compute(text.Text, null).ToString();
                text.Text = value;
            }
            else
                text.Text += stoka;

        }


        //Я пытался подключить БД, с помощью которой она будет показывать последние 10 прожатых кнопок, но чет не получилось :(
        /*
         public void UpdateHistoryList(RoutedEventArgs e)
        {
            string connectionString = "Data Source=calculator_history.db";
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Action, Date FROM History ORDER BY Date DESC LIMIT 10";
                using (var command = new SqliteCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string action = reader.GetString(0);
                            string stoka = (string)((Button)e.OriginalSource).Content;
                            if (stoka == "История")
                            {
                                historyListBox.Items.Add($"{action}");
                            }
                            //вывод данных в интерфейс приложения WPF
                            
                        }
                    }
                }
            }
        }*/
    }
}
