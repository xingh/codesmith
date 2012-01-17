﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v6.0.2, CSLA Templates: v3.0.3.2430, CSLA Framework: v4.0.0.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'OrderStatus.cs'.
//
//     Template: EditableChild.DataAccess.StoredProcedures.cst
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

namespace PetShop.Tests.StoredProcedures
{
    public partial class OrderStatus
    {
        protected override void Child_Create()
        {
            bool cancel = false;
            OnChildCreating(ref cancel);
            if (cancel) return;


            BusinessRules.CheckRules();

            OnChildCreated();
        }

        private void Child_Fetch(OrderStatusCriteria criteria)
        {
            bool cancel = false;
            OnChildFetching(criteria, ref cancel);
            if (cancel) return;

            using (SqlConnection connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("[dbo].[CSLA_OrderStatus_Select]", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));
                    
                    using(var reader = new SafeDataReader(command.ExecuteReader()))
                    {
                        if(reader.Read())
                            Map(reader);
                        else
                            throw new Exception(string.Format("The record was not found in 'OrderStatus' using the following criteria: {0}.", criteria));
                    }
                }
            }

            OnChildFetched();
        }

        #region Child_Insert

        private void Child_Insert(SqlConnection connection)
        {
            bool cancel = false;
            OnChildInserting(connection, ref cancel);
            if (cancel) return;

            if(connection.State != ConnectionState.Open) connection.Open();
            using(SqlCommand command = new SqlCommand("[dbo].[CSLA_OrderStatus_Insert]", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@p_OrderId", this.OrderId);
					command.Parameters.AddWithValue("@p_LineNum", this.LineNum);
					command.Parameters.AddWithValue("@p_Timestamp", this.Timestamp);
					command.Parameters.AddWithValue("@p_Status", this.Status);

                command.ExecuteNonQuery();

                // Update the original non-identity primary key value.
                LoadProperty(_originalOrderIdProperty, this.OrderId);

                // Update the original non-identity primary key value.
                LoadProperty(_originalLineNumProperty, this.LineNum);
            }

            FieldManager.UpdateChildren(this, connection);

            OnChildInserted();
        }

        private void Child_Insert(Order order, SqlConnection connection)
        {
            bool cancel = false;
            OnChildInserting(connection, ref cancel);
            if (cancel) return;

            if(connection.State != ConnectionState.Open) connection.Open();
            using(SqlCommand command = new SqlCommand("[dbo].[CSLA_OrderStatus_Insert]", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@p_OrderId", order != null ? order.OrderId : this.OrderId);
					command.Parameters.AddWithValue("@p_LineNum", this.LineNum);
					command.Parameters.AddWithValue("@p_Timestamp", this.Timestamp);
					command.Parameters.AddWithValue("@p_Status", this.Status);

                command.ExecuteNonQuery();

            // Update foreign keys values. This code will update the values passed in from the parent only if no errors occurred after executing the query.
            if(order != null && order.OrderId != this.OrderId)
                LoadProperty(_orderIdProperty, order.OrderId);

                // Update the original non-identity primary key value.
                LoadProperty(_originalOrderIdProperty, this.OrderId);

                // Update the original non-identity primary key value.
                LoadProperty(_originalLineNumProperty, this.LineNum);
            }
            
            // A child relationship exists on this Business Object but its type is not a child type (E.G. EditableChild). 
            // TODO: Please override OnChildInserted() and insert this child manually.
            // FieldManager.UpdateChildren(this, connection);

            OnChildInserted();
        }

        #endregion

        #region Child_Update

        private void Child_Update(SqlConnection connection)
        {
            bool cancel = false;
            OnChildUpdating(connection, ref cancel);
            if (cancel) return;

            if(connection.State != ConnectionState.Open) connection.Open();
            using(SqlCommand command = new SqlCommand("[dbo].[CSLA_OrderStatus_Update]", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@p_OriginalOrderId", this.OriginalOrderId);
					command.Parameters.AddWithValue("@p_OrderId", this.OrderId);
					command.Parameters.AddWithValue("@p_OriginalLineNum", this.OriginalLineNum);
					command.Parameters.AddWithValue("@p_LineNum", this.LineNum);
					command.Parameters.AddWithValue("@p_Timestamp", this.Timestamp);
					command.Parameters.AddWithValue("@p_Status", this.Status);

                //result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                int result = command.ExecuteNonQuery();
                if (result == 0)
                    throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");

                // Update non-identity primary key value.
                LoadProperty(_orderIdProperty,(System.Int32)command.Parameters["@p_OrderId"].Value);

                // Update non-identity primary key value.
                LoadProperty(_lineNumProperty,(System.Int32)command.Parameters["@p_LineNum"].Value);

                // Update non-identity primary key value.
                LoadProperty(_originalOrderIdProperty, this.OrderId);

                // Update non-identity primary key value.
                LoadProperty(_originalLineNumProperty, this.LineNum);
            }

            FieldManager.UpdateChildren(this, connection);

            OnChildUpdated();
        }
 
        private void Child_Update(Order order, SqlConnection connection)
        {
            bool cancel = false;
            OnChildUpdating(connection, ref cancel);
            if (cancel) return;

            if(connection.State != ConnectionState.Open) connection.Open();
            using(SqlCommand command = new SqlCommand("[dbo].[CSLA_OrderStatus_Update]", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@p_OriginalOrderId", order != null ? order.OrderId : this.OriginalOrderId);
					command.Parameters.AddWithValue("@p_OrderId", order != null ? order.OrderId : this.OrderId);
					command.Parameters.AddWithValue("@p_OriginalLineNum", this.OriginalLineNum);
					command.Parameters.AddWithValue("@p_LineNum", this.LineNum);
					command.Parameters.AddWithValue("@p_Timestamp", this.Timestamp);
					command.Parameters.AddWithValue("@p_Status", this.Status);

                //result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                int result = command.ExecuteNonQuery();
                if (result == 0)
                    throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");

                // Update non-identity primary key value.
                LoadProperty(_orderIdProperty,(System.Int32)command.Parameters["@p_OrderId"].Value);

                // Update non-identity primary key value.
                LoadProperty(_lineNumProperty,(System.Int32)command.Parameters["@p_LineNum"].Value);

                // Update foreign keys values. This code will update the values passed in from the parent only if no errors occurred after executing the query.
                if(order != null && order.OrderId != this.OrderId)
                    LoadProperty(_orderIdProperty, order.OrderId);

                // Update non-identity primary key value.
                LoadProperty(_originalOrderIdProperty, this.OrderId);

                // Update non-identity primary key value.
                LoadProperty(_originalLineNumProperty, this.LineNum);
            }
            
            // A child relationship exists on this Business Object but its type is not a child type (E.G. EditableChild). 
            // TODO: Please override OnChildUpdated() and update this child manually.
            // FieldManager.UpdateChildren(this, connection);

            OnChildUpdated();
        }
        #endregion

        private void Child_DeleteSelf(SqlConnection connection)
        {
            bool cancel = false;
            OnChildSelfDeleting(connection, ref cancel);
            if (cancel) return;
            
            DataPortal_Delete(new OrderStatusCriteria (OrderId, LineNum), connection);
        
            OnChildSelfDeleted();
        }

        protected void DataPortal_Delete(OrderStatusCriteria criteria, SqlConnection connection)
        {
            bool cancel = false;
            OnDeleting(criteria, connection, ref cancel);
            if (cancel) return;

            using (SqlCommand command = new SqlCommand("[dbo].[CSLA_OrderStatus_Delete]", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));

                //result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                int result = command.ExecuteNonQuery();
                if (result == 0)
                    throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");
            }

            OnDeleted();
        }

        private void Map(SafeDataReader reader)
        {
            bool cancel = false;
            OnMapping(reader, ref cancel);
            if (cancel) return;

            using(BypassPropertyChecks)
            {
                LoadProperty(_orderIdProperty, reader["OrderId"]);
                LoadProperty(_originalOrderIdProperty, reader["OrderId"]);
                LoadProperty(_lineNumProperty, reader["LineNum"]);
                LoadProperty(_originalLineNumProperty, reader["LineNum"]);
                LoadProperty(_timestampProperty, reader["Timestamp"]);
                LoadProperty(_statusProperty, reader["Status"]);
            }

            OnMapped();

            MarkAsChild();
            MarkOld();
        }
    }
}
