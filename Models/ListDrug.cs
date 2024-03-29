﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Medimall.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class ListDrug
    {
        public int ListId { get; set; }
        [Display(Name = "Mã sản phẩm")]
        [Required(ErrorMessage = "Không được để trống")]
        public Nullable<int> ProductId { get; set; }
        [Required(ErrorMessage = "Không được để trống")]
        [Display(Name = "Mã khách hàng")]
        public Nullable<int> AccountId { get; set; }

        public virtual Account Account { get; set; }
        public virtual Product Product { get; set; }
    }
}