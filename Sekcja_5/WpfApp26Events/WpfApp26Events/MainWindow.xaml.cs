using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp26Events
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string DownloadedString { get; set; }

        public event Action<string> StringDownloaded = (x) => { };
        public event Action<string, string> FileNameProvider = (x, y) => { };
        public MainWindow()
        {
            InitializeComponent();

            StringDownloaded += (x) => SetControlsStateAfterDownload();
            StringDownloaded += (x) => DownloadedString = x;
            StringDownloaded += (x) => 
            {
                Application.Current.Dispatcher.Invoke(() =>
                {
                    DisplayText.Text = "Podaj nazwę pliku";

                    MessageBox.Show("Podaj nazwę pliku");
                });
            };

            FileNameProvider += SaveToFile;
            FileNameProvider += (x, y) =>
            {
                Application.Current.Dispatcher.Invoke(() =>
                {
                    DisplayText.Text = "Zapisano plik";

                    MessageBox.Show("Zapisano plik");
                });
            };

            FileName.Visibility = Visibility.Hidden;
        }


        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            if (DownloadedString != null)
            {
                FileNameProvider.Invoke(FileName.Text, DownloadedString);
                return;
            }

            var currentUrl = WebsiteUrl.Text;

            await Task.Run(async () =>
            {
                var webClient = new WebClient();

                var downloadString = await webClient.DownloadStringTaskAsync(currentUrl);

                StringDownloaded.Invoke(downloadString);

            });
        }

        private void SetControlsStateAfterDownload()
        {
            Application.Current.Dispatcher.Invoke(() =>
            {
                WebsiteUrl.Visibility = Visibility.Hidden;
                FileName.Visibility = Visibility.Visible;

                SubmitButton.Content = "Click to save";
            });
        }

        private void SaveToFile(string fileName, string downloadedSting)
        {
            File.WriteAllText(fileName, downloadedSting);
        }
    }
}
