using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace AspCore.Models
{

    public class Person
    {
        [Display(Name = "Person firstname")]
        [StringLength(60,MinimumLength = 3)][Required]
        public string Firstname { get; set; }
        [Display(Name = "Person lastname")]
        [StringLength(100,MinimumLength = 2)][Required]
        public string Lastname { get; set; }
        [Key][HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        [Display(Name = "Email (must be valid)")]        
        [EmailAddress][Required]
        public string Email { get; set; }
    }    
}