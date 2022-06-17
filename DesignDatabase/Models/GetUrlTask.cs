using System.ComponentModel.DataAnnotations;

namespace DesignDatabase.Models
{
    public class GetUrlTask
    {
        public int Id { get; set; }
        public int NumberOfUrl { get; set; }
        public Status Status { get; set; }
        public int TotalTimeRunning { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateRun { get; set; }
    }
}
