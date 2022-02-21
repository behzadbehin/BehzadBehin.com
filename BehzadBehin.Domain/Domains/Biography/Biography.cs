using System;
using System.ComponentModel.DataAnnotations;

namespace BehzadBehin.Biographies
{
    public class Biography
    {
        [Required]
        public Guid Id { get; set; }
        
        [Required]
        [Display(Name = "عنوان")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "متن")]
        public string Text { get; set; }
        
    }
}