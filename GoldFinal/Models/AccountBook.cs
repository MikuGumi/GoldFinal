namespace GoldFinal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web.Mvc;

    [Table("AccountBook")]
    public partial class AccountBook
    {
        public Guid Id { get; set; }

        [Display(Name = "����")]
        public int Categoryyy { get; set; }

        [Range(0, int.MaxValue)]
        [Display(Name = "���B")]
        public int Amounttt { get; set; }

        [Remote("OverToday", "Valid", ErrorMessage = "�������j�󤵤�")]
        [Display(Name = "���")]
        public DateTime Dateee { get; set; }

        [Required]
        [StringLength(500)]
        [Display(Name = "�Ƶ�")]
        public string Remarkkk { get; set; }
    }
}
