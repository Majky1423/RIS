//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseParser
{
    using System;
    using System.Collections.Generic;
    
    public partial class podnik
    {
        public podnik()
        {
            this.menu = new HashSet<menu>();
            this.otvaracie_hodiny = new HashSet<otvaracie_hodiny>();
            this.zmena_otvaracich_hodin = new HashSet<zmena_otvaracich_hodin>();
        }
    
        public int id_podniku { get; set; }
        public string nazov { get; set; }
        public int telefon_cislo { get; set; }
        public int ico { get; set; }
        public string adresa { get; set; }
    
        public virtual ICollection<menu> menu { get; set; }
        public virtual ICollection<otvaracie_hodiny> otvaracie_hodiny { get; set; }
        public virtual ICollection<zmena_otvaracich_hodin> zmena_otvaracich_hodin { get; set; }
    }
}
