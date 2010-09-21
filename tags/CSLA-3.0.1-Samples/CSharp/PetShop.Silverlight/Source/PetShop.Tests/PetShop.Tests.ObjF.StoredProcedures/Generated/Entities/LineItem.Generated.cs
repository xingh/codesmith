﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.3, CSLA Templates: v3.0.1.1934, CSLA Framework: v4.0.0.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'LineItem.cs'.
//
//     Template: SwitchableObject.Generated.cst
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

namespace PetShop.Tests.ObjF.StoredProcedures
{
    [Serializable]
    [Csla.Server.ObjectFactory(FactoryNames.LineItemFactoryName)]
    public partial class LineItem : BusinessBase< LineItem >
    {
        #region Contructor(s)

        private LineItem()
        { /* Require use of factory methods */ }

        internal LineItem(System.Int32 orderId, System.Int32 lineNum)
        {
            using(BypassPropertyChecks)
            {
                LoadProperty(_orderIdProperty, orderId);
                LoadProperty(_lineNumProperty, lineNum);
            }
        }
        #endregion

        #region Business Rules

        protected override void AddBusinessRules()
        {
            if(AddBusinessValidationRules())
                return;

            BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(_itemIdProperty));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(_itemIdProperty, 10));
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
        private static readonly PropertyInfo< System.String > _itemIdProperty = RegisterProperty< System.String >(p => p.ItemId, string.Empty);
        public System.String ItemId
        {
            get { return GetProperty(_itemIdProperty); }
            set{ SetProperty(_itemIdProperty, value); }
        }
        private static readonly PropertyInfo< System.Int32 > _quantityProperty = RegisterProperty< System.Int32 >(p => p.Quantity, string.Empty);
        public System.Int32 Quantity
        {
            get { return GetProperty(_quantityProperty); }
            set{ SetProperty(_quantityProperty, value); }
        }
        private static readonly PropertyInfo< System.Decimal > _unitPriceProperty = RegisterProperty< System.Decimal >(p => p.UnitPrice, string.Empty);
        public System.Decimal UnitPrice
        {
            get { return GetProperty(_unitPriceProperty); }
            set{ SetProperty(_unitPriceProperty, value); }
        }
        //AssociatedManyToOne
        private static readonly PropertyInfo< Order > _orderMemberProperty = RegisterProperty< Order >(p => p.OrderMember, Csla.RelationshipTypes.Child);
        public Order OrderMember
        {
            get
            {
                bool cancel = false;
                OnChildLoading(_orderMemberProperty, ref cancel);

                if (!cancel)
                {
                    if(!FieldManager.FieldExists(_orderMemberProperty))
                    {
                        var criteria = new PetShop.Tests.ObjF.StoredProcedures.OrderCriteria {OrderId = OrderId};
                        
                        if(PetShop.Tests.ObjF.StoredProcedures.Order.Exists(criteria))
                            LoadProperty(_orderMemberProperty, PetShop.Tests.ObjF.StoredProcedures.Order.GetByOrderId(OrderId));
                    }
                }

                return GetProperty(_orderMemberProperty); 
            }
        }


        #endregion

        #region Synchronous Root Factory Methods 
        
        public static LineItem NewLineItem()
        {
            return DataPortal.Create< LineItem >();
        }

        public static LineItem GetByOrderIdLineNum(System.Int32 orderId, System.Int32 lineNum)
        {
            var criteria = new LineItemCriteria {OrderId = orderId, LineNum = lineNum};
            
            
            return DataPortal.Fetch< LineItem >(criteria);
        }

        public static LineItem GetByOrderId(System.Int32 orderId)
        {
            var criteria = new LineItemCriteria {OrderId = orderId};
            
            
            return DataPortal.Fetch< LineItem >(criteria);
        }

        public static void DeleteLineItem(System.Int32 orderId, System.Int32 lineNum)
        {
                DataPortal.Delete< LineItem >(new LineItemCriteria (orderId, lineNum));
        }
        
        #endregion

        #region Synchronous Child Factory Methods 
        
        internal static LineItem NewLineItemChild()
        {
            return DataPortal.CreateChild< LineItem >();
        }

        internal static LineItem GetByOrderIdLineNumChild(System.Int32 orderId, System.Int32 lineNum)
        {
            var criteria = new LineItemCriteria {OrderId = orderId, LineNum = lineNum};
            

            return DataPortal.FetchChild< LineItem >(criteria);
        }

        internal static LineItem GetByOrderIdChild(System.Int32 orderId)
        {
            var criteria = new LineItemCriteria {OrderId = orderId};
            

            return DataPortal.FetchChild< LineItem >(criteria);
        }

        #endregion
        #region DataPortal partial methods

        partial void OnCreating(ref bool cancel);
        partial void OnCreated();
        partial void OnFetching(LineItemCriteria criteria, ref bool cancel);
        partial void OnFetched();
        partial void OnMapping(SafeDataReader reader, ref bool cancel);
        partial void OnMapped();
        partial void OnInserting(ref bool cancel);
        partial void OnInserted();
        partial void OnUpdating(ref bool cancel);
        partial void OnUpdated();
        partial void OnSelfDeleting(ref bool cancel);
        partial void OnSelfDeleted();
        partial void OnDeleting(LineItemCriteria criteria, ref bool cancel);
        partial void OnDeleted();
        partial void OnChildLoading(Csla.Core.IPropertyInfo childProperty, ref bool cancel);

        #endregion

        #region ChildPortal partial methods

        partial void OnChildCreating(ref bool cancel);
        partial void OnChildCreated();
        partial void OnChildFetching(LineItemCriteria criteria, ref bool cancel);
        partial void OnChildFetched();
        partial void OnChildInserting(SqlConnection connection, ref bool cancel);
        partial void OnChildInserted();
        partial void OnChildUpdating(SqlConnection connection, ref bool cancel);
        partial void OnChildUpdated();
        partial void OnChildSelfDeleting(ref bool cancel);
        partial void OnChildSelfDeleted();
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
                if (FieldManager.FieldExists(_orderMemberProperty) && OrderMember.IsDirty) return true;

                return false;
            }
        }

        #endregion


        #region Exists Command

        public static bool Exists(LineItemCriteria criteria)
        {
            return PetShop.Tests.ObjF.StoredProcedures.ExistsCommand.Execute(criteria);
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