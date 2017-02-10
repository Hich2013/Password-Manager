using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PasswordManager.Models
{
    public class SecurityEntity
    {
        public int SecurityEntityId { get; set; }

        [Required]
        [StringLength(20)]
        public string Password { get; set; }

        [Required]
        [StringLength(20)]
        public string Application { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}