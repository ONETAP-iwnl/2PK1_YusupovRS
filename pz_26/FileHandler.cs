using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;

namespace pz_26
{
    class FileHandler
    {
        private static readonly string dataFolderPath = @"C:\Users\romka\Source\Repos\ONETAP-iwnl\2PK1_YusupovRS\pz_26\data\";

        public static void CreateFile(string fileName)
        {
            if (File.Exists(dataFolderPath + fileName))
            {
                MessageBox.Show("File already exists.");
                return;
            }

            try
            {
                File.Create(dataFolderPath + fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void SaveFile(string fileName, string fileContent)
        {
            try
            {
                File.WriteAllText(dataFolderPath + fileName, fileContent);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static string OpenFile(string fileName)
        {
            string fileContent = "";

            try
            {
                fileContent = File.ReadAllText(dataFolderPath + fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return fileContent;
        }

        public static void DeleteFile(string fileName)
        {
            try
            {
                File.Delete(dataFolderPath + fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
