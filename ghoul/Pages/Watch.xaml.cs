using ghoul.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Логика взаимодействия для Watch.xaml
    /// </summary>
    public partial class Watch : Page
    {
        public Watch()
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
        void AnimeGo_Button(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://animego.org/anime/tokyo-ghoul-sv1-243") { UseShellExecute = true });

        }
        void YummyAnime_Button(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://yummyanime.tv/190-tokijskij-gul-a.html") { UseShellExecute = true });

        }
        private void JutSu_Button(object sender, RoutedEventArgs e)
        {

            Process.Start(new ProcessStartInfo("https://jut.su/tokushu/") { UseShellExecute = true });
        }
    }
}
