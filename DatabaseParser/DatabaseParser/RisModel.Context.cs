﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class risTabulky : DbContext
    {
        public risTabulky()
            : base("name=risTabulky")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<akcia> akcia { get; set; }
        public DbSet<den_v_tyzdni> den_v_tyzdni { get; set; }
        public DbSet<denne_menu> denne_menu { get; set; }
        public DbSet<jazyk> jazyk { get; set; }
        public DbSet<jedlo> jedlo { get; set; }
        public DbSet<jedlo_surovina> jedlo_surovina { get; set; }
        public DbSet<menu> menu { get; set; }
        public DbSet<menu_jedlo> menu_jedlo { get; set; }
        public DbSet<menu_napoj> menu_napoj { get; set; }
        public DbSet<napoj> napoj { get; set; }
        public DbSet<napoj_surovina> napoj_surovina { get; set; }
        public DbSet<objednavka> objednavka { get; set; }
        public DbSet<objednavka_menu> objednavka_menu { get; set; }
        public DbSet<obrazok> obrazok { get; set; }
        public DbSet<otvaracie_hodiny> otvaracie_hodiny { get; set; }
        public DbSet<platnost_zaznamu> platnost_zaznamu { get; set; }
        public DbSet<podnik> podnik { get; set; }
        public DbSet<preklad> preklad { get; set; }
        public DbSet<stol> stol { get; set; }
        public DbSet<surovina> surovina { get; set; }
        public DbSet<text> text { get; set; }
        public DbSet<typ_jedla> typ_jedla { get; set; }
        public DbSet<typ_napoja> typ_napoja { get; set; }
        public DbSet<typ_uctu> typ_uctu { get; set; }
        public DbSet<ucet> ucet { get; set; }
        public DbSet<zmena_otvaracich_hodin> zmena_otvaracich_hodin { get; set; }
    }
}
