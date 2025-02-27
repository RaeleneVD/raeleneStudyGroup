using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace raeleneStudyGroup.Models
{
	public class raeleneStudyGroupModel
	{
        [Display(Name = "STUDENT NUMBER")]
        public int StudentNumber { get; set; } = 0;

        [Display(Name = "NAME")]
        public string FirstName { get; set; } = "";

        [Display(Name = "SURNAME")]
        public string LastName { get; set; } = "";

        [Display(Name = "EMAIL ADDRESS")]
        public string Email { get; set; } = "";
    }
}