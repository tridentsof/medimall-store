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
    using Medimall.Helper;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Web;

    public partial class Category
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Category()
        {
            this.Products = new HashSet<Product>();
        }

        [Display(Name = "Mã danh mục")]
        public string CategoryId { get; set; }
        [Required(ErrorMessage = "Không được để trống")]
        [Display(Name = "Tên danh mục")]
        public string CategoryName { get; set; }

        [Display(Name = "Picture")]
        [NotMapped]
        [ValidateFile]
        public HttpPostedFileBase Photo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
    }
}