﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.2, CSLA Templates: v3.0.0.0, CSLA Framework: v3.8.4.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Inventory.cs'.
//
//     Template path: EditableRoot.Generated.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;

using Csla;
using Csla.Validation;
using Csla.Data;

#endregion

namespace PetShop.Business
{
    [Serializable]
    public partial class Inventory : BusinessBase< Inventory >
    {
        #region Contructor(s)

        private Inventory()
        { /* Require use of factory methods */ }

        internal Inventory(System.String itemId)
        {
            using(BypassPropertyChecks)
            {
                LoadProperty(_itemIdProperty, itemId);
            }
        }

        internal Inventory(SafeDataReader reader)
        {
            Map(reader);
        }
        #endregion

        #region Business Rules

        protected override void AddBusinessRules()
        {
            if(AddBusinessValidationRules())
                return;

            ValidationRules.AddRule(CommonRules.StringRequired, _itemIdProperty);
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_itemIdProperty, 10));
        }

        #endregion

        #region Properties

        private static readonly PropertyInfo< System.String > _itemIdProperty = RegisterProperty< System.String >(p => p.ItemId, string.Empty);
		[System.ComponentModel.DataObjectField(true, false)]
        public System.String ItemId
        {
            get { return GetProperty(_itemIdProperty); }
            set{ SetProperty(_itemIdProperty, value); }
        }

        private static readonly PropertyInfo< System.String > _originalItemIdProperty = RegisterProperty< System.String >(p => p.OriginalItemId, string.Empty);
        /// <summary>
        /// Holds the original value for ItemId. This is used for non identity primary keys.
        /// </summary>
        internal System.String OriginalItemId
        {
            get { return GetProperty(_originalItemIdProperty); }
            set{ SetProperty(_originalItemIdProperty, value); }
        }
        private static readonly PropertyInfo< System.Int32 > _qtyProperty = RegisterProperty< System.Int32 >(p => p.Qty, string.Empty);
        public System.Int32 Qty
        {
            get { return GetProperty(_qtyProperty); }
            set{ SetProperty(_qtyProperty, value); }
        }
        #endregion

        #region Synchronous Factory Methods 

        public static Inventory NewInventory()
        {
            return DataPortal.Create< Inventory >();
        }

        public static Inventory GetByItemId(System.String itemId)
        {
            var criteria = new InventoryCriteria {ItemId = itemId};
            
            
            return DataPortal.Fetch< Inventory >(criteria);
        }

        public static void DeleteInventory(System.String itemId)
        {
            var criteria = new InventoryCriteria {ItemId = itemId};
            
            
            DataPortal.Delete(criteria);
        }

        #endregion

        #region DataPortal partial methods

        partial void OnCreating(ref bool cancel);
        partial void OnCreated();
        partial void OnFetching(InventoryCriteria criteria, ref bool cancel);
        partial void OnFetched();
        partial void OnMapping(SafeDataReader reader, ref bool cancel);
        partial void OnMapped();
        partial void OnInserting(ref bool cancel);
        partial void OnInserted();
        partial void OnUpdating(ref bool cancel);
        partial void OnUpdated();
        partial void OnSelfDeleting(ref bool cancel);
        partial void OnSelfDeleted();
        partial void OnDeleting(InventoryCriteria criteria, ref bool cancel);
        partial void OnDeleted();

        #endregion

        #region Exists Command

        public static bool Exists(InventoryCriteria criteria)
        {
            return ExistsCommand.Execute(criteria);
        }

        #endregion

    }
}