using Botis_Laura_Lab2.Migrations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Botis_Laura_Lab2.Models
{
    public class Book
    {
        public string ID { get; set; }
        [Display(Name = "Book Title")]
        public string Title { get; set; }
        public string Author { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }
        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }
        public int? PublishingID { get; set; }
        public PublishingDate? Publisher {  get; set; } //navigation property
    }
}
