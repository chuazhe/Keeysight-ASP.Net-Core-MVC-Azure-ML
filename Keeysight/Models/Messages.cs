using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Keeysight.Models
{
    public class Messages
    {
        //Primary Key
        [Key]
        public int MessagesId { get; set; }
        //public string SenderUserId { get; set; }
        // public int GroupId { get; set; }
        [Required]
        public string Content { get; set; }
        /*
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        [Display(Name = "Date of Birthday")]
        //Show date only
        [DataType(DataType.Date)]*/

        //If you want "FullName" to be displayed as "Full Name", 
        //use DisplayAttribute or DisplayName attribute.
        //DisplayName attribute is in System.ComponentModel namespace.
        //[DisplayAttribute(Name="Full Name")]
        //[Display(Name = "Full Name")]
        /*
         Good to know! Was about to implement a custom attribute to load the display value from the .resx file, then happened on this question. Display attribute is the way to go when developing localized applications. –
             */

        //        //To get time in 12 hour notation with AM PM
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm:ss tt}")]

        // If gender is NULL, "Gender not specified" text will be displayed.
        //[DisplayFormat(NullDisplayText = "Gender not specified")]

        //[NotMapped]  
        //https://www.c-sharpcorner.com/article/using-net-core-data-annotation/

            /*
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime DateTime { get; set; }
        */
    }
}
