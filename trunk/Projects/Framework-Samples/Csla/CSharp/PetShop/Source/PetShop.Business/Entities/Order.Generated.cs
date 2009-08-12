//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CSLA 3.7.X CodeSmith Templates.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Order.cs'.
//
//     Template: SwitchableObject.Generated.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region using declarations

using System;

using Csla;
using Csla.Data;
using Csla.Validation;

#endregion

namespace PetShop.Business
{
	[Serializable]
	public partial class Order : BusinessBase< Order >
	{
        #region Contructor(s)

		private Order()
		{ /* Require use of factory methods */ }
        
        internal Order(SafeDataReader reader)
        {
            Fetch(reader);
        }
        
		#endregion
        
		#region Validation Rules
		
		protected override void AddBusinessRules()
		{
            if(AddBusinessValidationRules())
                return;
            
			ValidationRules.AddRule(CommonRules.StringRequired, "UserId");
			ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs("UserId", 20));
			ValidationRules.AddRule(CommonRules.StringRequired, "ShipAddr1");
			ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs("ShipAddr1", 80));
			ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs("ShipAddr2", 80));
			ValidationRules.AddRule(CommonRules.StringRequired, "ShipCity");
			ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs("ShipCity", 80));
			ValidationRules.AddRule(CommonRules.StringRequired, "ShipState");
			ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs("ShipState", 80));
			ValidationRules.AddRule(CommonRules.StringRequired, "ShipZip");
			ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs("ShipZip", 20));
			ValidationRules.AddRule(CommonRules.StringRequired, "ShipCountry");
			ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs("ShipCountry", 20));
			ValidationRules.AddRule(CommonRules.StringRequired, "BillAddr1");
			ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs("BillAddr1", 80));
			ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs("BillAddr2", 80));
			ValidationRules.AddRule(CommonRules.StringRequired, "BillCity");
			ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs("BillCity", 80));
			ValidationRules.AddRule(CommonRules.StringRequired, "BillState");
			ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs("BillState", 80));
			ValidationRules.AddRule(CommonRules.StringRequired, "BillZip");
			ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs("BillZip", 20));
			ValidationRules.AddRule(CommonRules.StringRequired, "BillCountry");
			ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs("BillCountry", 20));
			ValidationRules.AddRule(CommonRules.StringRequired, "Courier");
			ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs("Courier", 80));
			ValidationRules.AddRule(CommonRules.StringRequired, "BillToFirstName");
			ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs("BillToFirstName", 80));
			ValidationRules.AddRule(CommonRules.StringRequired, "BillToLastName");
			ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs("BillToLastName", 80));
			ValidationRules.AddRule(CommonRules.StringRequired, "ShipToFirstName");
			ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs("ShipToFirstName", 80));
			ValidationRules.AddRule(CommonRules.StringRequired, "ShipToLastName");
			ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs("ShipToLastName", 80));
			ValidationRules.AddRule(CommonRules.StringRequired, "Locale");
			ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs("Locale", 20));
		}
		
		#endregion
		
		#region Business Methods


		private static readonly PropertyInfo< int > _orderIdProperty = RegisterProperty< int >(p => p.OrderId);
		[System.ComponentModel.DataObjectField(true, true)]
		public int OrderId
		{
			get { return GetProperty(_orderIdProperty); }				
		}
		
		private static readonly PropertyInfo< string > _userIdProperty = RegisterProperty< string >(p => p.UserId);
		public string UserId
		{
			get { return GetProperty(_userIdProperty); }				
            set
            { 
                OnPropertyChanging("UserId");
                SetProperty(_userIdProperty, value); 
                OnPropertyChanged("UserId");
            }
		}
		
		private static readonly PropertyInfo< SmartDate > _orderDateProperty = RegisterProperty< SmartDate >(p => p.OrderDate);
		public SmartDate OrderDate
		{
			get { return GetProperty(_orderDateProperty); }				
            set
            { 
                OnPropertyChanging("OrderDate");
                SetProperty(_orderDateProperty, value); 
                OnPropertyChanged("OrderDate");
            }
		}
		
		private static readonly PropertyInfo< string > _shipAddr1Property = RegisterProperty< string >(p => p.ShipAddr1);
		public string ShipAddr1
		{
			get { return GetProperty(_shipAddr1Property); }				
            set
            { 
                OnPropertyChanging("ShipAddr1");
                SetProperty(_shipAddr1Property, value); 
                OnPropertyChanged("ShipAddr1");
            }
		}
		
		private static readonly PropertyInfo< string > _shipAddr2Property = RegisterProperty< string >(p => p.ShipAddr2);
		public string ShipAddr2
		{
			get { return GetProperty(_shipAddr2Property); }				
            set
            { 
                OnPropertyChanging("ShipAddr2");
                SetProperty(_shipAddr2Property, value); 
                OnPropertyChanged("ShipAddr2");
            }
		}
		
		private static readonly PropertyInfo< string > _shipCityProperty = RegisterProperty< string >(p => p.ShipCity);
		public string ShipCity
		{
			get { return GetProperty(_shipCityProperty); }				
            set
            { 
                OnPropertyChanging("ShipCity");
                SetProperty(_shipCityProperty, value); 
                OnPropertyChanged("ShipCity");
            }
		}
		
		private static readonly PropertyInfo< string > _shipStateProperty = RegisterProperty< string >(p => p.ShipState);
		public string ShipState
		{
			get { return GetProperty(_shipStateProperty); }				
            set
            { 
                OnPropertyChanging("ShipState");
                SetProperty(_shipStateProperty, value); 
                OnPropertyChanged("ShipState");
            }
		}
		
		private static readonly PropertyInfo< string > _shipZipProperty = RegisterProperty< string >(p => p.ShipZip);
		public string ShipZip
		{
			get { return GetProperty(_shipZipProperty); }				
            set
            { 
                OnPropertyChanging("ShipZip");
                SetProperty(_shipZipProperty, value); 
                OnPropertyChanged("ShipZip");
            }
		}
		
		private static readonly PropertyInfo< string > _shipCountryProperty = RegisterProperty< string >(p => p.ShipCountry);
		public string ShipCountry
		{
			get { return GetProperty(_shipCountryProperty); }				
            set
            { 
                OnPropertyChanging("ShipCountry");
                SetProperty(_shipCountryProperty, value); 
                OnPropertyChanged("ShipCountry");
            }
		}
		
		private static readonly PropertyInfo< string > _billAddr1Property = RegisterProperty< string >(p => p.BillAddr1);
		public string BillAddr1
		{
			get { return GetProperty(_billAddr1Property); }				
            set
            { 
                OnPropertyChanging("BillAddr1");
                SetProperty(_billAddr1Property, value); 
                OnPropertyChanged("BillAddr1");
            }
		}
		
		private static readonly PropertyInfo< string > _billAddr2Property = RegisterProperty< string >(p => p.BillAddr2);
		public string BillAddr2
		{
			get { return GetProperty(_billAddr2Property); }				
            set
            { 
                OnPropertyChanging("BillAddr2");
                SetProperty(_billAddr2Property, value); 
                OnPropertyChanged("BillAddr2");
            }
		}
		
		private static readonly PropertyInfo< string > _billCityProperty = RegisterProperty< string >(p => p.BillCity);
		public string BillCity
		{
			get { return GetProperty(_billCityProperty); }				
            set
            { 
                OnPropertyChanging("BillCity");
                SetProperty(_billCityProperty, value); 
                OnPropertyChanged("BillCity");
            }
		}
		
		private static readonly PropertyInfo< string > _billStateProperty = RegisterProperty< string >(p => p.BillState);
		public string BillState
		{
			get { return GetProperty(_billStateProperty); }				
            set
            { 
                OnPropertyChanging("BillState");
                SetProperty(_billStateProperty, value); 
                OnPropertyChanged("BillState");
            }
		}
		
		private static readonly PropertyInfo< string > _billZipProperty = RegisterProperty< string >(p => p.BillZip);
		public string BillZip
		{
			get { return GetProperty(_billZipProperty); }				
            set
            { 
                OnPropertyChanging("BillZip");
                SetProperty(_billZipProperty, value); 
                OnPropertyChanged("BillZip");
            }
		}
		
		private static readonly PropertyInfo< string > _billCountryProperty = RegisterProperty< string >(p => p.BillCountry);
		public string BillCountry
		{
			get { return GetProperty(_billCountryProperty); }				
            set
            { 
                OnPropertyChanging("BillCountry");
                SetProperty(_billCountryProperty, value); 
                OnPropertyChanged("BillCountry");
            }
		}
		
		private static readonly PropertyInfo< string > _courierProperty = RegisterProperty< string >(p => p.Courier);
		public string Courier
		{
			get { return GetProperty(_courierProperty); }				
            set
            { 
                OnPropertyChanging("Courier");
                SetProperty(_courierProperty, value); 
                OnPropertyChanged("Courier");
            }
		}
		
		private static readonly PropertyInfo< decimal > _totalPriceProperty = RegisterProperty< decimal >(p => p.TotalPrice);
		public decimal TotalPrice
		{
			get { return GetProperty(_totalPriceProperty); }				
            set
            { 
                OnPropertyChanging("TotalPrice");
                SetProperty(_totalPriceProperty, value); 
                OnPropertyChanged("TotalPrice");
            }
		}
		
		private static readonly PropertyInfo< string > _billToFirstNameProperty = RegisterProperty< string >(p => p.BillToFirstName);
		public string BillToFirstName
		{
			get { return GetProperty(_billToFirstNameProperty); }				
            set
            { 
                OnPropertyChanging("BillToFirstName");
                SetProperty(_billToFirstNameProperty, value); 
                OnPropertyChanged("BillToFirstName");
            }
		}
		
		private static readonly PropertyInfo< string > _billToLastNameProperty = RegisterProperty< string >(p => p.BillToLastName);
		public string BillToLastName
		{
			get { return GetProperty(_billToLastNameProperty); }				
            set
            { 
                OnPropertyChanging("BillToLastName");
                SetProperty(_billToLastNameProperty, value); 
                OnPropertyChanged("BillToLastName");
            }
		}
		
		private static readonly PropertyInfo< string > _shipToFirstNameProperty = RegisterProperty< string >(p => p.ShipToFirstName);
		public string ShipToFirstName
		{
			get { return GetProperty(_shipToFirstNameProperty); }				
            set
            { 
                OnPropertyChanging("ShipToFirstName");
                SetProperty(_shipToFirstNameProperty, value); 
                OnPropertyChanged("ShipToFirstName");
            }
		}
		
		private static readonly PropertyInfo< string > _shipToLastNameProperty = RegisterProperty< string >(p => p.ShipToLastName);
		public string ShipToLastName
		{
			get { return GetProperty(_shipToLastNameProperty); }				
            set
            { 
                OnPropertyChanging("ShipToLastName");
                SetProperty(_shipToLastNameProperty, value); 
                OnPropertyChanged("ShipToLastName");
            }
		}
		
		private static readonly PropertyInfo< int > _authorizationNumberProperty = RegisterProperty< int >(p => p.AuthorizationNumber);
		public int AuthorizationNumber
		{
			get { return GetProperty(_authorizationNumberProperty); }				
            set
            { 
                OnPropertyChanging("AuthorizationNumber");
                SetProperty(_authorizationNumberProperty, value); 
                OnPropertyChanged("AuthorizationNumber");
            }
		}
		
		private static readonly PropertyInfo< string > _localeProperty = RegisterProperty< string >(p => p.Locale);
		public string Locale
		{
			get { return GetProperty(_localeProperty); }				
            set
            { 
                OnPropertyChanging("Locale");
                SetProperty(_localeProperty, value); 
                OnPropertyChanged("Locale");
            }
		}
		
		private static readonly PropertyInfo< LineItem > _lineItemProperty = RegisterProperty< LineItem >(p => p.LineItem, Csla.RelationshipTypes.LazyLoad);
		public LineItem LineItem
		{
			get
            {
                if(!FieldManager.FieldExists(_lineItemProperty))
                    SetProperty(_lineItemProperty, LineItem.GetLineItem(OrderId));

                   return GetProperty(_lineItemProperty); 
            }
		}

		private static readonly PropertyInfo< OrderStatus > _orderStatusProperty = RegisterProperty< OrderStatus >(p => p.OrderStatus, Csla.RelationshipTypes.LazyLoad);
		public OrderStatus OrderStatus
		{
			get
            {
                if(!FieldManager.FieldExists(_orderStatusProperty))
                    SetProperty(_orderStatusProperty, OrderStatus.GetOrderStatus(OrderId));

                   return GetProperty(_orderStatusProperty); 
            }
		}

		#endregion
				
		#region Root Factory Methods 
		
		public static Order NewOrder()
		{
			return DataPortal.Create< Order >();
		}
		
		public static Order GetOrder(int orderId)
		{
			return DataPortal.Fetch< Order >(
                new OrderCriteria(orderId));
		}

        public static void DeleteOrder(int orderId)
		{
                DataPortal.Delete(new OrderCriteria(orderId));
		}
		
		#endregion
		
		#region Child Factory Methods 
		
		internal static Order NewOrderChild()
		{
			return DataPortal.CreateChild< Order >();
		}
		
		public static Order GetOrderChild(int orderId)
		{
            return DataPortal.FetchChild< Order >(
				new OrderCriteria(orderId));
		}

		#endregion
		
	}
}