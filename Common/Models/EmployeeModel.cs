//----------------------------------------------------
// <copyright file="EmployeeModel.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------

namespace Common.Models
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// EmployeeModel class for get and set the employee data
    /// </summary>
    public class EmployeeModel
    {
        /// <summary>
        /// Gets or sets First Name of employee
        /// </summary>
        /// Set the field compulsory to fill by annotation
        [Required(ErrorMessage = "FirstName is required")]
        ////Set the length of field by regular expression
        [RegularExpression("^([a-zA-Z]{2,})$", ErrorMessage = "FirstName should contain atleast 2 or more characters")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets Last Name of employee 
        /// </summary>
        /// Set the field compulsory to fill by annotation
        [Required(ErrorMessage = "LastName is required")]
        ////Set the length of field by regular expression
        [RegularExpression("^([a-zA-Z]{2,})$", ErrorMessage = "LastName should contain atleast 2 or more characters")]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets Address of employee 
        /// </summary>
        /// Set the field compulsory to fill by annotation
        [Required(ErrorMessage = "Address is required")]
        ////Validate the field by regular expression
        [RegularExpression("^([a-zA-Z0-9.,@ ]{10,})$", ErrorMessage = "Address should contain atleast 10 or more characters")]
        public string EmpAddress { get; set; }

        /// <summary>
        /// Gets or sets Mobile Number of employee 
        /// </summary>
        /// Set the field compulsory to fill by annotation
        [Required(ErrorMessage = "Mobile no. is required")]
        ////Validate and set the length of Mobile Number by regular expression
        [RegularExpression("^([789][0-9]{9})$", ErrorMessage = "Please enter 10 digit mobile no. starts from 7 or 8 or 9")]
        public string MobileNumber { get; set; }

        /// <summary>
        /// Gets or sets Zip Code of employee 
        /// </summary>
        /// Set the field compulsory to fill by annotation
        [Required(ErrorMessage = "Zip code required")]
        ////Validate Zip code by regular expression
        [RegularExpression("^([0-9]{6})$", ErrorMessage = "Please enter 6 digit zip code")]        
        public string ZipCode { get; set; }
    }
}
