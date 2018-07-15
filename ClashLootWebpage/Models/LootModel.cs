using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClashLootWebpage.Models
{
    public class LootModel
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Date is required.")]
        public DateTime dateNow { get; set; }

        [Required(ErrorMessage = "Gold is required.")]
        public int Gold { get; set; }

        [Required(ErrorMessage = "Elixer required.")]
        public int Elixer { get; set; }

        [Required(ErrorMessage = "Dark is required.")]
        public int Dark { get; set; }

        [Required(ErrorMessage = "Trophies are required.")]
        public int Trophies { get; set; }
    }
}