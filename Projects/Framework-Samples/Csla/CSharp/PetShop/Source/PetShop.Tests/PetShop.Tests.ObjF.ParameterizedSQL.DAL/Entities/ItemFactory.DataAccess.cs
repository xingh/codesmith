//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.2, CSLA Templates: v3.0.0.1817, CSLA Framework: v3.8.4.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Item.cs'.
//
//     Template: ObjectFactory.DataAccess.ParameterizedSQL.cst
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

using PetShop.Tests.ObjF.ParameterizedSQL;

#endregion

namespace PetShop.Tests.ObjF.ParameterizedSQL.DAL
{
    public partial class ItemFactory : ObjectFactory
    {
        #region Create

        /// <summary>
        /// Creates new Item with default values.
        /// </summary>
        /// <returns>new Item.</returns>
        [RunLocal]
        public Item Create()
        {
            var item = (Item)Activator.CreateInstance(typeof(Item), true);

            bool cancel = false;
            OnCreating(ref cancel);
            if (cancel) return item;

            using (BypassPropertyChecks(item))
            {
                // Default values.
                item.ProductId = "BN";
            }

            CheckRules(item);
            MarkNew(item);
            OnCreated();

            return item;
        }

        /// <summary>
        /// Creates new Item with default values.
        /// </summary>
        /// <returns>new Item.</returns>
        [RunLocal]
        private Item Create(ItemCriteria criteria)
        {
            var item = (Item)Activator.CreateInstance(typeof(Item), true);

            bool cancel = false;
            OnCreating(ref cancel);
            if (cancel) return item;

            var resource = Fetch(criteria);
            using (BypassPropertyChecks(item))
            {
                item.ListPrice = resource.ListPrice;
                item.UnitCost = resource.UnitCost;
                item.Status = resource.Status;
                item.Name = resource.Name;
                item.Image = resource.Image;
            }

            CheckRules(item);
            MarkNew(item);

            OnCreated();

            return item;
        }

        #endregion

        #region Fetch

        /// <summary>
        /// Fetch Item.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <returns></returns>
        public Item Fetch(ItemCriteria criteria)
        {
            bool cancel = false;
            OnFetching(criteria, ref cancel);
            if (cancel) return null;

            Item item;
            string commandText = string.Format("SELECT [ItemId], [ProductId], [ListPrice], [UnitCost], [Supplier], [Status], [Name], [Image] FROM [dbo].[Item] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag));
            using (SqlConnection connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));
                    using(var reader = new SafeDataReader(command.ExecuteReader()))
                    {
                        if (reader.Read())
                            item = Map(reader);
                        else
                            throw new Exception(String.Format("The record was not found in 'Item' using the following criteria: {0}.", criteria));
                    }
                }
            }

            OnFetched();
            return item;
        }

        #endregion

        #region Insert

        private void DoInsert(ref Item item, bool stopProccessingChildren)
        {
            // Don't update if the item isn't dirty.
            if (!item.IsDirty) return;

            bool cancel = false;
            OnInserting(ref cancel);
            if (cancel) return;

            const string commandText = "INSERT INTO [dbo].[Item] ([ItemId], [ProductId], [ListPrice], [UnitCost], [Supplier], [Status], [Name], [Image]) VALUES (@p_ItemId, @p_ProductId, @p_ListPrice, @p_UnitCost, @p_Supplier, @p_Status, @p_Name, @p_Image)";
            using (SqlConnection connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using(SqlCommand command = new SqlCommand(commandText, connection))
                {
                    command.Parameters.AddWithValue("@p_ItemId", item.ItemId);
					command.Parameters.AddWithValue("@p_ProductId", item.ProductId);
					command.Parameters.AddWithValue("@p_ListPrice", ADOHelper.NullCheck(item.ListPrice));
					command.Parameters.AddWithValue("@p_UnitCost", ADOHelper.NullCheck(item.UnitCost));
					command.Parameters.AddWithValue("@p_Supplier", ADOHelper.NullCheck(item.Supplier));
					command.Parameters.AddWithValue("@p_Status", ADOHelper.NullCheck(item.Status));
					command.Parameters.AddWithValue("@p_Name", ADOHelper.NullCheck(item.Name));
					command.Parameters.AddWithValue("@p_Image", ADOHelper.NullCheck(item.Image));

                    using(var reader = new SafeDataReader(command.ExecuteReader()))
                    {
                        if(reader.Read())
                        {
                        }
                    }
                }
            }

            item.OriginalItemId = item.ItemId;

            MarkOld(item);
            CheckRules(item);
            
            if(!stopProccessingChildren)
            {
            // Update Child Items.
                Update_Product_ProductMember_ProductId(ref item);
                Update_Supplier_SupplierMember_Supplier(ref item);
            }

            OnInserted();
        }

        #endregion

        #region Update

        [Transactional(TransactionalTypes.TransactionScope)]
        public Item Update(Item item)
        {
            return Update(item, false);
        }

        public Item Update(Item item, bool stopProccessingChildren)
        {
            if(item.IsDeleted)
            {
                DoDelete(ref item);
                MarkNew(item);
            }
            else if(item.IsNew)
            {
                DoInsert(ref item, stopProccessingChildren);
            }
            else
            {
                DoUpdate(ref item, stopProccessingChildren);
            }

            return item;
        }

        private void DoUpdate(ref Item item, bool stopProccessingChildren)
        {
            bool cancel = false;
            OnUpdating(ref cancel);
            if (cancel) return;

            // Don't update if the item isn't dirty.
            if (item.IsDirty)
            {
                if(item.OriginalItemId != item.ItemId)
                {
                    // Insert new child.
                    var temp = (Item)Activator.CreateInstance(typeof(Item), true);
                    temp.ItemId = item.ItemId;
                    temp.ProductId = item.ProductId;
                    temp.ListPrice = item.ListPrice;
                    temp.UnitCost = item.UnitCost;
                    temp.Supplier = item.Supplier;
                    temp.Status = item.Status;
                    temp.Name = item.Name;
                    temp.Image = item.Image;
                    temp = temp.Save();
    
                    // Mark child lists as dirty. This code may need to be updated to one-to-one relationships.

                    // Update Children
                    Update_Product_ProductMember_ProductId(ref item);
                    Update_Supplier_SupplierMember_Supplier(ref item);
    
                    // Delete the old.
					var criteria = new ItemCriteria {ItemId = item.OriginalItemId};
					
                    Delete(criteria);
    
                    // Mark the original as the new one.
                    item.OriginalItemId = item.ItemId;

                    MarkOld(item);
                    CheckRules(item);
                    OnUpdated();

                    return;
                }

                const string commandText = "UPDATE [dbo].[Item]  SET [ItemId] = @p_ItemId, [ProductId] = @p_ProductId, [ListPrice] = @p_ListPrice, [UnitCost] = @p_UnitCost, [Supplier] = @p_Supplier, [Status] = @p_Status, [Name] = @p_Name, [Image] = @p_Image WHERE [ItemId] = @p_ItemId";
                using (SqlConnection connection = new SqlConnection(ADOHelper.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command = new SqlCommand(commandText, connection))
                    {
                        command.Parameters.AddWithValue("@p_OriginalItemId", item.OriginalItemId);
					command.Parameters.AddWithValue("@p_ItemId", item.ItemId);
					command.Parameters.AddWithValue("@p_ProductId", item.ProductId);
					command.Parameters.AddWithValue("@p_ListPrice", ADOHelper.NullCheck(item.ListPrice));
					command.Parameters.AddWithValue("@p_UnitCost", ADOHelper.NullCheck(item.UnitCost));
					command.Parameters.AddWithValue("@p_Supplier", ADOHelper.NullCheck(item.Supplier));
					command.Parameters.AddWithValue("@p_Status", ADOHelper.NullCheck(item.Status));
					command.Parameters.AddWithValue("@p_Name", ADOHelper.NullCheck(item.Name));
					command.Parameters.AddWithValue("@p_Image", ADOHelper.NullCheck(item.Image));

                        //result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                        int result = command.ExecuteNonQuery();
                        if (result == 0)
                            throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");
                    }
                }
            }

            item.OriginalItemId = item.ItemId;

            MarkOld(item);
            CheckRules(item);

            if(!stopProccessingChildren)
            {
                // Update Child Items.
                Update_Product_ProductMember_ProductId(ref item);
                Update_Supplier_SupplierMember_Supplier(ref item);
            }

            OnUpdated();
        }
        #endregion

        #region Delete

        [Transactional(TransactionalTypes.TransactionScope)]
        public void Delete(ItemCriteria criteria)
        {
            // Note: this call to delete is for immediate deletion and doesn't keep track of any entity state.
            DoDelete(criteria);
        }

        protected void DoDelete(ref Item item)
        {
            // If we're not dirty then don't update the database.
            if (!item.IsDirty) return;

            // If we're new then don't call delete.
            if (item.IsNew) return;

			var criteria = new ItemCriteria{ItemId = item.ItemId};
			
            DoDelete(criteria);

            MarkNew(item);
        }

        /// <summary>
        /// This call to delete is for immediate deletion and doesn't keep track of any entity state.
        /// </summary>
        /// <param name="criteria">The Criteria.</param>
        private void DoDelete(ItemCriteria criteria)
        {
            bool cancel = false;
            OnDeleting(criteria, ref cancel);
            if (cancel) return;

            string commandText = string.Format("DELETE FROM [dbo].[Item] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag));
            using (SqlConnection connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));

                    //result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                    int result = command.ExecuteNonQuery();
                    if (result == 0)
                        throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");
                }
            }

            OnDeleted();
        }

        #endregion

        #region Helper Methods

        public Item Map(SafeDataReader reader)
        {
            var item = (Item)Activator.CreateInstance(typeof(Item), true);
            using (BypassPropertyChecks(item))
            {
                item.ItemId = reader.GetString("ItemId");
                item.OriginalItemId = reader.GetString("ItemId");
                item.ProductId = reader.GetString("ProductId");
                item.ListPrice = reader.IsDBNull("ListPrice") ? (System.Decimal?)null : reader.GetDecimal("ListPrice");
                item.UnitCost = reader.IsDBNull("UnitCost") ? (System.Decimal?)null : reader.GetDecimal("UnitCost");
                item.Supplier = reader.IsDBNull("Supplier") ? (System.Int32?)null : reader.GetInt32("Supplier");
                item.Status = reader.GetString("Status");
                item.Name = reader.GetString("Name");
                item.Image = reader.GetString("Image");
            }
            
            MarkOld(item);

            return item;
        }

        //AssociatedManyToOne
        private static void Update_Product_ProductMember_ProductId(ref Item item)
        {
				item.ProductMember.ProductId = item.ProductId;

            new ProductFactory().Update(item.ProductMember, true);
        }
        //AssociatedManyToOne
        private static void Update_Supplier_SupplierMember_Supplier(ref Item item)
        {
				item.SupplierMember.SuppId = item.Supplier.Value;

            new SupplierFactory().Update(item.SupplierMember, true);
        }

        #endregion

        #region DataPortal partial methods

        partial void OnCreating(ref bool cancel);
        partial void OnCreated();
        partial void OnFetching(ItemCriteria criteria, ref bool cancel);
        partial void OnFetched();
        partial void OnMapping(SafeDataReader reader, ref bool cancel);
        partial void OnMapped();
        partial void OnInserting(ref bool cancel);
        partial void OnInserted();
        partial void OnUpdating(ref bool cancel);
        partial void OnUpdated();
        partial void OnSelfDeleting(ref bool cancel);
        partial void OnSelfDeleted();
        partial void OnDeleting(ItemCriteria criteria, ref bool cancel);
        partial void OnDeleted();

        #endregion
    }
}