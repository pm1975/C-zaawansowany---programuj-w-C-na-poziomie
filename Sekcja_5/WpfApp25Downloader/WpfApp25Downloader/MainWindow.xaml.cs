using System.Net;
using System.Threading;
using System.Threading.Tasks;
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
            var currentUrl = WebsiteUrl.Text;
            Task.Run(() =>
            {
                var webClient = new WebClient();

                //webClient.DownloadFile(WebsiteUrl.Text, "przykladowy");
                var downloadString = webClient.DownloadString(currentUrl);

                Thread.Sleep(2000);
            });

        }

        private void DoSomeWork()
        {

        }
    }
}
