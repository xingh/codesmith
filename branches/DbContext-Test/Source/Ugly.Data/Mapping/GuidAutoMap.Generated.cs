﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ugly.Data.Mapping
{
    public partial class GuidAutoMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ugly.Data.Entities.GuidAuto>
    {
        public GuidAutoMap()
        {
            // table
            ToTable("GuidAuto", "dbo");

            // keys
            HasKey(t => t.GuidID);

            // Properties
            Property(t => t.GuidID)
                .HasColumnName("GuidID")
                .IsRequired();
            Property(t => t.AutoID)
                .HasColumnName("AutoID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            Property(t => t.Name)
                .HasColumnName("Name")
                .HasMaxLength(50)
                .IsRequired();
            Property(t => t.Flag)
                .HasColumnName("Flag")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed)
                .HasMaxLength(8)
                .IsRowVersion()
                .IsRequired();

            // Relationships

            InitializeMapping();
        }
    }
}
