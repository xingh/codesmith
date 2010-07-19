﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.2, CSLA Templates: v3.0.0.1825, CSLA Framework: v4.0.0.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Item.cs'.
//
//     Template: Criteria.Generated.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

using Csla.Core;
#if SILVERLIGHT
using Csla.Serialization;
#endif
using Csla.Serialization.Mobile;

#if !SILVERLIGHT
using System.Data.SqlClient;
#endif

using Csla;

#endregion

namespace PetShop.Business
{
    [Serializable]
    public partial class ItemCriteria : CriteriaBase<ItemCriteria>, IGeneratedCriteria
    {
        #region Private Read-Only Members
        
        private readonly Dictionary<string, object> _bag = new Dictionary<string, object>();
        
        #endregion
        
        #region Constructors

        public ItemCriteria(){}

        public ItemCriteria(System.String itemId)
        {
            ItemId = itemId;
        }
        
        #endregion
        
        #region Public Properties
        
        #region Read-Write

        public System.String ItemId
        {
            get { return GetValue< System.String >("ItemId"); }
            set { _bag["ItemId"] = value; }
        }

        public System.String ProductId
        {
            get { return GetValue< System.String >("ProductId"); }
            set { _bag["ProductId"] = value; }
        }

        public System.Decimal? ListPrice
        {
            get { return GetValue< System.Decimal? >("ListPrice"); }
            set { _bag["ListPrice"] = value; }
        }

        public System.Decimal? UnitCost
        {
            get { return GetValue< System.Decimal? >("UnitCost"); }
            set { _bag["UnitCost"] = value; }
        }

        public System.Int32? Supplier
        {
            get { return GetValue< System.Int32? >("Supplier"); }
            set { _bag["Supplier"] = value; }
        }

        public System.String Status
        {
            get { return GetValue< System.String >("Status"); }
            set { _bag["Status"] = value; }
        }

        public System.String Name
        {
            get { return GetValue< System.String >("Name"); }
            set { _bag["Name"] = value; }
        }

        public System.String Image
        {
            get { return GetValue< System.String >("Image"); }
            set { _bag["Image"] = value; }
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
                return "[dbo].Item";
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
        
        #region Serialization
        
        protected override void OnGetState(SerializationInfo info, StateMode mode)
        {
            base.OnGetState(info, mode);
            if (_bag.ContainsKey("ItemId")) info.AddValue("ItemId", GetValue< System.String >("ItemId"));
            if (_bag.ContainsKey("ProductId")) info.AddValue("ProductId", GetValue< System.String >("ProductId"));
            if (_bag.ContainsKey("ListPrice")) info.AddValue("ListPrice", GetValue< System.Decimal? >("ListPrice"));
            if (_bag.ContainsKey("UnitCost")) info.AddValue("UnitCost", GetValue< System.Decimal? >("UnitCost"));
            if (_bag.ContainsKey("Supplier")) info.AddValue("Supplier", GetValue< System.Int32? >("Supplier"));
            if (_bag.ContainsKey("Status")) info.AddValue("Status", GetValue< System.String >("Status"));
            if (_bag.ContainsKey("Name")) info.AddValue("Name", GetValue< System.String >("Name"));
            if (_bag.ContainsKey("Image")) info.AddValue("Image", GetValue< System.String >("Image"));
        }

        protected override void OnSetState(SerializationInfo info, StateMode mode)
        {
            base.OnSetState(info, mode);
            if(info.Values.ContainsKey("ItemId")) _bag["ItemId"] = info.GetValue< System.String >("ItemId");
            if(info.Values.ContainsKey("ProductId")) _bag["ProductId"] = info.GetValue< System.String >("ProductId");
            if(info.Values.ContainsKey("ListPrice")) _bag["ListPrice"] = info.GetValue< System.Decimal? >("ListPrice");
            if(info.Values.ContainsKey("UnitCost")) _bag["UnitCost"] = info.GetValue< System.Decimal? >("UnitCost");
            if(info.Values.ContainsKey("Supplier")) _bag["Supplier"] = info.GetValue< System.Int32? >("Supplier");
            if(info.Values.ContainsKey("Status")) _bag["Status"] = info.GetValue< System.String >("Status");
            if(info.Values.ContainsKey("Name")) _bag["Name"] = info.GetValue< System.String >("Name");
            if(info.Values.ContainsKey("Image")) _bag["Image"] = info.GetValue< System.String >("Image");
        }

        #endregion
    }
}