using System.ComponentModel.DataAnnotations;

namespace WpfApp27Atributes
{
    /*
     * Walidowanie za pomocą adnotacji
     */
    /// <summary>
    /// Class that contains user data
    /// </summary>
    public class FileDownloadingData
    {
        /// <summary>
        /// the url to download website from
        /// </summary>
        [Required]
        [StringLength(100, MinimumLength = 5)]
        public string Url { get; set; }

        /// <summary>
        /// The name of the file to save to
        /// </summary>
        public string FileName { get; set; }
    }
}
