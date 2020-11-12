using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;

namespace WpfApp27Atributes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string DownloadedString { get; set; }

        public FileDownloadingData FileDownloadingData { get; set; } = new FileDownloadingData();

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
                FileDownloadingData.FileName = FileName.Text;

                if (ValidateData())
                {
                    FileNameProvider.Invoke(FileDownloadingData.FileName, DownloadedString);
                }
                return;
            }

            FileDownloadingData.Url = WebsiteUrl.Text;
            if (ValidateData())
            {
                await Task.Run(async () =>
                {
                    var webClient = new WebClient();

                    var downloadString = await webClient.DownloadStringTaskAsync(FileDownloadingData.Url);

                    StringDownloaded.Invoke(downloadString);

                });
            }
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

        private bool ValidateData()
        {
            var validationContext = new ValidationContext(FileDownloadingData);
            var results = new List<ValidationResult>();

            if (Validator.TryValidateObject(FileDownloadingData, validationContext, results, true))
            {
                return true;
            }

            foreach (var result in results)
            {
                MessageBox.Show(result.ErrorMessage);
            }
            return false;
        }
    }
}
