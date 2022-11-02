using DentalManagement.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Type = DentalManagement.Data.Enums.Type;

namespace DentalManagement.Data.Entities
{
    public class Account
    {
        [Required(ErrorMessage = "User name is required")]
        [DisplayName("Username: ")]
        [MaxLength(50)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DisplayName("Password: ")]
        [StringLength(50, MinimumLength = 6)]
        public string Password { get; set; }

        [Required]
        [ScaffoldColumn(false)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm:ss tt}")]
        public DateTime? CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        [Required]
        [ScaffoldColumn(false)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm:ss tt}")]
        public DateTime? ModifiedDate { get; set; }

        public string ModifiedBy { get; set; }

        [Required]
        public Type Type { get; set; }
    }
}
