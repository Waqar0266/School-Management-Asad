﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace School_Management_System
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SchoolManagementSystemEntities : DbContext
    {
        public SchoolManagementSystemEntities()
            : base("name=SchoolManagementSystemEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<asset> assets { get; set; }
        public virtual DbSet<@class> classes { get; set; }
        public virtual DbSet<exam> exams { get; set; }
        public virtual DbSet<expense> expenses { get; set; }
        public virtual DbSet<fee> fees { get; set; }
        public virtual DbSet<notice> notices { get; set; }
        public virtual DbSet<Operator> Operators { get; set; }
        public virtual DbSet<paper> papers { get; set; }
        public virtual DbSet<parent> parents { get; set; }
        public virtual DbSet<role> roles { get; set; }
        public virtual DbSet<salary> salaries { get; set; }
        public virtual DbSet<staff_attendance> staff_attendance { get; set; }
        public virtual DbSet<student> students { get; set; }
        public virtual DbSet<student_attendance> student_attendance { get; set; }
        public virtual DbSet<subject> subjects { get; set; }
        public virtual DbSet<teacher> teachers { get; set; }
        public virtual DbSet<test> tests { get; set; }
    }
}