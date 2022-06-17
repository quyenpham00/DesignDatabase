using System.ComponentModel.DataAnnotations;

namespace DesignDatabase.Models
{
    public class ImageURL
    {
        [Key]
        public int Id { get; set; }
        public string Url { get; set; }
    }
}
