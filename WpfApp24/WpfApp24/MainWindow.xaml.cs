using System;
using System.Collections.Generic;
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

namespace WpfApp24
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static string connectionString = "Server=127.0.0.1; Port = 5432; Userid=postgres ;Password=master123!; SslMode=Disable; Database=Journal2";
        Npgsql.NpgsqlConnection connection;
        public MainWindow()
            
        {
            InitializeComponent();
            connection = new Npgsql.NpgsqlConnection(connectionString);
            connection.Open();
           
        }
        
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(Pages.Class1.role);
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            connection.Close();
        }
        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            
            MainFrame.Navigate(Pages.Class1.user);
        }
    }
}
