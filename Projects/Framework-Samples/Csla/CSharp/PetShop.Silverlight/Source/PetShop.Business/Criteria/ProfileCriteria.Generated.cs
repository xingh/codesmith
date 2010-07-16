﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.2, CSLA Templates: v3.0.0.1817, CSLA Framework: v4.0.0.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Profile.cs'.
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

namespace PetShop.Business
{
    [Serializable]
    public partial class ProfileCriteria : CriteriaBase<ProfileCriteria>, IGeneratedCriteria
    {
        #region Private Read-Only Members
        
        private readonly Dictionary<string, object> _bag = new Dictionary<string, object>();
        
        #endregion
        
        #region Constructors

        public ProfileCriteria(){}

        public ProfileCriteria(System.Int32 uniqueID)
        {
            UniqueID = uniqueID;
        }
        
        #endregion
        
        #region Public Properties
        
        #region Read-Write

        public System.Int32 UniqueID
        {
            get { return GetValue< System.Int32 >("UniqueID"); }
            set { _bag["UniqueID"] = value; }
        }

        public System.String Username
        {
            get { return GetValue< System.String >("Username"); }
            set { _bag["Username"] = value; }
        }

        public System.String ApplicationName
        {
            get { return GetValue< System.String >("ApplicationName"); }
            set { _bag["ApplicationName"] = value; }
        }

        public System.Boolean? IsAnonymous
        {
            get { return GetValue< System.Boolean? >("IsAnonymous"); }
            set { _bag["IsAnonymous"] = value; }
        }

        public System.DateTime? LastActivityDate
        {
            get { return GetValue< System.DateTime? >("LastActivityDate"); }
            set { _bag["LastActivityDate"] = value; }
        }

        public System.DateTime? LastUpdatedDate
        {
            get { return GetValue< System.DateTime? >("LastUpdatedDate"); }
            set { _bag["LastUpdatedDate"] = value; }
        }

        #endregion
        
        #region Read-Only

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
                return "[dbo].Profiles";
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