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
    /// The manager class for Automobile.
    /// </summary>
    public partial class AutomobileManager 
        : CodeSmith.Data.EntityManagerBase<TesterDataManager, Tester.Data.Automobile>
    {
        /// <summary>
        /// Initializes the <see cref="AutomobileManager"/> class.
        /// </summary>
        static AutomobileManager()
        {
            AddRules();
        }

        /// <summary>
        /// Initializes the <see cref="AutomobileManager"/> class.
        /// </summary>
        /// <param name="manager">The current manager.</param>
        public AutomobileManager(TesterDataManager manager) : base(manager)
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
        protected System.Data.Linq.Table<Tester.Data.Automobile> Entity
        {
            get { return Manager.Context.Automobile; }
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

        }
        #endregion
    }
}
