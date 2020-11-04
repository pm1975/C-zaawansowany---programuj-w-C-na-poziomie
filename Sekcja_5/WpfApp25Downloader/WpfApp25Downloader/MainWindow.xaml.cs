using System.Net;
using System.Threading;
using System.Windows;

namespace WpfApp25Downloader
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var webClient = new WebClient();

            //webClient.DownloadFile(WebsiteUrl.Text, "przykladowy");
            var downloadString = webClient.DownloadString(WebsiteUrl.Text);

            Thread.Sleep(2000);
        }
    }
}
