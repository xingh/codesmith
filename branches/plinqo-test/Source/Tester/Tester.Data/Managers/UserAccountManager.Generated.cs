﻿
//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;

namespace Tester.Data
{
    /// <summary>
    /// The manager class for UserAccount.
    /// </summary>
    public partial class UserAccountManager 
        : CodeSmith.Data.EntityManagerBase<TesterDataManager, Tester.Data.UserAccount>
    {
        /// <summary>
        /// Initializes the <see cref="UserAccountManager"/> class.
        /// </summary>
        static UserAccountManager()
        {
            AddRules();
        }

        /// <summary>
        /// Initializes the <see cref="UserAccountManager"/> class.
        /// </summary>
        /// <param name="manager">The current manager.</param>
        public UserAccountManager(TesterDataManager manager) : base(manager)
        {
            OnCreated();
        }

        /// <summary>
        /// Gets the current context.
        /// </summary>
        protected Tester.Data.TesterDataContext Context
        {
            get { return Manager.Context; }
        }
        
        /// <summary>
        /// Gets the entity for this manager.
        /// </summary>
        protected System.Data.Linq.Table<Tester.Data.UserAccount> Entity
        {
            get { return Manager.Context.UserAccount; }
        }
        
        
        /// <summary>
        /// Creates the key for this entity.
        /// </summary>
        public static CodeSmith.Data.IEntityKey<System.Guid> CreateKey(System.Guid userAccountID)
        {
            return new CodeSmith.Data.EntityKey<System.Guid>(userAccountID);
        }
        
        /// <summary>
        /// Gets an entity by the primary key.
        /// </summary>
        /// <param name="key">The key for the entity.</param>
        /// <returns>
        /// An instance of the entity or null if not found.
        /// </returns>
        /// <remarks>
        /// This method is expecting key to be of type IEntityKey&lt;System.Guid&gt;.
        /// </remarks>
        /// <exception cref="ArgumentException">Thrown when key is not of type IEntityKey&lt;System.Guid&gt;.</exception>
        public override Tester.Data.UserAccount GetByKey(CodeSmith.Data.IEntityKey key)
        {
            if (key is CodeSmith.Data.IEntityKey<System.Guid>)
            {
                var entityKey = (CodeSmith.Data.IEntityKey<System.Guid>)key;
                return GetByKey(entityKey.Key);
            }
            else
            {
                throw new ArgumentException("Invalid key, expected key to be of type IEntityKey<System.Guid>");
            }
        }
        
        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <returns>An instance of the entity or null if not found.</returns>
        public Tester.Data.UserAccount GetByKey(System.Guid userAccountID)
        {
            if (Context.LoadOptions == null) 
                return Query.GetByKey.Invoke(Context, userAccountID);
            else
                return Entity.FirstOrDefault(u => u.UserAccountID == userAccountID);
        }
        
        /// <summary>
        /// Immediately deletes the entity by the primary key from the underlying data source with a single delete command.
        /// </summary>
        /// <returns>The number of rows deleted from the database.</returns>
        public int Delete(System.Guid userAccountID)
        {
            return Entity.Delete(u => u.UserAccountID == userAccountID);
        }

        #region Extensibility Method Definitions
        /// <summary>Called by the static constructor to add shared rules.</summary>
        static partial void AddRules();
        /// <summary>Called when the class is created.</summary>
        partial void OnCreated();
        #endregion
        
        #region Query
        /// <summary>
        /// A private class for lazy loading static compiled queries.
        /// </summary>
        private static partial class Query
        {

            internal static readonly Func<Tester.Data.TesterDataContext, System.Guid, Tester.Data.UserAccount> GetByKey = 
                System.Data.Linq.CompiledQuery.Compile(
                    (Tester.Data.TesterDataContext db, System.Guid userAccountID) => 
                        db.UserAccount.FirstOrDefault(u => u.UserAccountID == userAccountID));

        }
        #endregion
    }
}

