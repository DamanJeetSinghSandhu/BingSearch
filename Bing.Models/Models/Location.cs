
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bing.Models
{
    public class Location
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        
        public string Name { get; set; }
        public TimeSpan AvailFrom { get; set; }
        public TimeSpan AvailTo { get; set; }

        //public DateTime CreatedAt { get; set; }
    }
}
