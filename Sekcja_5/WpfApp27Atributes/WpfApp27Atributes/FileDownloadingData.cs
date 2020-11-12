using System.ComponentModel.DataAnnotations;

namespace WpfApp27Atributes
{
    /*
     * Walidowanie za pomocą adnotacji
     */
    public class FileDownloadingData
    {
        [Required]
        [StringLength(100, MinimumLength = 5)]
        public string Url { get; set; }

        public string FileName { get; set; }
    }
}
