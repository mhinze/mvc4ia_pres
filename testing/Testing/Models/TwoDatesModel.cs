using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Testing.Models
{
    public class TwoDatesModel
    {
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime? Earlier { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [Remote("Later", "Validate",
            ErrorMessage = "Later must be after Earlier",
            AdditionalFields = "Earlier")]
        public DateTime? Later { get; set; }
    }
}