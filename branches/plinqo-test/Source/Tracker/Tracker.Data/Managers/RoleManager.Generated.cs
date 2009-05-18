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

namespace Tracker.Data
{
    /// <summary>
    /// The manager class for Role.
    /// </summary>
    public partial class RoleManager 
        : CodeSmith.Data.EntityManagerBase<TrackerDataManager, Tracker.Data.Role>
    {
        /// <summary>
        /// Initializes the <see cref="RoleManager"/> class.
        /// </summary>
        static RoleManager()
        {
            AddRules();
        }

        /// <summary>
        /// Initializes the <see cref="RoleManager"/> class.
        /// </summary>
        /// <param name="manager">The current manager.</param>
        public RoleManager(TrackerDataManager manager) : base(manager)
        {
            OnCreated();
        }

        /// <summary>
        /// Gets the current context.
        /// </summary>
        protected Tracker.Data.TrackerDataContext Context
        {
            get { return Manager.Context; }
        }
        
        /// <summary>
        /// Gets the entity for this manager.
        /// </summary>
        protected System.Data.Linq.Table<Tracker.Data.Role> Entity
        {
            get { return Manager.Context.Role; }
        }
        
        
        /// <summary>
        /// Creates the key for this entity.
        /// </summary>
        public static CodeSmith.Data.IEntityKey<int> CreateKey(int id)
        {
            return new CodeSmith.Data.EntityKey<int>(id);
        }
        
        /// <summary>
        /// Gets an entity by the primary key.
        /// </summary>
        /// <param name="key">The key for the entity.</param>
        /// <returns>
        /// An instance of the entity or null if not found.
        /// </returns>
        /// <remarks>
        /// This method is expecting key to be of type IEntityKey&lt;int&gt;.
        /// </remarks>
        /// <exception cref="ArgumentException">Thrown when key is not of type IEntityKey&lt;int&gt;.</exception>
        public override Tracker.Data.Role GetByKey(CodeSmith.Data.IEntityKey key)
        {
            if (key is CodeSmith.Data.IEntityKey<int>)
            {
                var entityKey = (CodeSmith.Data.IEntityKey<int>)key;
                return GetByKey(entityKey.Key);
            }
            else
            {
                throw new ArgumentException("Invalid key, expected key to be of type IEntityKey<int>");
            }
        }
        
        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <returns>An instance of the entity or null if not found.</returns>
        public Tracker.Data.Role GetByKey(int id)
        {
            if (Context.LoadOptions == null) 
                return Query.GetByKey.Invoke(Context, id);
            else
                return Entity.FirstOrDefault(r => r.Id == id);
        }
        
        /// <summary>
        /// Immediately deletes the entity by the primary key from the underlying data source with a single delete command.
        /// </summary>
        /// <returns>The number of rows deleted from the database.</returns>
        public int Delete(int id)
        {
            return Entity.Delete(r => r.Id == id);
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

            internal static readonly Func<Tracker.Data.TrackerDataContext, int, Tracker.Data.Role> GetByKey = 
                System.Data.Linq.CompiledQuery.Compile(
                    (Tracker.Data.TrackerDataContext db, int id) => 
                        db.Role.FirstOrDefault(r => r.Id == id));

        }
        #endregion
    }
}

