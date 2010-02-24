﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.1, CSLA Templates: v2.0.0.1440, CSLA Framework: v3.8.2.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'OrderList.cs'.
//
//     Template: EditableRootList.Generated.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;

using Csla;
using Csla.Data;

#endregion

namespace PetShop.Tests.ParameterizedSQL
{
    [Serializable]
    public partial class OrderList : BusinessListBase< OrderList, Order >
    {    
        #region Contructor(s)
        
        private OrderList()
        { 
            AllowNew = true;
        }
        
        #endregion

        #region Factory Methods 
        
        public static OrderList NewList()
        {
            return DataPortal.Create< OrderList >();
        }

        public static OrderList GetByOrderId(System.Int32 orderId)
        {
            return DataPortal.Fetch< OrderList >(
                new OrderCriteria{OrderId = orderId});
        }

        public static OrderList GetAll()
        {
            return DataPortal.Fetch< OrderList >(new OrderCriteria());
        }

        #endregion

        #region Properties
        
        protected override object AddNewCore()
        {
            Order item = PetShop.Tests.ParameterizedSQL.Order.NewOrder();
            Add(item);
            return item;
        }
        
        #endregion


        #region Exists Command

        public static bool Exists(OrderCriteria criteria)
        {
            return PetShop.Tests.ParameterizedSQL.Order.Exists(criteria);
        }

        #endregion
    }
}