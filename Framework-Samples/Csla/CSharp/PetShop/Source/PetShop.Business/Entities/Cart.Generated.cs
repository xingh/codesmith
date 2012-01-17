﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v6.0.2, CSLA Templates: v3.0.3.2430, CSLA Framework: v4.0.0.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Cart.cs'.
//
//     Template: EditableChild.Generated.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;

using Csla;
using Csla.Rules;
#if SILVERLIGHT
using Csla.Serialization;
#else
using Csla.Data;
using System.Data.SqlClient;
#endif

#endregion

namespace PetShop.Business
{
    [Serializable]
    public partial class Cart : BusinessBase< Cart >
    {
        #region Contructor(s)

#if !SILVERLIGHT
        private Cart()
        {
            // require use of factory method.
            MarkAsChild();
        }
#else
        public Cart()
        {
            // require use of factory method.
            MarkAsChild();
        }        
#endif

        internal Cart(System.Int32 cartId)
        {
            using(BypassPropertyChecks)
            {
                LoadProperty(_cartIdProperty, cartId);
            }

            MarkAsChild();
        }

#if !SILVERLIGHT
        internal Cart(SafeDataReader reader)
        {
            Map(reader);

            MarkAsChild();
        }
#endif
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
            BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(_nameProperty));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(_nameProperty, 80));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(_typeProperty));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(_typeProperty, 80));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(_categoryIdProperty));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(_categoryIdProperty, 10));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(_productIdProperty));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(_productIdProperty, 10));
        }

        #endregion

        #region Properties

        private static readonly PropertyInfo< System.Int32 > _cartIdProperty = RegisterProperty< System.Int32 >(p => p.CartId, string.Empty);
#if !SILVERLIGHT
		[System.ComponentModel.DataObjectField(true, true)]
#endif
        public System.Int32 CartId
        {
            get { return GetProperty(_cartIdProperty); }
            internal set{ SetProperty(_cartIdProperty, value); }
        }
        private static readonly PropertyInfo< System.Int32 > _uniqueIDProperty = RegisterProperty< System.Int32 >(p => p.UniqueID, string.Empty);
        public System.Int32 UniqueID
        {
            get { return GetProperty(_uniqueIDProperty); }
            set{ SetProperty(_uniqueIDProperty, value); }
        }
        private static readonly PropertyInfo< System.String > _itemIdProperty = RegisterProperty< System.String >(p => p.ItemId, string.Empty);
        public System.String ItemId
        {
            get { return GetProperty(_itemIdProperty); }
            set{ SetProperty(_itemIdProperty, value); }
        }
        private static readonly PropertyInfo< System.String > _nameProperty = RegisterProperty< System.String >(p => p.Name, string.Empty);
        public System.String Name
        {
            get { return GetProperty(_nameProperty); }
            set{ SetProperty(_nameProperty, value); }
        }
        private static readonly PropertyInfo< System.String > _typeProperty = RegisterProperty< System.String >(p => p.Type, string.Empty);
        public System.String Type
        {
            get { return GetProperty(_typeProperty); }
            set{ SetProperty(_typeProperty, value); }
        }
        private static readonly PropertyInfo< System.Decimal > _priceProperty = RegisterProperty< System.Decimal >(p => p.Price, string.Empty);
        public System.Decimal Price
        {
            get { return GetProperty(_priceProperty); }
            set{ SetProperty(_priceProperty, value); }
        }
        private static readonly PropertyInfo< System.String > _categoryIdProperty = RegisterProperty< System.String >(p => p.CategoryId, string.Empty);
        public System.String CategoryId
        {
            get { return GetProperty(_categoryIdProperty); }
            set{ SetProperty(_categoryIdProperty, value); }
        }
        private static readonly PropertyInfo< System.String > _productIdProperty = RegisterProperty< System.String >(p => p.ProductId, string.Empty);
        public System.String ProductId
        {
            get { return GetProperty(_productIdProperty); }
            set{ SetProperty(_productIdProperty, value); }
        }
        private static readonly PropertyInfo< System.Boolean > _isShoppingCartProperty = RegisterProperty< System.Boolean >(p => p.IsShoppingCart, string.Empty);
        public System.Boolean IsShoppingCart
        {
            get { return GetProperty(_isShoppingCartProperty); }
            set{ SetProperty(_isShoppingCartProperty, value); }
        }
        private static readonly PropertyInfo< System.Int32 > _quantityProperty = RegisterProperty< System.Int32 >(p => p.Quantity, string.Empty);
        public System.Int32 Quantity
        {
            get { return GetProperty(_quantityProperty); }
            set{ SetProperty(_quantityProperty, value); }
        }


        //AssociatedManyToOne
        private static readonly PropertyInfo< Profile > _profileMemberProperty = RegisterProperty< Profile >(p => p.ProfileMember, Csla.RelationshipTypes.Child);
        public Profile ProfileMember
        {
            get
            {
                bool cancel = false;
                OnChildLoading(_profileMemberProperty, ref cancel);

                if (!cancel)
                {
                    if(!FieldManager.FieldExists(_profileMemberProperty))
                    {
                        var criteria = new PetShop.Business.ProfileCriteria {UniqueID = UniqueID};
                        
#if SILVERLIGHT
                        //MarkBusy();
                        PetShop.Business.Profile.Exists(criteria, (o,e) =>
                        {
                            if(e.Error != null)
                                throw e.Error;
                                
                            if(e.Object.Result)
                                PetShop.Business.Profile.GetByUniqueIDAsync(UniqueID, (o1, e1) =>
                                    {
                                        if (e1.Error != null)
                                            throw e1.Error; 
    
                                        this.LoadProperty(_profileMemberProperty, e1.Object);
    
                                        //MarkIdle();
                                        OnPropertyChanged(_profileMemberProperty);
                                    });
                        });
#else
                        if(PetShop.Business.Profile.Exists(criteria))
                            LoadProperty(_profileMemberProperty, PetShop.Business.Profile.GetByUniqueID(UniqueID));
#endif
                    }
                }

                return GetProperty(_profileMemberProperty); 
            }
        }



        #endregion

        #region Synchronous Factory Methods 

#if !SILVERLIGHT

        /// <summary>
        /// Creates a new object of type <see cref="Cart"/>. 
        /// </summary>
        /// <returns>Returns a newly instantiated collection of type <see cref="Cart"/>.</returns>
        internal static Cart NewCart()
        {
            return DataPortal.CreateChild< Cart >();
        }

        /// <summary>
        /// Returns a <see cref="Cart"/> object of the specified criteria. 
        /// </summary>
        /// <param name="cartId">No additional detail available.</param>
        /// <returns>A <see cref="Cart"/> object of the specified criteria.</returns>
        internal static Cart GetByCartId(System.Int32 cartId)
        {
            var criteria = new CartCriteria {CartId = cartId};
            
        
            return DataPortal.FetchChild< Cart >(criteria);
        }

        /// <summary>
        /// Returns a <see cref="Cart"/> object of the specified criteria. 
        /// </summary>
        /// <param name="uniqueID">No additional detail available.</param>
        /// <returns>A <see cref="Cart"/> object of the specified criteria.</returns>
        internal static Cart GetByUniqueID(System.Int32 uniqueID)
        {
            var criteria = new CartCriteria {UniqueID = uniqueID};
            
        
            return DataPortal.FetchChild< Cart >(criteria);
        }

        /// <summary>
        /// Returns a <see cref="Cart"/> object of the specified criteria. 
        /// </summary>
        /// <param name="isShoppingCart">No additional detail available.</param>
        /// <returns>A <see cref="Cart"/> object of the specified criteria.</returns>
        internal static Cart GetByIsShoppingCart(System.Boolean isShoppingCart)
        {
            var criteria = new CartCriteria {IsShoppingCart = isShoppingCart};
            
        
            return DataPortal.FetchChild< Cart >(criteria);
        }
#endif

        #endregion

        #region Asynchronous Factory Methods

#if SILVERLIGHT
        internal static void NewCartAsync(EventHandler<DataPortalResult<Cart>> handler)
        {
            var dp = new DataPortal<Cart>();
            dp.CreateCompleted += handler;
            dp.BeginCreate();
        }

        internal static void GetByCartIdAsync(System.Int32 cartId, EventHandler<DataPortalResult<AsyncChildLoader<Cart>>> handler)
        {
            var criteria = new CartCriteria{ CartId = cartId};
            

            DataPortal.BeginFetch<AsyncChildLoader<Cart>>(criteria, handler);
        }

        internal static void GetByUniqueIDAsync(System.Int32 uniqueID, EventHandler<DataPortalResult<AsyncChildLoader<Cart>>> handler)
        {
            var criteria = new CartCriteria{ UniqueID = uniqueID};
            

            DataPortal.BeginFetch<AsyncChildLoader<Cart>>(criteria, handler);
        }

        internal static void GetByIsShoppingCartAsync(System.Boolean isShoppingCart, EventHandler<DataPortalResult<AsyncChildLoader<Cart>>> handler)
        {
            var criteria = new CartCriteria{ IsShoppingCart = isShoppingCart};
            

            DataPortal.BeginFetch<AsyncChildLoader<Cart>>(criteria, handler);
        }
#endif
        
        #endregion

        #region ChildPortal partial methods

#if !SILVERLIGHT
        /// <summary>
        /// Codesmith generated stub method that is called when creating the child <see cref="Cart"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnChildCreating(ref bool cancel);

        /// <summary>
        /// Codesmith generated stub method that is called after the child <see cref="Cart"/> object has been created. 
        /// </summary>
        partial void OnChildCreated();

        /// <summary>
        /// Codesmith generated stub method that is called when fetching the child <see cref="Cart"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="CartCriteria"/> object containg the criteria of the object to fetch.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        partial void OnChildFetching(CartCriteria criteria, ref bool cancel);

        /// <summary>
        /// Codesmith generated stub method that is called after the child <see cref="Cart"/> object has been fetched. 
        /// </summary>
        partial void OnChildFetched();

        /// <summary>
        /// Codesmith generated stub method that is called when mapping the child <see cref="Cart"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        partial void OnMapping(ref bool cancel);
        partial void OnMapping(SafeDataReader reader, ref bool cancel);

        /// <summary>
        /// Codesmith generated stub method that is called after the child <see cref="Cart"/> object has been mapped. 
        /// </summary>
        partial void OnMapped();

        /// <summary>
        /// Codesmith generated stub method that is called when inserting the child <see cref="Cart"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        partial void OnChildInserting(ref bool cancel);
        partial void OnChildInserting(SqlConnection connection, ref bool cancel);

        /// <summary>
        /// Codesmith generated stub method that is called after the child <see cref="Cart"/> object has been inserted. 
        /// </summary>
        partial void OnChildInserted();

        /// <summary>
        /// Codesmith generated stub method that is called when updating the child <see cref="Cart"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnChildUpdating(ref bool cancel);
        partial void OnChildUpdating(SqlConnection connection, ref bool cancel);

        /// <summary>
        /// Codesmith generated stub method that is called after the child <see cref="Cart"/> object has been updated. 
        /// </summary>
        partial void OnChildUpdated();

        /// <summary>
        /// Codesmith generated stub method that is called when self deleting the child <see cref="Cart"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object self deletion should proceed.</param>
        partial void OnChildSelfDeleting(ref bool cancel);
        partial void OnChildSelfDeleting(SqlConnection connection, ref bool cancel);

        /// <summary>
        /// Codesmith generated stub method that is called after the child <see cref="Cart"/> object has been deleted. 
        /// </summary>
        partial void OnChildSelfDeleted();

        /// <summary>
        /// Codesmith generated stub method that is called when deleting the child <see cref="Cart"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="CartCriteria"/> object containg the criteria of the object to delete.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object deletion should proceed.</param>
        partial void OnDeleting(CartCriteria criteria, ref bool cancel);
        partial void OnDeleting(CartCriteria criteria, SqlConnection connection, ref bool cancel);

        /// <summary>
        /// Codesmith generated stub method that is called after the child <see cref="Cart"/> object with the specified criteria has been deleted. 
        /// </summary>
        partial void OnDeleted();
#endif
        partial void OnChildLoading(Csla.Core.IPropertyInfo childProperty, ref bool cancel);

        #endregion
        #region Exists Command
#if !SILVERLIGHT

        /// <summary>
        /// Determines if a record exists in the Cart table in the database for the specified criteria. 
        /// </summary>
        /// <param name="criteria">The criteria parameter is an <see cref="Cart"/> object.</param>
        /// <returns>A boolean value of true is returned if a record is found.</returns>
        public static bool Exists(CartCriteria criteria)
        {
            return PetShop.Business.ExistsCommand.Execute(criteria);
		}

#else

        public static void Exists(CartCriteria criteria, EventHandler<DataPortalResult<ExistsCommand>> handler)
        {
            PetShop.Business.ExistsCommand.Execute(criteria, handler);
        }

#endif

        #endregion

    }
}