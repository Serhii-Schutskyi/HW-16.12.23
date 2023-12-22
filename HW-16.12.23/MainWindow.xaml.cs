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

namespace HW_16._12._23
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
        
        private void Search_GotFocus(object sender, RoutedEventArgs e)
        {
            Search.Text = "";
        }

        private void Google_Click(object sender, RoutedEventArgs e)
        {
            if (Search.Text == "" || Search.Text == "Введіть текст для пошуку")
            { myBrowser.Navigate(new Uri($"https://www.google.com/")); }
            else
            {
                string query = Search.Text.Replace(" ", "+");
                myBrowser.Navigate(new Uri($"https://www.google.com/search?q={query}"));
            }
        }

        private void Bing_Click(object sender, RoutedEventArgs e)
        {
            if (Search.Text == "" || Search.Text == "Введіть текст для пошуку")
            { myBrowser.Navigate(new Uri($"https://www.bing.com/")); }
            else
            {
                string query = Search.Text.Replace(" ", "+");
                myBrowser.Navigate(new Uri($"https://www.bing.com/search?q={query}"));
            }
        }

        private void Bing_Images_Click(object sender, RoutedEventArgs e)
        {
            if (Search.Text == "" || Search.Text == "Введіть текст для пошуку")
            { myBrowser.Navigate(new Uri("https://www.bing.com/images/search?q=")); }
            else
            {
                string query = Search.Text.Replace(" ", "+");
                myBrowser.Navigate(new Uri($"https://www.bing.com/images/search?q={query}"));
            }
        }
        private void City_GotFocus(object sender, RoutedEventArgs e)
        {
            City.Text = "";
        }

        private void Weather_Click(object sender, RoutedEventArgs e)
        {
            string query;
            if (City.Text == "Введіть місто") { query = "Черкаси"; }
            else if (City.Text == "") { query = "Черкаси"; }
            else { query = City.Text.Replace(" ", "+"); }
            myBrowser.Navigate(new Uri($"https://ua.sinoptik.ua/погода-{query}"));
        }

        private void Weather10_Click(object sender, RoutedEventArgs e)
        {
            string query;
            if (City.Text == "Введіть місто") { query = "Черкаси"; }
            else if (City.Text == "") { query = "Черкаси"; }
            else { query = City.Text.Replace(" ", "+"); }
            myBrowser.Navigate(new Uri($"https://ua.sinoptik.ua/погода-{query}/10-днів"));
        }
    }
}
