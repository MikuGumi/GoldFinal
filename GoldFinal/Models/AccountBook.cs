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

        [Display(Name = "類型")]
        public int Categoryyy { get; set; }

        [Range(0, int.MaxValue)]
        [Display(Name = "金額")]
        public int Amounttt { get; set; }

        [Remote("OverToday", "Valid", ErrorMessage = "日期不能大於今天")]
        [Display(Name = "日期")]
        public DateTime Dateee { get; set; }

        [Required]
        [StringLength(500)]
        [Display(Name = "備註")]
        public string Remarkkk { get; set; }
    }
}
