﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.2, CSLA Templates: v3.0.0.1817, CSLA Framework: v4.0.0.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Product.cs'.
//
//     Template: DynamicRootList.Generated.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;

using Csla;
using Csla.Data;

#endregion

namespace PetShop.Business
{
    [Serializable]
    public partial class ProductList : EditableRootListBase< Product >
    {
        #region Constructor(s)
        private ProductList()
        { 
            AllowNew = true;
        }
        
        #endregion

        #region Method Overrides

        protected override object AddNewCore()
        {
            Product item = PetShop.Business.Product.NewProduct();

            bool cancel = false;
            OnAddNewCore(ref item, ref cancel);
            if (!cancel)
            {
                // Check to see if someone set the item to null in the OnAddNewCore.
                if(item == null)
                    item = PetShop.Business.Product.NewProduct();

                Add(item);
            }

            return item;
        }
        
        #endregion

        #region Synchronous Factory Methods 
        
        public static ProductList NewList()
        {
            return DataPortal.Create< ProductList >();
        }

        public static ProductList GetAll()
        {
            return DataPortal.Fetch< ProductList>(new ProductCriteria());
        }


        public static ProductList GetByProductId(System.String productId)
        {
			var criteria = new ProductCriteria{ProductId = productId};
			
        
            return DataPortal.Fetch< ProductList >(criteria);
        }

        public static ProductList GetByName(System.String name)
        {
			var criteria = new ProductCriteria{Name = name};
			
        
            return DataPortal.Fetch< ProductList >(criteria);
        }

        public static ProductList GetByCategoryId(System.String categoryId)
        {
			var criteria = new ProductCriteria{CategoryId = categoryId};
			
        
            return DataPortal.Fetch< ProductList >(criteria);
        }

        public static ProductList GetByCategoryIdName(System.String categoryId, System.String name)
        {
			var criteria = new ProductCriteria{CategoryId = categoryId, Name = name};
			
        
            return DataPortal.Fetch< ProductList >(criteria);
        }

        public static ProductList GetByCategoryIdProductIdName(System.String categoryId, System.String productId, System.String name)
        {
			var criteria = new ProductCriteria{CategoryId = categoryId, ProductId = productId, Name = name};
			
        
            return DataPortal.Fetch< ProductList >(criteria);
        }
        #endregion
        


        #region DataPortal partial methods

        partial void OnCreating(ref bool cancel);
        partial void OnCreated();
        partial void OnFetching(ProductCriteria criteria, ref bool cancel);
        partial void OnFetched();
        partial void OnMapping(SafeDataReader reader, ref bool cancel);
        partial void OnMapped();
        partial void OnUpdating(ref bool cancel);
        partial void OnUpdated();
        partial void OnAddNewCore(ref Product item, ref bool cancel);

        #endregion

        #region Exists Command

        public static bool Exists(ProductCriteria criteria)
        {
            return PetShop.Business.Product.Exists(criteria);
        }

        #endregion

    }
}