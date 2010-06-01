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
using System.Data.Linq;

namespace Tester.Data
{
    /// <summary>
    /// The query extension class for User.
    /// </summary>
    public static partial class UserExtensions
    {

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        public static Tester.Data.User GetByKey(this IQueryable<Tester.Data.User> queryable, int id)
        {
            var entity = queryable as System.Data.Linq.Table<Tester.Data.User>;
            if (entity != null && entity.Context.LoadOptions == null)
                return Query.GetByKey.Invoke((Tester.Data.TesterDataContext)entity.Context, id);
            
            return queryable.FirstOrDefault(u => u.Id == id);
        }

        /// <summary>
        /// Immediately deletes the entity by the primary key from the underlying data source with a single delete command.
        /// </summary>
        /// <param name="table">Represents a table for a particular type in the underlying database containing rows are to be deleted.</param>
        /// <returns>The number of rows deleted from the database.</returns>
        public static int Delete(this System.Data.Linq.Table<Tester.Data.User> table, int id)
        {
            return table.Delete(u => u.Id == id);
        }
        
        /// <summary>
        /// Gets a query for <see cref="User.UserName"/>.
        /// </summary>
        public static IQueryable<Tester.Data.User> GetByUserName(this IQueryable<Tester.Data.User> queryable, string userName)
        {
            return queryable.Where(u => u.UserName == userName);
        }
        
        /// <summary>
        /// Gets a query for <see cref="User.Password"/>.
        /// </summary>
        public static IQueryable<Tester.Data.User> GetByPassword(this IQueryable<Tester.Data.User> queryable, string password)
        {
            return queryable.Where(u => u.Password == password);
        }
        
        /// <summary>
        /// Gets a query for <see cref="User.EmailAddress"/>.
        /// </summary>
        public static IQueryable<Tester.Data.User> GetByEmailAddress(this IQueryable<Tester.Data.User> queryable, string emailAddress)
        {
            return queryable.Where(u => u.EmailAddress == emailAddress);
        }
        
        /// <summary>
        /// Gets a query for <see cref="User.Comments"/>.
        /// </summary>
        public static IQueryable<Tester.Data.User> GetByComments(this IQueryable<Tester.Data.User> queryable, string comments)
        {
            return queryable.Where(u => object.Equals(u.Comments, comments));
        }

        #region Query
        /// <summary>
        /// A private class for lazy loading static compiled queries.
        /// </summary>
        private static partial class Query
        {

            internal static readonly Func<Tester.Data.TesterDataContext, int, Tester.Data.User> GetByKey = 
                System.Data.Linq.CompiledQuery.Compile(
                    (Tester.Data.TesterDataContext db, int id) => 
                        db.User.FirstOrDefault(u => u.Id == id));

        }
        #endregion
    }
}
