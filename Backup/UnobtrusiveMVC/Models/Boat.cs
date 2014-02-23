using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace UnobtrusiveMVC.Models
{
    public class Boat
    {
        [Required]
        [StringLength(20,ErrorMessage="Avast! Yarr boat name must be less than 20 characters matey!")]
        [DisplayName("Boat Name")]
        public string BoatName { get; set; }

        [Required]
        [StringLength(20)]
        [RegularExpression(@"Captain.*",ErrorMessage="Your captain name must start Captain!")]
        [DisplayName("Captain's Name")]
        public string CaptainName { get; set; }

        [UIHint("Slider")]
        [Required,Range(0,100)]
        public int CaptainSaltinessPercent { get; set; }
    }
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    sealed public class CustomAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            int parsed = 0;
            if (Int32.TryParse((string)value, out parsed))
            {
                if (parsed % 2 == 0) { return true; }
            }
            return false;
        }
    }
}