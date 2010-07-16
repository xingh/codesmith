﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.2, CSLA Templates: v3.0.0.1817, CSLA Framework: v4.0.0.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'OrderStatus.cs'.
//
//     Template: EditableChild.Generated.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;

using Csla;
using Csla.Rules;
using Csla.Data;
using System.Data.SqlClient;

#endregion

namespace PetShop.Tests.StoredProcedures
{
    [Serializable]
    public partial class OrderStatus : BusinessBase< OrderStatus >
    {
        #region Contructor(s)

        private OrderStatus()
        {
            // require use of factory method.
            MarkAsChild();
        }

        internal OrderStatus(System.Int32 orderId, System.Int32 lineNum)
        {
            using(BypassPropertyChecks)
            {
                LoadProperty(_orderIdProperty, orderId);
                LoadProperty(_lineNumProperty, lineNum);
            }

            MarkAsChild();
        }

        internal OrderStatus(SafeDataReader reader)
        {
            Map(reader);

            MarkAsChild();
        }
        #endregion

        #region Business Rules

        protected override void AddBusinessRules()
        {
            if(AddBusinessValidationRules())
                return;

            BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(_statusProperty));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(_statusProperty, 2));
        }

        #endregion

        #region Properties

        private static readonly PropertyInfo< System.Int32 > _orderIdProperty = RegisterProperty< System.Int32 >(p => p.OrderId, string.Empty);
		[System.ComponentModel.DataObjectField(true, false)]
        public System.Int32 OrderId
        {
            get { return GetProperty(_orderIdProperty); }
            set{ SetProperty(_orderIdProperty, value); }
        }

        private static readonly PropertyInfo< System.Int32 > _originalOrderIdProperty = RegisterProperty< System.Int32 >(p => p.OriginalOrderId, string.Empty);
        /// <summary>
        /// Holds the original value for OrderId. This is used for non identity primary keys.
        /// </summary>
        internal System.Int32 OriginalOrderId
        {
            get { return GetProperty(_originalOrderIdProperty); }
            set{ SetProperty(_originalOrderIdProperty, value); }
        }
        private static readonly PropertyInfo< System.Int32 > _lineNumProperty = RegisterProperty< System.Int32 >(p => p.LineNum, string.Empty);
		[System.ComponentModel.DataObjectField(true, false)]
        public System.Int32 LineNum
        {
            get { return GetProperty(_lineNumProperty); }
            set{ SetProperty(_lineNumProperty, value); }
        }

        private static readonly PropertyInfo< System.Int32 > _originalLineNumProperty = RegisterProperty< System.Int32 >(p => p.OriginalLineNum, string.Empty);
        /// <summary>
        /// Holds the original value for LineNum. This is used for non identity primary keys.
        /// </summary>
        internal System.Int32 OriginalLineNum
        {
            get { return GetProperty(_originalLineNumProperty); }
            set{ SetProperty(_originalLineNumProperty, value); }
        }
        private static readonly PropertyInfo< System.DateTime > _timestampProperty = RegisterProperty< System.DateTime >(p => p.Timestamp, string.Empty);
        public System.DateTime Timestamp
        {
            get { return GetProperty(_timestampProperty); }
            set{ SetProperty(_timestampProperty, value); }
        }
        private static readonly PropertyInfo< System.String > _statusProperty = RegisterProperty< System.String >(p => p.Status, string.Empty);
        public System.String Status
        {
            get { return GetProperty(_statusProperty); }
            set{ SetProperty(_statusProperty, value); }
        }

        //AssociatedManyToOne
        private static readonly PropertyInfo< Order > _orderMemberProperty = RegisterProperty< Order >(p => p.OrderMember, Csla.RelationshipTypes.Child);
        public Order OrderMember
        {
            get
            {
                if(false)
                    return null;
                
                if(!FieldManager.FieldExists(_orderMemberProperty))
                {
					var criteria = new PetShop.Tests.StoredProcedures.OrderCriteria {OrderId = OrderId};
					
                    
                    if(PetShop.Tests.StoredProcedures.Order.Exists(criteria))
                        LoadProperty(_orderMemberProperty, PetShop.Tests.StoredProcedures.Order.GetByOrderId(OrderId));
                }

                return GetProperty(_orderMemberProperty); 
            }
        }
        #endregion

        #region Synchronous Factory Methods 

        internal static OrderStatus NewOrderStatus()
        {
            return DataPortal.CreateChild< OrderStatus >();
        }

        internal static OrderStatus GetByOrderIdLineNum(System.Int32 orderId, System.Int32 lineNum)
        {
			var criteria = new OrderStatusCriteria {OrderId = orderId, LineNum = lineNum};
			
        
            return DataPortal.FetchChild< OrderStatus >(criteria);
        }

        internal static OrderStatus GetByOrderId(System.Int32 orderId)
        {
			var criteria = new OrderStatusCriteria {OrderId = orderId};
			
        
            return DataPortal.FetchChild< OrderStatus >(criteria);
        }

        #endregion

        #region ChildPortal partial methods

        partial void OnChildCreating(ref bool cancel);
        partial void OnChildCreated();
        partial void OnChildFetching(OrderStatusCriteria criteria, ref bool cancel);
        partial void OnChildFetched();
        partial void OnMapping(SafeDataReader reader, ref bool cancel);
        partial void OnMapped();
        partial void OnChildInserting(SqlConnection connection, ref bool cancel);
        partial void OnChildInserted();
        partial void OnChildUpdating(SqlConnection connection, ref bool cancel);
        partial void OnChildUpdated();
        partial void OnChildSelfDeleting(SqlConnection connection, ref bool cancel);
        partial void OnChildSelfDeleted();
        partial void OnDeleting(OrderStatusCriteria criteria, ref bool cancel);
        partial void OnDeleting(OrderStatusCriteria criteria, SqlConnection connection, ref bool cancel);
        partial void OnDeleted();

        #endregion

        #region Exists Command

        public static bool Exists(OrderStatusCriteria criteria)
        {
            return ExistsCommand.Execute(criteria);
        }

        #endregion


        #region Protected Overriden Method(s)

        // NOTE: This is needed for Composite Keys. 
        private readonly Guid _guidID = Guid.NewGuid();
        protected override object GetIdValue()
        {
            return _guidID;
        }

        #endregion
    }
}