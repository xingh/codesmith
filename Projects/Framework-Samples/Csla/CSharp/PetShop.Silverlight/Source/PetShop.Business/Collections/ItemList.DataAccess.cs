﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.2, CSLA Templates: v3.0.0.1866, CSLA Framework: v4.0.0.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'ItemList.cs'.
//
//     Template: EditableChildList.DataAccess.ParameterizedSQL.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#if !SILVERLIGHT
#region Using declarations

using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

using Csla;
using Csla.Data;

#endregion

namespace PetShop.Business
{
    public partial class ItemList
    {
    	protected override void Child_Create()
		{
            bool cancel = false;
            OnCreating(ref cancel);
            if (cancel) return;
	    
			OnCreated();
		}
	
        private void Child_Fetch(ItemCriteria criteria)
        {
            bool cancel = false;
            OnFetching(criteria, ref cancel);
            if (cancel) return;

            RaiseListChangedEvents = false;

            // Fetch Child objects.
            string commandText = string.Format("SELECT [ItemId], [ProductId], [ListPrice], [UnitCost], [Supplier], [Status], [Name], [Image] FROM [dbo].[Item] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag));
            using (SqlConnection connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));

                    using(var reader = new SafeDataReader(command.ExecuteReader()))
                    {
                        if(reader.Read())
                        {
                            do
                            {
                                this.Add(new Item(reader));
                            } while(reader.Read());
                        }
                    }
                }
            }

            RaiseListChangedEvents = true;

            OnFetched();
        }
        
        /// <summary>
        /// Updates the child object.
        /// </summary>
        /// <param name="parameters">The parameters collection may contain more parameters than needed based on the context it was called. We need to filter this list.</param>
        protected override void Child_Update(params object[] parameters)
        {
            bool cancel = false;
            OnUpdating(ref cancel);
            if (cancel) return;

            // We require that one of the parameters be a connection so we can do the CRUD operations.
            SqlConnection connection = parameters.OfType<SqlConnection>().FirstOrDefault();
            if (connection == null)
                throw new ArgumentNullException("parameters", "Must contain a SqlConnection parameter.");

            RaiseListChangedEvents = false;

            foreach (var item in DeletedList)
            {
                DataPortal.UpdateChild(item, connection);
            }

            DeletedList.Clear();
            
            // Trim down the list to what is actually contained in the child class.
            var list = new System.Collections.Generic.Dictionary<string, object>() {};
            foreach (object o in parameters)
            {
                if(o == null) continue;

                var key = o.GetType().ToString();
                if (!list.ContainsKey(key))
                    list.Add(key, o);
            }

            foreach (var item in Items)
            {
                DataPortal.UpdateChild(item, list.Values.ToArray());
            }

            RaiseListChangedEvents = true;

            OnUpdated();
        }
    }
}
#endif
