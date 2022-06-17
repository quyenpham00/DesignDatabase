using System.ComponentModel.DataAnnotations;

namespace DesignDatabase.Models
{
    public class House
    {
        [Key]
        public int Id { get; set; }
        public String PostId { get; set; }
        public String Url { get; set; }
        [DataType(DataType.Date)]
        public DateTime Posted { get; set; }
        public String Address { get; set; }

        public String Province { get; set; }
        public double Acreage { get; set; }
        public double Price { get; set; }
        public String Title { get; set; }
        public HouseType HouseType { get; set; }
        public String Region { get; set; }
        public List<ImageURL> ImageURLs { get; set; }
    }
}
