using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MU.Location
{
    public class FileWriter
    {
        public static Boolean WriteToDisk(string content, string fileName)
        {
            System.IO.StreamWriter fileWriter = null;
            
            try
            {
                string _strFileSavedDirectory = @"C:\LocationGenerator";
                
                if (!Directory.Exists(_strFileSavedDirectory))
                {
                    Directory.CreateDirectory(_strFileSavedDirectory);
                }

                ClearFolder(_strFileSavedDirectory);

                string filePath = _strFileSavedDirectory + @"\" + fileName + ".cs";

                string dirPath = System.IO.Path.GetDirectoryName(filePath);
                if (!System.IO.Directory.Exists(dirPath))
                {
                    System.IO.Directory.CreateDirectory(dirPath);
                }

                if (System.IO.File.Exists(filePath))
                    fileWriter = System.IO.File.AppendText(filePath);
                else
                    fileWriter = System.IO.File.CreateText(filePath);

                fileWriter.Write(content);

                return true;
            }
            catch{}
            finally
            {
                if (fileWriter != null)
                {
                    fileWriter.Close();
                    fileWriter.Dispose();
                }
            }

            return false;
        }
        private static void ClearFolder(string FolderName)
        {
            DirectoryInfo dir = new DirectoryInfo(FolderName);

            foreach (FileInfo fi in dir.GetFiles())
            {
                fi.Delete();
            }

            foreach (DirectoryInfo di in dir.GetDirectories())
            {
                ClearFolder(di.FullName);
                di.Delete();
            }
        }
    }
}
