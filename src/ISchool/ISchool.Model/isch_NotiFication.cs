//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ISchool.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class isch_NotiFication
    {
        public int n_id { get; set; }
        public string n_title { get; set; }
        public string n_text { get; set; }
        public int n_EnterByUser { get; set; }
        public System.DateTime n_EnterDate { get; set; }
    
        public virtual isch_Users isch_Users { get; set; }
    }
}
