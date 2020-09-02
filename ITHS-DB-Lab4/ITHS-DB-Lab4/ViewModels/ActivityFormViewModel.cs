using ITHS_DB_Lab4.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ITHS_DB_Lab4.ViewModels
{
    /// <summary>
    /// View model to implement Activity form
    /// </summary>
    public class ActivityFormViewModel
    {
        [Required]
        [StringLength(50)]
        [Display(Name = "Activity name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Type of exercise")]
        public byte CategoryId { get; set; }

        public IEnumerable<Category> Categories { get; set; }
    }
}
