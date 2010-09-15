﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.3, CSLA Templates: v3.0.1.1934, CSLA Framework: v4.0.0.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Category.cs'.
//
//     Template path: EditableRoot.Generated.cst
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
#endif

#endregion

namespace PetShop.Business
{
    [Serializable]
    public partial class Category : BusinessBase< Category >
    {
        #region Contructor(s)

#if !SILVERLIGHT
        private Category()
        { /* Require use of factory methods */ }
#else
    public Category()
        { /* Require use of factory methods */ }
#endif

        internal Category(System.String categoryId)
        {
            using(BypassPropertyChecks)
            {
                LoadProperty(_categoryIdProperty, categoryId);
            }
        }

#if !SILVERLIGHT
        internal Category(SafeDataReader reader)
        {
            Map(reader);
        }
#endif
        #endregion

        #region Business Rules

        protected override void AddBusinessRules()
        {
            if(AddBusinessValidationRules())
                return;

            BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(_categoryIdProperty));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(_categoryIdProperty, 10));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(_nameProperty, 80));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(_descriptionProperty, 255));
        }

        #endregion

        #region Properties

        private static readonly PropertyInfo< System.String > _categoryIdProperty = RegisterProperty< System.String >(p => p.CategoryId, string.Empty);
#if !SILVERLIGHT
		[System.ComponentModel.DataObjectField(true, false)]
#endif
        public System.String CategoryId
        {
            get { return GetProperty(_categoryIdProperty); }
            set{ SetProperty(_categoryIdProperty, value); }
        }

        private static readonly PropertyInfo< System.String > _originalCategoryIdProperty = RegisterProperty< System.String >(p => p.OriginalCategoryId, string.Empty);
        /// <summary>
        /// Holds the original value for CategoryId. This is used for non identity primary keys.
        /// </summary>
        internal System.String OriginalCategoryId
        {
            get { return GetProperty(_originalCategoryIdProperty); }
            set{ SetProperty(_originalCategoryIdProperty, value); }
        }
        private static readonly PropertyInfo< System.String > _nameProperty = RegisterProperty< System.String >(p => p.Name, string.Empty, (System.String)null);
        public System.String Name
        {
            get { return GetProperty(_nameProperty); }
            set{ SetProperty(_nameProperty, value); }
        }
        private static readonly PropertyInfo< System.String > _descriptionProperty = RegisterProperty< System.String >(p => p.Description, string.Empty, (System.String)null);
        public System.String Description
        {
            get { return GetProperty(_descriptionProperty); }
            set{ SetProperty(_descriptionProperty, value); }
        }
        //AssociatedOneToMany
        private static readonly PropertyInfo< ProductList > _productsProperty = RegisterProperty<ProductList>(p => p.Products, Csla.RelationshipTypes.Child);
        public ProductList Products
        {
            get
            {
                bool cancel = false;
                OnChildLoading(_productsProperty, ref cancel);
    
                if (!cancel)
                {
                    if(!FieldManager.FieldExists(_productsProperty))
                    {
#if SILVERLIGHT
                        //MarkBusy();
                        var criteria = new PetShop.Business.ProductCriteria {CategoryId = CategoryId};
                        

                        if((true))
                        {
                            PetShop.Business.ProductList.Exists(criteria,(o,e) =>
                            {
                                if (e.Error != null)
                                    throw e.Error;

                                if(!e.Object.Result)
                                PetShop.Business.ProductList.NewListAsync((o1, e1) =>
                                {
                                    if (e1.Error != null)
                                        throw e1.Error; 

                                    this.LoadProperty(_productsProperty, e1.Object);

                                    //MarkIdle();
                                    OnPropertyChanged(_productsProperty);
                                });
                                else
                                PetShop.Business.ProductList.GetByCategoryIdAsync(CategoryId, (o2, e2) =>
                                {
                                    if (e2.Error != null)
                                        throw e2.Error; 

                                    this.LoadProperty(_productsProperty, e2.Object);

                                    //MarkIdle();
                                    OnPropertyChanged(_productsProperty);
                                });
                            });
                        }
#else
                        var criteria = new PetShop.Business.ProductCriteria {CategoryId = CategoryId};
                        
    
                        if(!PetShop.Business.ProductList.Exists(criteria))
                            LoadProperty(_productsProperty, PetShop.Business.ProductList.NewList());
                        else
                            LoadProperty(_productsProperty, PetShop.Business.ProductList.GetByCategoryId(CategoryId));
#endif
                    }
                }

                return GetProperty(_productsProperty);
            }
        }


        #endregion

#if !SILVERLIGHT
        #region Synchronous Factory Methods 

        public static Category NewCategory()
        {
            return DataPortal.Create< Category >();
        }

        public static Category GetByCategoryId(System.String categoryId)
        {
            var criteria = new CategoryCriteria {CategoryId = categoryId};
            
            
            return DataPortal.Fetch< Category >(criteria);
        }

        public static void DeleteCategory(System.String categoryId)
        {
            var criteria = new CategoryCriteria {CategoryId = categoryId};
            
            
            DataPortal.Delete< Category >(criteria);
        }

        #endregion
#endif

        #region Asynchronous Factory Methods

#if SILVERLIGHT
        public static void NewCategoryAsync(EventHandler<DataPortalResult<Category>> handler)
        {
            var dp = new DataPortal<Category>();
            dp.CreateCompleted += handler;
            dp.BeginCreate();
        }

        public static void GetByCategoryIdAsync(System.String categoryId, EventHandler<DataPortalResult< Category >> handler)
        {
            var criteria = new CategoryCriteria{ CategoryId = categoryId};
            
            
            var dp = new DataPortal< Category >();
            dp.FetchCompleted += handler;
            dp.BeginFetch(criteria);
        }

        public static void DeleteCategoryAsync(System.String categoryId, EventHandler<DataPortalResult<Category>> handler)
        {
            var criteria = new CategoryCriteria{CategoryId = categoryId};
            
            
            var dp = new DataPortal< Category >();
            dp.DeleteCompleted += handler;
            dp.BeginDelete(criteria);
        }
#endif
        
        #endregion

        #region DataPortal partial methods

#if !SILVERLIGHT
        partial void OnCreating(ref bool cancel);
        partial void OnCreated();
        partial void OnFetching(CategoryCriteria criteria, ref bool cancel);
        partial void OnFetched();
        partial void OnMapping(SafeDataReader reader, ref bool cancel);
        partial void OnMapped();
        partial void OnInserting(ref bool cancel);
        partial void OnInserted();
        partial void OnUpdating(ref bool cancel);
        partial void OnUpdated();
        partial void OnSelfDeleting(ref bool cancel);
        partial void OnSelfDeleted();
        partial void OnDeleting(CategoryCriteria criteria, ref bool cancel);
        partial void OnDeleted();
#endif
        partial void OnChildLoading(Csla.Core.IPropertyInfo childProperty, ref bool cancel);

        #endregion

        #region Exists Command
#if !SILVERLIGHT

        public static bool Exists(CategoryCriteria criteria)
        {
            return PetShop.Business.ExistsCommand.Execute(criteria);
        }

#else

        public static void Exists(CategoryCriteria criteria, EventHandler<DataPortalResult<ExistsCommand>> handler)
        {
            PetShop.Business.ExistsCommand.Execute(criteria, handler);
        }

#endif

        #endregion

    }
}