//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace T150112_TranPhuHoa_PhoneShopApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class SanPham
    {
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public int MaHSX { get; set; }
        public string BaoHanh { get; set; }
        public string Gia { get; set; }
        public string TinhTrang { get; set; }
    
        public virtual HangSX HangSX { get; set; }
    }
}
