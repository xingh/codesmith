﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v6.5.0, CSLA Templates: v4.0.0.0, CSLA Framework: v4.3.10.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Category.cs'.
//
//     Template path: EditableRoot.Generated.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
using System;

using Csla;
using Csla.Data;

using Csla.Rules;

namespace PetShop.Tests.ObjF.ParameterizedSQL
{
    [Serializable]
    [Csla.Server.ObjectFactory(FactoryNames.CategoryFactoryName)]
    public partial class Category : BusinessBase<Category>
    {
        #region Contructor(s)

        public Category()
        { /* Require use of factory methods */ }

        #endregion
        #region Business Rules

        /// <summary>
        /// Contains the CodeSmith generated validation rules.
        /// </summary>
        protected override void AddBusinessRules()
        {
            // Call the base class, if this call isn't made than any declared System.ComponentModel.DataAnnotations rules will not work.
            base.AddBusinessRules();

            if(AddBusinessValidationRules())
                return;

            BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(_categoryIdProperty));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(_categoryIdProperty, 10));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(_nameProperty, 80));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(_descriptionProperty, 255));
        }

        #endregion

        #region Properties

        private static readonly PropertyInfo<System.String> _categoryIdProperty = RegisterProperty<System.String>(p => p.CategoryId, "Category Id");
        [System.ComponentModel.DataObjectField(true, false)]
        public System.String CategoryId
        {
            get { return GetProperty(_categoryIdProperty); }
            set{ SetProperty(_categoryIdProperty, value); }
        }

        private static readonly PropertyInfo<System.String> _originalCategoryIdProperty = RegisterProperty<System.String>(p => p.OriginalCategoryId, "Original Category Id");
        /// <summary>
        /// Holds the original value for CategoryId. This is used for non identity primary keys.
        /// </summary>
        internal System.String OriginalCategoryId
        {
            get { return GetProperty(_originalCategoryIdProperty); }
            set{ SetProperty(_originalCategoryIdProperty, value); }
        }

        private static readonly PropertyInfo<System.String> _nameProperty = RegisterProperty<System.String>(p => p.Name, "Name", (System.String)null);
        public System.String Name
        {
            get { return GetProperty(_nameProperty); }
            set{ SetProperty(_nameProperty, value); }
        }

        private static readonly PropertyInfo<System.String> _descriptionProperty = RegisterProperty<System.String>(p => p.Description, "Description", (System.String)null);
        public System.String Description
        {
            get { return GetProperty(_descriptionProperty); }
            set{ SetProperty(_descriptionProperty, value); }
        }

        // OneToMany
        private static readonly PropertyInfo<ProductList> _productsProperty = RegisterProperty<ProductList>(p => p.Products, Csla.RelationshipTypes.Child);
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
                        var criteria = new PetShop.Tests.ObjF.ParameterizedSQL.ProductCriteria {CategoryId = CategoryId};
                        
    
                        if(!PetShop.Tests.ObjF.ParameterizedSQL.ProductList.Exists(criteria))
                            LoadProperty(_productsProperty, PetShop.Tests.ObjF.ParameterizedSQL.ProductList.NewList());
                        else
                            LoadProperty(_productsProperty, PetShop.Tests.ObjF.ParameterizedSQL.ProductList.GetByCategoryId(CategoryId));
                    }
                }

                return GetProperty(_productsProperty);
            }
        }


        #endregion

        #region Synchronous Factory Methods 

        /// <summary>
        /// Creates a new object of type <see cref="Category"/>. 
        /// </summary>
        /// <returns>Returns a newly instantiated collection of type <see cref="Category"/>.</returns>    
        public static Category NewCategory()
        {
            return DataPortal.Create<Category>();
        }

        /// <summary>
        /// Returns a <see cref="Category"/> object of the specified criteria. 
        /// </summary>
        /// <param name="categoryId">No additional detail available.</param>
        /// <returns>A <see cref="Category"/> object of the specified criteria.</returns>
        public static Category GetByCategoryId(System.String categoryId)
        {
            var criteria = new CategoryCriteria {CategoryId = categoryId};
            
            
            return DataPortal.Fetch<Category>(criteria);
        }

        public static void DeleteCategory(System.String categoryId)
        {
            var criteria = new CategoryCriteria {CategoryId = categoryId};
            
            
            DataPortal.Delete<Category>(criteria);
        }

        #endregion

        #region Asynchronous Factory Methods

        public static void NewCategoryAsync(EventHandler<DataPortalResult<Category>> handler)
        {
            var dp = new DataPortal<Category>();
            dp.CreateCompleted += handler;
            dp.BeginCreate();
        }

        public static void GetByCategoryIdAsync(System.String categoryId, EventHandler<DataPortalResult<Category>> handler)
        {
            var criteria = new CategoryCriteria{ CategoryId = categoryId};
            
            
            var dp = new DataPortal<Category>();
            dp.FetchCompleted += handler;
            dp.BeginFetch(criteria);
        }

        public static void DeleteCategoryAsync(System.String categoryId, EventHandler<DataPortalResult<Category>> handler)
        {
            var criteria = new CategoryCriteria{CategoryId = categoryId};
            
            
            var dp = new DataPortal<Category>();
            dp.DeleteCompleted += handler;
            dp.BeginDelete(criteria);
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
                if (FieldManager.FieldExists(_productsProperty) && Products.IsDirty) return true;

                return false;
            }
        }

        #endregion

        #region DataPortal partial methods

        /// <summary>
        /// CodeSmith generated stub method that is called when creating the <see cref="Category"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnCreating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="Category"/> object has been created. 
        /// </summary>
        partial void OnCreated();

        /// <summary>
        /// CodeSmith generated stub method that is called when fetching the <see cref="Category"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="CategoryCriteria"/> object containing the criteria of the object to fetch.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        partial void OnFetching(CategoryCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="Category"/> object has been fetched. 
        /// </summary>    
        partial void OnFetched();

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the <see cref="Category"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        partial void OnMapping(ref bool cancel);
 
        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the <see cref="Category"/> object. 
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        partial void OnMapping(SafeDataReader reader, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="Category"/> object has been mapped. 
        /// </summary>
        partial void OnMapped();

        /// <summary>
        /// CodeSmith generated stub method that is called when inserting the <see cref="Category"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        partial void OnInserting(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="Category"/> object has been inserted. 
        /// </summary>
        partial void OnInserted();

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the <see cref="Category"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnUpdating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="Category"/> object has been updated. 
        /// </summary>
        partial void OnUpdated();

        /// <summary>
        /// CodeSmith generated stub method that is called when self deleting the <see cref="Category"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object self deletion should proceed.</param>
        partial void OnSelfDeleting(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="Category"/> object has been deleted. 
        /// </summary>
        partial void OnSelfDeleted();

        /// <summary>
        /// CodeSmith generated stub method that is called when deleting the <see cref="Category"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="CategoryCriteria"/> object containing the criteria of the object to delete.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object deletion should proceed.</param>
        partial void OnDeleting(CategoryCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="Category"/> object with the specified criteria has been deleted. 
        /// </summary>
        partial void OnDeleted();
        partial void OnChildLoading(Csla.Core.IPropertyInfo childProperty, ref bool cancel);

        #endregion

        #region Exists Command

        /// <summary>
        /// Determines if a record exists in the Category table in the database for the specified criteria. 
        /// </summary>
        /// <param name="criteria">The criteria parameter is an <see cref="Category"/> object.</param>
        /// <returns>A boolean value of true is returned if a record is found.</returns>
        public static bool Exists(CategoryCriteria criteria)
        {
            return PetShop.Tests.ObjF.ParameterizedSQL.ExistsCommand.Execute(criteria);
        }

        /// <summary>
        /// Determines if a record exists in the Category table in the database for the specified criteria. 
        /// </summary>
        public static void ExistsAsync(CategoryCriteria criteria, EventHandler<DataPortalResult<ExistsCommand>> handler)
        {
            PetShop.Tests.ObjF.ParameterizedSQL.ExistsCommand.ExecuteAsync(criteria, handler);
        }

        #endregion

    }
}