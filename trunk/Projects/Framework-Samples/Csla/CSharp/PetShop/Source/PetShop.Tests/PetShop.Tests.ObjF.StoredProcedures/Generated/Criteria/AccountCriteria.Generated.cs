﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.2, CSLA Templates: v3.0.0.1872, CSLA Framework: v3.8.4.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Account.cs'.
//
//     Template: Criteria.Generated.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;


using System.Data.SqlClient;

using Csla;

#endregion

namespace PetShop.Tests.ObjF.StoredProcedures
{
    [Serializable]
    public partial class AccountCriteria : CriteriaBase, IGeneratedCriteria
    {
        #region Private Read-Only Members
        
        private readonly Dictionary<string, object> _bag = new Dictionary<string, object>();
        
        #endregion
        
        #region Constructors

        public AccountCriteria() : base(typeof(Account)){}

        public AccountCriteria(System.Int32 accountId) : base(typeof(Account))
        {
            AccountId = accountId;
        }
        
        #endregion
        
        #region Public Properties
        
        #region Read-Write

        public System.Int32 AccountId
        {
            get { return GetValue< System.Int32 >("AccountId"); }
            set { _bag["AccountId"] = value; }
        }

        public System.Int32 UniqueID
        {
            get { return GetValue< System.Int32 >("UniqueID"); }
            set { _bag["UniqueID"] = value; }
        }

        public System.String Email
        {
            get { return GetValue< System.String >("Email"); }
            set { _bag["Email"] = value; }
        }

        public System.String FirstName
        {
            get { return GetValue< System.String >("FirstName"); }
            set { _bag["FirstName"] = value; }
        }

        public System.String LastName
        {
            get { return GetValue< System.String >("LastName"); }
            set { _bag["LastName"] = value; }
        }

        public System.String Address1
        {
            get { return GetValue< System.String >("Address1"); }
            set { _bag["Address1"] = value; }
        }

        public System.String Address2
        {
            get { return GetValue< System.String >("Address2"); }
            set { _bag["Address2"] = value; }
        }

        public System.String City
        {
            get { return GetValue< System.String >("City"); }
            set { _bag["City"] = value; }
        }

        public System.String State
        {
            get { return GetValue< System.String >("State"); }
            set { _bag["State"] = value; }
        }

        public System.String Zip
        {
            get { return GetValue< System.String >("Zip"); }
            set { _bag["Zip"] = value; }
        }

        public System.String Country
        {
            get { return GetValue< System.String >("Country"); }
            set { _bag["Country"] = value; }
        }

        public System.String Phone
        {
            get { return GetValue< System.String >("Phone"); }
            set { _bag["Phone"] = value; }
        }

        #endregion
        
        #region Read-Only

        public bool Address2HasValue
        {
            get { return _bag.ContainsKey("Address2"); }
        }

        public bool PhoneHasValue
        {
            get { return _bag.ContainsKey("Phone"); }
        }

        /// <summary>
        /// Returns a list of all the modified properties and values.
        /// </summary>
        public Dictionary<string, object> StateBag
        {
            get
            {
                return _bag;
            }
        }

        /// <summary>
        /// Returns a list of all the modified properties and values.
        /// </summary>
        public string TableFullName
        {
            get
            {
                return "[dbo].Account";
            }
        }

        #endregion

        #endregion

        #region Overrides
        
        public override string ToString()
        {
            var result = string.Empty;
            var cancel = false;
            
            OnToString(ref result, ref cancel);
            if(cancel && !string.IsNullOrEmpty(result))
                return result;
            
            if (_bag.Count == 0)
                return "No criterion was specified.";

            foreach (KeyValuePair<string, object> key in _bag)
            {
                result += string.Format("[{0}] = '{1}' AND ", key.Key, key.Value);
            }

            return result.Remove(result.Length - 5, 5);
        }

        #endregion

        #region Private Methods
        
        private T GetValue<T>(string name)
        {
            object value;
            if (_bag.TryGetValue(name, out value))
                return (T) value;
        
            return default(T);
        }
        
        #endregion
        
        #region Partial Methods
        
        partial void OnToString(ref string result, ref bool cancel);
        
        #endregion
        
    }
}