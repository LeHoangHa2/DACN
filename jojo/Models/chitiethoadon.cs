//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace jojo.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class chitiethoadon
    {
        public chitiethoadon()
        {
            this.bangphus = new HashSet<bangphu>();
        }
    
        public int id { get; set; }
        public int idhoadon { get; set; }
        public int idspchinh { get; set; }
        public int soluong { get; set; }
        public int thanhtien { get; set; }
    
        public virtual ICollection<bangphu> bangphus { get; set; }
        public virtual hoadon hoadon { get; set; }
        public virtual sanpham sanpham { get; set; }
    }
}
