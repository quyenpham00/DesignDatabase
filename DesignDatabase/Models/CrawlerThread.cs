using System.ComponentModel.DataAnnotations;

namespace DesignDatabase.Models
{
    public class CrawlerThread
    {
        public int Id { get; set; }
        public int NumberOfRealEstate { get; set; }
        public Status Status { get; set; }
        public int TotalTimeRunning { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateRun { get; set; }
    }
}
