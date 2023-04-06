using ghoul.Core;
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

namespace ghoul.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void CharactersPage_Button(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new Characters());
        }
        private void MainPage_Button(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new MainPage());
        }
        private void QuotesPage_Button(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new Quotes());
        }
        private void WatchPage_Button(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new Watch());
        }
    }
}
