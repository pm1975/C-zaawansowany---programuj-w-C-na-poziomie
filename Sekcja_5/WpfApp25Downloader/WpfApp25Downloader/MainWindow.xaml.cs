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

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var currentUrl = WebsiteUrl.Text;

            await Task.Run(async () =>
            {
                var webClient = new WebClient();

                //webClient.DownloadFile(WebsiteUrl.Text, "przykladowy");
                var downloadString = await webClient.DownloadStringTaskAsync(currentUrl);


                Application.Current.Dispatcher.Invoke(() =>
                {
                    DisplayText.Text = "Sukces";
                });

            });


            #region .Wait() .Result
            //var doSomeWorkTask = DoSomeWork();

            //doSomeWorkTask.Wait();

            //var resultInt = doSomeWorkTask.Result;

            //var c = 5;
            #endregion
        }

        private async Task<int> DoSomeWork()
        {
            var a = 2;

            await Task.Delay(2000);

            return 2;
        }
    }
}
