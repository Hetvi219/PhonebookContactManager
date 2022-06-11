using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PhonebookContactManager.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }

        [Display(Name = "Phone Number")]
        [Required]
        public string PhoneNumber { get; set; }

        public string Description { get; set; }

        [Display(Name = "Address")]
        public int AddressId { get; set; }
        public Address Address { get; set; }
    }
}
