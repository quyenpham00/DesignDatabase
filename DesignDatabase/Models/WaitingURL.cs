using System.ComponentModel.DataAnnotations;

namespace DesignDatabase.Models
{
    public class WaitingURL
    {
        public int Id { get; set; }
        [StringLength(10000)]
        public string Url { get; set; }
        public Status Status { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateAdded { get; set; }
        public int GetUrlTaskId { get; set; }

    }
}
