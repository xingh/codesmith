﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.3, CSLA Templates: v3.0.1.1934, CSLA Framework: v3.8.4.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Item.cs'.
//
//     Template: ObjectFactoryList.DataAccess.StoredProcedures.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;
using System.Data;
using System.Data.SqlClient;

using Csla;
using Csla.Data;
using Csla.Server;

using PetShop.Tests.ObjF.StoredProcedures;

#endregion

namespace PetShop.Tests.ObjF.StoredProcedures.DAL
{
    public partial class ItemListFactory : ObjectFactory
    {
        #region Create

        /// <summary>
        /// Creates new ItemList with default values.
        /// </summary>
        /// <returns>new ItemList.</returns>
        [RunLocal]
        public ItemList Create()
        {
            var item = (ItemList)Activator.CreateInstance(typeof(ItemList), true);

            bool cancel = false;
            OnCreating(ref cancel);
            if (cancel) return item;

            CheckRules(item);
            MarkNew(item);
            MarkAsChild(item);

            OnCreated();

            return item;
        }

        #endregion

        #region Fetch

        /// <summary>
        /// Fetch ItemList.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <returns></returns>
        public ItemList Fetch(ItemCriteria criteria)
        {
            ItemList item = (ItemList)Activator.CreateInstance(typeof(ItemList), true);

            bool cancel = false;
            OnFetching(criteria, ref cancel);
            if (cancel) return item;

            // Fetch Child objects.
            using (SqlConnection connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("[dbo].[CSLA_Item_Select]", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));
                    command.Parameters.AddWithValue("@p_ListPriceHasValue", criteria.ListPriceHasValue);
					command.Parameters.AddWithValue("@p_UnitCostHasValue", criteria.UnitCostHasValue);
					command.Parameters.AddWithValue("@p_SupplierHasValue", criteria.SupplierHasValue);
					command.Parameters.AddWithValue("@p_StatusHasValue", criteria.StatusHasValue);
					command.Parameters.AddWithValue("@p_NameHasValue", criteria.NameHasValue);
					command.Parameters.AddWithValue("@p_ImageHasValue", criteria.ImageHasValue);
                    using(var reader = new SafeDataReader(command.ExecuteReader()))
                    {
                        if(reader.Read())
                        {
                            do
                            {
                                item.Add(new ItemFactory().Map(reader));
                            } while(reader.Read());
                        }
                    }
                }
            }

            MarkOld(item);
            MarkAsChild(item);
            OnFetched();
            return item;
        }

        #endregion

        #region DataPortal partial methods

        partial void OnCreating(ref bool cancel);
        partial void OnCreated();
        partial void OnFetching(ItemCriteria criteria, ref bool cancel);
        partial void OnFetched();
        partial void OnMapping(SafeDataReader reader, ref bool cancel);
        partial void OnMapped();
        partial void OnUpdating(ref bool cancel);
        partial void OnUpdated();
        partial void OnAddNewCore(ref Item item, ref bool cancel);

        #endregion
    }
}