//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.1, CSLA Templates: v1.5.0.1357, CSLA Framework: v3.8.0.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Category.cs'.
//
//     Template: DynamicRoot.DataAccess.StoredProcedures.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;
using System.Data;
using System.Data.SqlClient;

using Csla;
using Csla.Data;

#endregion

namespace PetShop.Tests.Collections.DynamicRoot
{
    public partial class Category
    {
        [RunLocal]
        protected override void DataPortal_Create()
        {
            bool cancel = false;
            OnCreating(ref cancel);
            if (cancel) return;

            ValidationRules.CheckRules();

            OnCreated();
        }

        private void DataPortal_Fetch(CategoryCriteria criteria)
        {
            bool cancel = false;
            OnFetching(criteria, ref cancel);
            if (cancel) return;

            using (SqlConnection connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("[dbo].[CSLA_Category_Select]", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));
                    using(var reader = new SafeDataReader(command.ExecuteReader()))
                    {
                        if(reader.Read())
                            Map(reader);
                        else
                            throw new Exception(string.Format("The record was not found in 'Category' using the following criteria: {0}.", criteria));
                    }
                }
            }

            OnFetched();

            MarkOld();
        }

        [Transactional(TransactionalTypes.TransactionScope)]
        protected override void DataPortal_Insert()
        {
            bool cancel = false;
            OnInserting(ref cancel);
            if (cancel) return;

            using (SqlConnection connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using(SqlCommand command = new SqlCommand("[dbo].[CSLA_Category_Insert]", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@p_CategoryId", CategoryId);
					command.Parameters.AddWithValue("@p_Name", Name);
					command.Parameters.AddWithValue("@p_Descn", Descn);

                    command.ExecuteNonQuery();
                }
            }

            OnInserted();

        }

        [Transactional(TransactionalTypes.TransactionScope)]
        protected override void DataPortal_Update()
        {
            bool cancel = false;
            OnUpdating(ref cancel);
            if (cancel) return;

            using (SqlConnection connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using(SqlCommand command = new SqlCommand("[dbo].[CSLA_Category_Update]", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@p_CategoryId", CategoryId);
					command.Parameters.AddWithValue("@p_Name", Name);
					command.Parameters.AddWithValue("@p_Descn", Descn);

                    //result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                    int result = command.ExecuteNonQuery();
                    if (result == 0)
                        throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");
                }
            }

            OnUpdated();

        }

        [Transactional(TransactionalTypes.TransactionScope)]
        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(new CategoryCriteria(CategoryId));
        }

        [Transactional(TransactionalTypes.TransactionScope)]
        protected void DataPortal_Delete(CategoryCriteria criteria)
        {
            bool cancel = false;
            OnDeleting(criteria, ref cancel);
            if (cancel) return;

            using (SqlConnection connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("[dbo].[CSLA_Category_Delete]", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));
                    
                    //result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                    int result = command.ExecuteNonQuery();
                    if (result == 0)
                        throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");
                }
            }

            OnDeleted();
        }

        private void Map(SafeDataReader reader)
        {
            using(BypassPropertyChecks)
            {
                LoadProperty(_categoryIdProperty, reader.GetString("CategoryId"));
                LoadProperty(_nameProperty, reader.GetString("Name"));
                LoadProperty(_descnProperty, reader.GetString("Descn"));
            }

            MarkOld();
        }

        #region Data access partial methods

        partial void OnCreating(ref bool cancel);
        partial void OnCreated();
        partial void OnFetching(CategoryCriteria criteria, ref bool cancel);
        partial void OnFetched();
        partial void OnInserting(ref bool cancel);
        partial void OnInserted();
        partial void OnUpdating(ref bool cancel);
        partial void OnUpdated();
        partial void OnSelfDeleting(ref bool cancel);
        partial void OnSelfDeleted();
        partial void OnDeleting(CategoryCriteria criteria, ref bool cancel);
        partial void OnDeleted();

        #endregion
    }
}
