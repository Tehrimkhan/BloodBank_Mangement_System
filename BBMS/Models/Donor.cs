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

    public partial class Donor
    {
        [DisplayName("ID")]
        public int D_id { get; set; }
        [Required(ErrorMessage = "This Field Is Required!")]
        [DisplayName("Username")]
        public string D_name { get; set; }
        [Required(ErrorMessage = "This Field Is Required!")]
        [DisplayName("Age")]
        public Nullable<int> D_age { get; set; }
        [Required(ErrorMessage = "This Field Is Required!")]
        [DisplayName("Weight")]
        public Nullable<double> D_weight { get; set; }
        [Required(ErrorMessage = "This Field Is Required!")]
        [DisplayName("Haemoglobin")]
        public Nullable<double> D_haemoglobin { get; set; }
        [Required(ErrorMessage = "This Field Is Required!")]
        [DisplayName("Blood Name")]
        public string D_blood { get; set; }
    }
}
