﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.2, CSLA Templates: v3.0.0.0, CSLA Framework: v3.8.4.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'AccountList.cs'.
//
//     Template: EditableChildList.Generated.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;
using System.Collections.Generic;

using Csla;
using Csla.Data;

#endregion

namespace PetShop.Business
{
    [Serializable]
    public partial class AccountList : BusinessListBase< AccountList, Account >
    {
        #region Constructor(s)

        private AccountList()
        { 
            AllowNew = true;
            MarkAsChild();
        }
        
        #endregion

        #region Synchronous Factory Methods 
        
        internal static AccountList NewList()
        {
            return DataPortal.CreateChild< AccountList >();
        }     

        internal static AccountList GetByAccountId(System.Int32 accountId)
        {
            var criteria = new AccountCriteria{AccountId = accountId};
            
            
            return DataPortal.FetchChild< AccountList >(criteria);
        }

        internal static AccountList GetByUniqueID(System.Int32 uniqueID)
        {
            var criteria = new AccountCriteria{UniqueID = uniqueID};
            
            
            return DataPortal.FetchChild< AccountList >(criteria);
        }

        internal static AccountList GetAll()
        {
            return DataPortal.FetchChild< AccountList >(new AccountCriteria());
        }

        #endregion


        #region Method Overrides
        
        protected override object AddNewCore()
        {
            Account item = PetShop.Business.Account.NewAccount();

            bool cancel = false;
            OnAddNewCore(ref item, ref cancel);
            if (!cancel)
            {
                // Check to see if someone set the item to null in the OnAddNewCore.
                if(item == null)
                    item = PetShop.Business.Account.NewAccount();

                // Pass the parent value down to the child.
                Profile profile = this.Parent as Profile;
                if(profile != null)
                    item.UniqueID = profile.UniqueID;


                Add(item);
            }

            return item;
        }
        
        #endregion

        #region DataPortal partial methods

        partial void OnCreating(ref bool cancel);
        partial void OnCreated();
        partial void OnFetching(AccountCriteria criteria, ref bool cancel);
        partial void OnFetched();
        partial void OnMapping(SafeDataReader reader, ref bool cancel);
        partial void OnMapped();
        partial void OnUpdating(ref bool cancel);
        partial void OnUpdated();
        partial void OnAddNewCore(ref Account item, ref bool cancel);

        #endregion

        #region Exists Command

        public static bool Exists(AccountCriteria criteria)
        {
            return PetShop.Business.Account.Exists(criteria);
        }

        #endregion

    }
}