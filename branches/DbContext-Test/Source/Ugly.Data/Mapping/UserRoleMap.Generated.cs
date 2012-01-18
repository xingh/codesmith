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
    public partial class UserRoleMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ugly.Data.Entities.UserRole>
    {
        public UserRoleMap()
        {
            // table
            ToTable("UserRole", "dbo");

            // keys
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Id)
                .HasColumnName("Id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            Property(t => t.UserId)
                .HasColumnName("UserId")
                .IsRequired();
            Property(t => t.UserName)
                .HasColumnName("UserName")
                .HasMaxLength(50)
                .IsRequired();
            Property(t => t.RoleId)
                .HasColumnName("RoleId")
                .IsRequired();

            // Relationships
            HasRequired(t => t.Role)
                .WithMany(t => t.UserRoleList)
                .HasForeignKey(d => d.RoleId);
            HasRequired(t => t.User)
                .WithMany(t => t.UserRoleList)
                .HasForeignKey(d => new { d.UserId, d.UserName });

            InitializeMapping();
        }
    }
}
