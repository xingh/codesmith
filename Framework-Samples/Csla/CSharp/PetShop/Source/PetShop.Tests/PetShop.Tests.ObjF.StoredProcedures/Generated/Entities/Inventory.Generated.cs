﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v6.0.2, CSLA Templates: v3.0.3.2430, CSLA Framework: v4.0.0.
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
using Csla.Rules;
using Csla.Data;

#endregion

namespace PetShop.Tests.ObjF.StoredProcedures
{
    [Serializable]
    [Csla.Server.ObjectFactory(FactoryNames.InventoryFactoryName)]
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
        #endregion

        #region Business Rules

        /// <summary>
        /// Contains the Codesmith generated validation rules.
        /// </summary>
        protected override void AddBusinessRules()
        {
            // Call the base class, if this call isn't made than any declared System.ComponentModel.DataAnnotations rules will not work.
            base.AddBusinessRules();

            if(AddBusinessValidationRules())
                return;

            BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(_itemIdProperty));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(_itemIdProperty, 10));
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

        /// <summary>
        /// Creates a new object of type <see cref="Inventory"/>. 
        /// </summary>
        /// <returns>Returns a newly instantiated collection of type <see cref="Inventory"/>.</returns>	
        public static Inventory NewInventory()
        {
            return DataPortal.Create< Inventory >();
        }

        /// <summary>
        /// Returns a <see cref="Inventory"/> object of the specified criteria. 
        /// </summary>
        /// <param name="itemId">No additional detail available.</param>
        /// <returns>A <see cref="Inventory"/> object of the specified criteria.</returns>
        public static Inventory GetByItemId(System.String itemId)
        {
            var criteria = new InventoryCriteria {ItemId = itemId};
            
            
            return DataPortal.Fetch< Inventory >(criteria);
        }

        public static void DeleteInventory(System.String itemId)
        {
            var criteria = new InventoryCriteria {ItemId = itemId};
            
            
            DataPortal.Delete< Inventory >(criteria);
        }

        #endregion

        #region Overridden properties

        /// <summary>
        /// Returns true if the business object or any of its children properties are dirty.
        /// </summary>
        public override bool IsDirty
        {
            get
            {
                if (base.IsDirty) return true;




                return false;
            }
        }

        #endregion

        #region DataPortal partial methods

        /// <summary>
        /// Codesmith generated stub method that is called when creating the <see cref="Inventory"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnCreating(ref bool cancel);

        /// <summary>
        /// Codesmith generated stub method that is called after the <see cref="Inventory"/> object has been created. 
        /// </summary>
        partial void OnCreated();

        /// <summary>
        /// Codesmith generated stub method that is called when fetching the <see cref="Inventory"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="InventoryCriteria"/> object containg the criteria of the object to fetch.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        partial void OnFetching(InventoryCriteria criteria, ref bool cancel);

        /// <summary>
        /// Codesmith generated stub method that is called after the <see cref="Inventory"/> object has been fetched. 
        /// </summary>	
        partial void OnFetched();

        /// <summary>
        /// Codesmith generated stub method that is called when mapping the <see cref="Inventory"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        partial void OnMapping(ref bool cancel);
        partial void OnMapping(SafeDataReader reader, ref bool cancel);

        /// <summary>
        /// Codesmith generated stub method that is called after the <see cref="Inventory"/> object has been mapped. 
        /// </summary>
        partial void OnMapped();

        /// <summary>
        /// Codesmith generated stub method that is called when inserting the <see cref="Inventory"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        partial void OnInserting(ref bool cancel);

        /// <summary>
        /// Codesmith generated stub method that is called after the <see cref="Inventory"/> object has been inserted. 
        /// </summary>
        partial void OnInserted();

        /// <summary>
        /// Codesmith generated stub method that is called when updating the <see cref="Inventory"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnUpdating(ref bool cancel);

        /// <summary>
        /// Codesmith generated stub method that is called after the <see cref="Inventory"/> object has been updated. 
        /// </summary>
        partial void OnUpdated();

        /// <summary>
        /// Codesmith generated stub method that is called when self deleting the <see cref="Inventory"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object self deletion should proceed.</param>
        partial void OnSelfDeleting(ref bool cancel);

        /// <summary>
        /// Codesmith generated stub method that is called after the <see cref="Inventory"/> object has been deleted. 
        /// </summary>
        partial void OnSelfDeleted();

        /// <summary>
        /// Codesmith generated stub method that is called when deleting the <see cref="Inventory"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="InventoryCriteria"/> object containg the criteria of the object to delete.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object deletion should proceed.</param>
        partial void OnDeleting(InventoryCriteria criteria, ref bool cancel);

        /// <summary>
        /// Codesmith generated stub method that is called after the <see cref="Inventory"/> object with the specified criteria has been deleted. 
        /// </summary>
        partial void OnDeleted();
        partial void OnChildLoading(Csla.Core.IPropertyInfo childProperty, ref bool cancel);

        #endregion
        #region Exists Command

        /// <summary>
        /// Determines if a record exists in the Inventory table in the database for the specified criteria. 
        /// </summary>
        /// <param name="criteria">The criteria parameter is an <see cref="Inventory"/> object.</param>
        /// <returns>A boolean value of true is returned if a record is found.</returns>
        public static bool Exists(InventoryCriteria criteria)
        {
            return PetShop.Tests.ObjF.StoredProcedures.ExistsCommand.Execute(criteria);
		}

        #endregion

    }
}