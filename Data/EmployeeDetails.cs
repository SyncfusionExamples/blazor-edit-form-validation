using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Blazor_EditForm.Data
{
    /// <summary>
    /// Get the employee details 
    /// </summary>
    public class EmployeeDetails
    {
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
        public string Gender { get; set; } = "male";
        [Required]
        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string PhoneNumber { get; set; }
        [Required]
        public DateTime? DOB { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        [Range(0, 20, ErrorMessage = "The Experience range should be 0 to 20")]
        public decimal? TotalExperience { get; set; }
    }

    public class Countries
    {
        public string Name { get; set; }
        public string Code { get; set; }

        public List<Countries> GetCountries()
        {
            List<Countries> Country = new List<Countries>
            {
                new Countries() { Name = "Australia", Code = "AU" },
                new Countries() { Name = "United Kingdom", Code = "UK" },
                new Countries() { Name = "United States", Code = "US" },
            };
            return Country;
        }
    }
    public class Cities
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string CountryCode { get; set; }
        public List<Cities> GetCities()
        {
            List<Cities> CityName = new List<Cities>
            {
                new Cities() { Name = "New York", CountryCode = "US", Code="US-101" },
                new Cities() { Name = "Virginia", CountryCode = "US", Code="US-102" },
                new Cities() { Name = "Washington", CountryCode = "US", Code="US-103" },
                new Cities() { Name = "Victoria", CountryCode = "AU", Code="AU-101" },
                new Cities() { Name = "Tasmania", CountryCode = "AU", Code="AU-102" },
                new Cities() { Name = "Queensland", CountryCode = "AU", Code="AU-103" },
                new Cities() { Name = "London", CountryCode = "UK", Code="UK-101" },
                new Cities() { Name = "Manchester", CountryCode = "UK", Code="UK-102" },
                new Cities() { Name = "Ashford", CountryCode = "UK", Code="UK-103" }
            };
            return CityName;
        }
    }
}
