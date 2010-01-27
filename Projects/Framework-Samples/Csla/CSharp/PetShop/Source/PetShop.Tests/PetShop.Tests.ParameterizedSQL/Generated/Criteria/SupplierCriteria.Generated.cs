//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CSLA 3.8.X CodeSmith Templates.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Supplier.cs'.
//
//     Template: Criteria.Generated.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;
using System.Collections.Generic;
using System.Data.SqlClient;

using Csla;

#endregion

namespace PetShop.Tests.ParameterizedSQL
{
    [Serializable]
    public partial class SupplierCriteria : CriteriaBase
    {
        #region Private Read-Only Members
        
        private readonly Dictionary<string, object> _bag = new Dictionary<string, object>();
        
        #endregion
        
        #region Constructors

        public SupplierCriteria() : base(typeof(Supplier)){}

        public SupplierCriteria(System.Int32 suppId) : base(typeof(Supplier))
        {
            SuppId = suppId;
        }

        
        #endregion
        
        #region Public Properties
        
        #region Read-Write

        public System.Int32 SuppId
        {
            get { return GetValue< System.Int32 >("SuppId"); }
            set { _bag["SuppId"] = value; }
        }

        public System.String Name
        {
            get { return GetValue< System.String >("Name"); }
            set { _bag["Name"] = value; }
        }

        public System.String Status
        {
            get { return GetValue< System.String >("Status"); }
            set { _bag["Status"] = value; }
        }

        public System.String Addr1
        {
            get { return GetValue< System.String >("Addr1"); }
            set { _bag["Addr1"] = value; }
        }

        public System.String Addr2
        {
            get { return GetValue< System.String >("Addr2"); }
            set { _bag["Addr2"] = value; }
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

        public System.String Phone
        {
            get { return GetValue< System.String >("Phone"); }
            set { _bag["Phone"] = value; }
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
        
        #endregion

        #endregion
        
        #region Overrides
        
        public override string ToString()
        {
            if (_bag.Count == 0)
                return "No criterion was specified";

            var result = string.Empty;
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
    }
}