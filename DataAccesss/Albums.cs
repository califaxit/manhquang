//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Albums
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Info { get; set; }
        public string Intro { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<bool> Disable { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<long> CreateByIDUser { get; set; }
        public string Image { get; set; }
        public Nullable<int> Type { get; set; }
        public Nullable<int> IDLang { get; set; }
        public string Code { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public Nullable<long> ViewCount { get; set; }
        public Nullable<long> DownloadCount { get; set; }
    }
}
