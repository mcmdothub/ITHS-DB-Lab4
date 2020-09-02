using System.ComponentModel.DataAnnotations;

namespace ITHS_DB_Lab4.Models
{
    /// <summary>
    /// A descriptor type for Activity
    /// </summary>
    public class Category
    {
        public byte Id { get; set; }

        [Required]
        [StringLength(15)]
        public string Name { get; set; }
    }
}