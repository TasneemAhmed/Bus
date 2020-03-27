using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BusBookingSystem.Models
{
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "You have enter an Email")]
        [Display(Name = "Email")]
        public string EMail { get; set; }

        [Required(ErrorMessage = "You have enter  User Name")]
        [Display(Name = "Name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "You have enter  Phone Number")]
        [Display(Name = "Phone Number")]
        public long PhoneNumber { get; set; }

        [Required(ErrorMessage = "You have enter Location")]
        [Display(Name = "Location")]
        public string Location { get; set; }
    }
}