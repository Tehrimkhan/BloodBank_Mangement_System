//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BBMS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;

    public partial class Reciever
    {
        [Required(ErrorMessage = "This Field Is Required!")]
        [DisplayName("ID")]
        public int R_id { get; set; }
        [Required(ErrorMessage = "This Field Is Required!")]
        [DisplayName("Username")]
        public string R_name { get; set; }
        [Required(ErrorMessage = "This Field Is Required!")]
        [DisplayName("Blood Group")]
        public string R_bloodname { get; set; }
        [Required(ErrorMessage = "This Field Is Required!")]
        [DisplayName("Age")]
        public Nullable<int> R_age { get; set; }
        [Required(ErrorMessage = "This Field Is Required!")]
        [DisplayName("Phone Number")]
        public string R_phnnum { get; set; }
    }
}
