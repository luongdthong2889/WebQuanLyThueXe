﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoDB2.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBThueXeEntities : DbContext
    {
        public DBThueXeEntities()
            : base("name=DBThueXeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CHITIETDONDAT> CHITIETDONDATs { get; set; }
        public virtual DbSet<CHITIETHOPDONG> CHITIETHOPDONGs { get; set; }
        public virtual DbSet<CHITIETTHANHLYHOPDONG> CHITIETTHANHLYHOPDONGs { get; set; }
        public virtual DbSet<DONDATXE> DONDATXEs { get; set; }
        public virtual DbSet<HOPDONG> HOPDONGs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<LOAIXE> LOAIXEs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<THANHLYHOPDONG> THANHLYHOPDONGs { get; set; }
        public virtual DbSet<XE> XEs { get; set; }
    }
}
