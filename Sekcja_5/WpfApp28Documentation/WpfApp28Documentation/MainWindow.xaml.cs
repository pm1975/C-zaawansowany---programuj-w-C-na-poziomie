using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp27Atributes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// The string that is downloaded from web
        /// </summary>
        public string DownloadedString { get; set; }

        /// <summary>
        /// This object contains all data from the user and needs to b e validated in order to use it
        /// </summary>
        public FileDownloadingData FileDownloadingData { get; set; } = new FileDownloadingData();

        /// <summary>
        /// Event that is fired when string from web has just been downloaded
        /// </summary>
        public event Action<string> StringDownloaded = (x) => { };

        /// <summary>
        /// Event that is fired when file name was provided by the user
        /// </summary>
        public event Action<string, string> FileNameProvider = (x, y) => { };

        /// <summary>
        /// Default constructor
        /// </summary>
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

        /// <summary>
        /// The function that is fired when user clicks submit button
        /// </summary>
        /// <param name="sender">Sender of this function, that is button</param>
        /// <param name="e">Event args</param>
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

        /// <summary>
        /// Sets all the controls assosiated with download state
        /// </summary>
        private void SetControlsStateAfterDownload()
        {
            Application.Current.Dispatcher.Invoke(() =>
            {
                WebsiteUrl.Visibility = Visibility.Hidden;
                FileName.Visibility = Visibility.Visible;

                SubmitButton.Content = "Click to save";
            });
        }

        /// <summary>
        /// Saves downloaded website to file
        /// </summary>
        /// <param name="fileName">The name of the file to save</param>
        /// <param name="downloadedSting">String downloaded from web</param>
        private void SaveToFile(string fileName, string downloadedSting)
        {
            File.WriteAllText(fileName, downloadedSting);
        }

        /// <summary>
        /// Validates data specified by user
        /// </summary>
        /// <returns>Returns true if validation succeeded, otherwise false</returns>
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
