using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PhonebookContactManager.Models
{
    public class Address
    {
        public int Id { get; set; }

        [Display(Name = "Address Line 1")]
        [Required]
        public string AddressOne { get; set; }

        [Display(Name = "Address Line 2")]
        public string AddressTwo { get; set; }
        [Required]
        public string City { get; set; }

        [Display(Name = "State/Province")]
        [Required]
        public string StateOrProvince { get; set; }

        [Display(Name = "Zip/PostalCode")]
        [Required]
        public string ZipOrPostalCode { get; set; }
        [Required]
        public string Country { get; set; }

        public ICollection<Person> Persons { get; set; }
    }
}
