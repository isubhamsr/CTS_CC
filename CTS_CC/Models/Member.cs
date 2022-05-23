using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CTS_CC.Models
{
    public class Member
    {
        [Key]
        public int _id { get; set; }
        [Display(Name = "Name")]
        public string _name { get; set; }
        [Required(ErrorMessage ="Asdsd")]
        [Display(Name = "Address")]
        public string _address { get; set; }
        [Display(Name = "VoterId")]
        public string _voterId { get; set; }
        [Display(Name = "Voted")]
        public bool _isVoted { get; set; } = false;
    }
}