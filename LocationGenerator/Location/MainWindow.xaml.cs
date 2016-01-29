using Dapper;
using Location;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows;

namespace MU.Location
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

        private void btnCSharpGenerator_Click(object sender, RoutedEventArgs e)
        {
            string str = new CSharpCodeGenerator().GeneratorCode();

            if (!string.IsNullOrEmpty(str) && FileWriter.WriteToDisk(str, "LocationHandler"))
            {
                MessageBox.Show("Location Handler C# Sharp Code Generated");
            }
            else
            {
                MessageBox.Show("OOPs!! There's nothing to create...");
            }
            
        }

        private void btnJQueryGenerator_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnTestCShrpGenerator_Click(object sender, RoutedEventArgs e)
        {
            TestLocation tester = new TestLocation();
            tester.ShowDialog();
        }

       

    }
}
