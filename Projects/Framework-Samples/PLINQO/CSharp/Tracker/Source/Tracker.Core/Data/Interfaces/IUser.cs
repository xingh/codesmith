﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Linq;

namespace Tracker.Core.Data.Interfaces
{
    /// <summary>
    /// Interface representing the dbo.User table.
    /// </summary>
    public interface IUser
    {
        /// <summary>
        /// Gets the Id column value.
        /// </summary>
        int Id { get; set; }
        /// <summary>
        /// Gets or sets the EmailAddress column value.
        /// </summary>
        string EmailAddress { get; set; }
        /// <summary>
        /// Gets or sets the FirstName column value.
        /// </summary>
        string FirstName { get; set; }
        /// <summary>
        /// Gets or sets the LastName column value.
        /// </summary>
        string LastName { get; set; }
        /// <summary>
        /// Gets or sets the Avatar column value.
        /// </summary>
        System.Data.Linq.Binary Avatar { get; set; }
        /// <summary>
        /// Gets or sets the CreatedDate column value.
        /// </summary>
        System.DateTime CreatedDate { get; set; }
        /// <summary>
        /// Gets or sets the ModifiedDate column value.
        /// </summary>
        System.DateTime ModifiedDate { get; set; }
        /// <summary>
        /// Gets the RowVersion column value.
        /// </summary>
        System.Data.Linq.Binary RowVersion { get; set; }
        /// <summary>
        /// Gets or sets the PasswordHash column value.
        /// </summary>
        string PasswordHash { get; set; }
        /// <summary>
        /// Gets or sets the PasswordSalt column value.
        /// </summary>
        string PasswordSalt { get; set; }
        /// <summary>
        /// Gets or sets the Comment column value.
        /// </summary>
        string Comment { get; set; }
        /// <summary>
        /// Gets or sets the IsApproved column value.
        /// </summary>
        bool IsApproved { get; set; }
        /// <summary>
        /// Gets or sets the LastLoginDate column value.
        /// </summary>
        Nullable<System.DateTime> LastLoginDate { get; set; }
        /// <summary>
        /// Gets or sets the LastActivityDate column value.
        /// </summary>
        System.DateTime LastActivityDate { get; set; }
        /// <summary>
        /// Gets or sets the LastPasswordChangeDate column value.
        /// </summary>
        Nullable<System.DateTime> LastPasswordChangeDate { get; set; }
        /// <summary>
        /// Gets or sets the AvatarType column value.
        /// </summary>
        string AvatarType { get; set; }
        /// <summary>
        /// Gets or sets the <see cref="T:Tracker.Core.Data.Audit"/> association.
        /// </summary>
        System.Data.Linq.EntitySet<Tracker.Core.Data.Audit> AuditList { get; set; }
        /// <summary>
        /// Gets or sets the <see cref="T:Tracker.Core.Data.Task"/> association.
        /// </summary>
        System.Data.Linq.EntitySet<Tracker.Core.Data.Task> AssignedTaskList { get; set; }
        /// <summary>
        /// Gets or sets the <see cref="T:Tracker.Core.Data.Task"/> association.
        /// </summary>
        System.Data.Linq.EntitySet<Tracker.Core.Data.Task> CreatedTaskList { get; set; }
        /// <summary>
        /// Gets or sets the <see cref="T:Tracker.Core.Data.UserRole"/> association.
        /// </summary>
        System.Data.Linq.EntitySet<Tracker.Core.Data.UserRole> UserRoleList { get; set; }
    }
}
