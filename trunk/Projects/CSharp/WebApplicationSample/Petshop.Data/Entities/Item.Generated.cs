﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Linq;

namespace Petshop.Data
{
    /// <summary>
    /// The class representing the dbo.Item table.
    /// </summary>
    [System.Data.Linq.Mapping.Table(Name="dbo.Item")]
    [System.Runtime.Serialization.DataContract(IsReference = true)]
    [System.ComponentModel.DataAnnotations.ScaffoldTable(true)]
    [System.ComponentModel.DataAnnotations.MetadataType(typeof(Metadata))]
    [System.Data.Services.Common.DataServiceKey("ItemId")]
    [System.Diagnostics.DebuggerDisplay("ItemId: {ItemId}")]
    public partial class Item
        : LinqEntityBase, ICloneable
    {
        #region Static Constructor
        /// <summary>
        /// Initializes the <see cref="Item"/> class.
        /// </summary>
        static Item()
        {
            CodeSmith.Data.Rules.RuleManager.AddShared<Item>();
            AddSharedRules();
        }
        #endregion

        #region Default Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="Item"/> class.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode]
        public Item()
        {
            Initialize();
        }

        private void Initialize()
        {
            _product = default(System.Data.Linq.EntityRef<Product>);
            _supplier1 = default(System.Data.Linq.EntityRef<Supplier>);
            OnCreated();
        }
        #endregion

        #region Column Mapped Properties

        private string _itemId;

        /// <summary>
        /// Gets or sets the ItemId column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "ItemId", Storage = "_itemId", DbType = "varchar(10) NOT NULL", IsPrimaryKey = true, CanBeNull = false)]
        [System.ComponentModel.DataAnnotations.StringLength(10)]
        [System.Runtime.Serialization.DataMember(Order = 1)]
        public string ItemId
        {
            get { return _itemId; }
            set
            {
                if (_itemId != value)
                {
                    OnItemIdChanging(value);
                    SendPropertyChanging("ItemId");
                    _itemId = value;
                    SendPropertyChanged("ItemId");
                    OnItemIdChanged();
                }
            }
        }

        private string _productId;

        /// <summary>
        /// Gets or sets the ProductId column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "ProductId", Storage = "_productId", DbType = "varchar(10) NOT NULL", CanBeNull = false)]
        [System.ComponentModel.DataAnnotations.StringLength(10)]
        [System.Runtime.Serialization.DataMember(Order = 2)]
        public string ProductId
        {
            get { return _productId; }
            set
            {
                if (_productId != value)
                {
                    if (_product.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    OnProductIdChanging(value);
                    SendPropertyChanging("ProductId");
                    _productId = value;
                    SendPropertyChanged("ProductId");
                    OnProductIdChanged();
                }
            }
        }

        private Nullable<decimal> _listPrice;

        /// <summary>
        /// Gets or sets the ListPrice column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "ListPrice", Storage = "_listPrice", DbType = "decimal(10,2)")]
        [System.Runtime.Serialization.DataMember(Order = 3)]
        public Nullable<decimal> ListPrice
        {
            get { return _listPrice; }
            set
            {
                if (_listPrice != value)
                {
                    OnListPriceChanging(value);
                    SendPropertyChanging("ListPrice");
                    _listPrice = value;
                    SendPropertyChanged("ListPrice");
                    OnListPriceChanged();
                }
            }
        }

        private Nullable<decimal> _unitCost;

        /// <summary>
        /// Gets or sets the UnitCost column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "UnitCost", Storage = "_unitCost", DbType = "decimal(10,2)")]
        [System.Runtime.Serialization.DataMember(Order = 4)]
        public Nullable<decimal> UnitCost
        {
            get { return _unitCost; }
            set
            {
                if (_unitCost != value)
                {
                    OnUnitCostChanging(value);
                    SendPropertyChanging("UnitCost");
                    _unitCost = value;
                    SendPropertyChanged("UnitCost");
                    OnUnitCostChanged();
                }
            }
        }

        private Nullable<int> _supplier;

        /// <summary>
        /// Gets or sets the Supplier column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "Supplier", Storage = "_supplier", DbType = "int")]
        [System.Runtime.Serialization.DataMember(Order = 5)]
        public Nullable<int> Supplier
        {
            get { return _supplier; }
            set
            {
                if (_supplier != value)
                {
                    if (_supplier1.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    OnSupplierChanging(value);
                    SendPropertyChanging("Supplier");
                    _supplier = value;
                    SendPropertyChanged("Supplier");
                    OnSupplierChanged();
                }
            }
        }

        private string _status;

        /// <summary>
        /// Gets or sets the Status column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "Status", Storage = "_status", DbType = "varchar(2)")]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        [System.Runtime.Serialization.DataMember(Order = 6)]
        public string Status
        {
            get { return _status; }
            set
            {
                if (_status != value)
                {
                    OnStatusChanging(value);
                    SendPropertyChanging("Status");
                    _status = value;
                    SendPropertyChanged("Status");
                    OnStatusChanged();
                }
            }
        }

        private string _name;

        /// <summary>
        /// Gets or sets the Name column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "Name", Storage = "_name", DbType = "varchar(80)")]
        [System.ComponentModel.DataAnnotations.StringLength(80)]
        [System.Runtime.Serialization.DataMember(Order = 7)]
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    OnNameChanging(value);
                    SendPropertyChanging("Name");
                    _name = value;
                    SendPropertyChanged("Name");
                    OnNameChanged();
                }
            }
        }

        private string _image;

        /// <summary>
        /// Gets or sets the Image column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "Image", Storage = "_image", DbType = "varchar(80)")]
        [System.ComponentModel.DataAnnotations.StringLength(80)]
        [System.Runtime.Serialization.DataMember(Order = 8)]
        public string Image
        {
            get { return _image; }
            set
            {
                if (_image != value)
                {
                    OnImageChanging(value);
                    SendPropertyChanging("Image");
                    _image = value;
                    SendPropertyChanged("Image");
                    OnImageChanged();
                }
            }
        }
        #endregion

        #region Association Mapped Properties

        private System.Data.Linq.EntityRef<Product> _product;

        /// <summary>
        /// Gets or sets the Product association.
        /// </summary>
        [System.Data.Linq.Mapping.Association(Name = "Product_Item", Storage = "_product", ThisKey = "ProductId", OtherKey = "ProductId", IsUnique = true, IsForeignKey = true, DeleteOnNull = true)]
        [System.Runtime.Serialization.DataMember(Order = 9, EmitDefaultValue = false)]
        public Product Product
        {
            get { return (serializing && !_product.HasLoadedOrAssignedValue) ? null : _product.Entity; }
            set
            {
                Product previousValue = _product.Entity;
                if (previousValue != value || _product.HasLoadedOrAssignedValue == false)
                {
                    OnProductChanging(value);
                    SendPropertyChanging("Product");
                    if (previousValue != null)
                    {
                        _product.Entity = null;
                        previousValue.ItemList.Remove(this);
                    }
                    _product.Entity = value;
                    if (value != null)
                    {
                        value.ItemList.Add(this);
                        _productId = value.ProductId;
                    }
                    else
                    {
                        _productId = default(string);
                    }
                    SendPropertyChanged("Product");
                    OnProductChanged();
                }
            }
        }
        

        private System.Data.Linq.EntityRef<Supplier> _supplier1;

        /// <summary>
        /// Gets or sets the Supplier association.
        /// </summary>
        [System.Data.Linq.Mapping.Association(Name = "Supplier_Item", Storage = "_supplier1", ThisKey = "Supplier", OtherKey = "SuppId", IsUnique = true, IsForeignKey = true)]
        [System.Runtime.Serialization.DataMember(Order = 10, EmitDefaultValue = false)]
        public Supplier Supplier1
        {
            get { return (serializing && !_supplier1.HasLoadedOrAssignedValue) ? null : _supplier1.Entity; }
            set
            {
                Supplier previousValue = _supplier1.Entity;
                if (previousValue != value || _supplier1.HasLoadedOrAssignedValue == false)
                {
                    OnSupplier1Changing(value);
                    SendPropertyChanging("Supplier1");
                    if (previousValue != null)
                    {
                        _supplier1.Entity = null;
                        previousValue.ItemList.Remove(this);
                    }
                    _supplier1.Entity = value;
                    if (value != null)
                    {
                        value.ItemList.Add(this);
                        _supplier = value.SuppId;
                    }
                    else
                    {
                        _supplier = default(Nullable<int>);
                    }
                    SendPropertyChanged("Supplier1");
                    OnSupplier1Changed();
                }
            }
        }
        
        #endregion

        #region Extensibility Method Definitions
        /// <summary>Called by the static constructor to add shared rules.</summary>
        static partial void AddSharedRules();
        /// <summary>Called when this instance is loaded.</summary>
        partial void OnLoaded();
        /// <summary>Called when this instance is being saved.</summary>
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        /// <summary>Called when this instance is created.</summary>
        partial void OnCreated();
        /// <summary>Called when <see cref="ItemId"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnItemIdChanging(string value);
        /// <summary>Called after <see cref="ItemId"/> has Changed.</summary>
        partial void OnItemIdChanged();
        /// <summary>Called when <see cref="ProductId"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnProductIdChanging(string value);
        /// <summary>Called after <see cref="ProductId"/> has Changed.</summary>
        partial void OnProductIdChanged();
        /// <summary>Called when <see cref="ListPrice"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnListPriceChanging(Nullable<decimal> value);
        /// <summary>Called after <see cref="ListPrice"/> has Changed.</summary>
        partial void OnListPriceChanged();
        /// <summary>Called when <see cref="UnitCost"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnUnitCostChanging(Nullable<decimal> value);
        /// <summary>Called after <see cref="UnitCost"/> has Changed.</summary>
        partial void OnUnitCostChanged();
        /// <summary>Called when <see cref="Supplier"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnSupplierChanging(Nullable<int> value);
        /// <summary>Called after <see cref="Supplier"/> has Changed.</summary>
        partial void OnSupplierChanged();
        /// <summary>Called when <see cref="Status"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnStatusChanging(string value);
        /// <summary>Called after <see cref="Status"/> has Changed.</summary>
        partial void OnStatusChanged();
        /// <summary>Called when <see cref="Name"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnNameChanging(string value);
        /// <summary>Called after <see cref="Name"/> has Changed.</summary>
        partial void OnNameChanged();
        /// <summary>Called when <see cref="Image"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnImageChanging(string value);
        /// <summary>Called after <see cref="Image"/> has Changed.</summary>
        partial void OnImageChanged();
        /// <summary>Called when <see cref="Product"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnProductChanging(Product value);
        /// <summary>Called after <see cref="Product"/> has Changed.</summary>
        partial void OnProductChanged();
        /// <summary>Called when <see cref="Supplier1"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnSupplier1Changing(Supplier value);
        /// <summary>Called after <see cref="Supplier1"/> has Changed.</summary>
        partial void OnSupplier1Changed();

        #endregion

        #region Serialization
        private bool serializing;

        /// <summary>
        /// Called when serializing.
        /// </summary>
        /// <param name="context">The <see cref="System.Runtime.Serialization.StreamingContext"/> for the serialization.</param>
        [System.Runtime.Serialization.OnSerializing]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public void OnSerializing(System.Runtime.Serialization.StreamingContext context) {
            serializing = true;
        }

        /// <summary>
        /// Called when serialized.
        /// </summary>
        /// <param name="context">The <see cref="System.Runtime.Serialization.StreamingContext"/> for the serialization.</param>
        [System.Runtime.Serialization.OnSerialized]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public void OnSerialized(System.Runtime.Serialization.StreamingContext context) {
            serializing = false;
        }

        /// <summary>
        /// Called when deserializing.
        /// </summary>
        /// <param name="context">The <see cref="System.Runtime.Serialization.StreamingContext"/> for the serialization.</param>
        [System.Runtime.Serialization.OnDeserializing]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public void OnDeserializing(System.Runtime.Serialization.StreamingContext context) {
            Initialize();
        }

        /// <summary>
        /// Deserializes an instance of <see cref="Item"/> from XML.
        /// </summary>
        /// <param name="xml">The XML string representing a <see cref="Item"/> instance.</param>
        /// <returns>An instance of <see cref="Item"/> that is deserialized from the XML string.</returns>
        public static Item FromXml(string xml)
        {
            var deserializer = new System.Runtime.Serialization.DataContractSerializer(typeof(Item));

            using (var sr = new System.IO.StringReader(xml))
            using (var reader = System.Xml.XmlReader.Create(sr))
            {
                return deserializer.ReadObject(reader) as Item;
            }
        }

        /// <summary>
        /// Deserializes an instance of <see cref="Item"/> from a byte array.
        /// </summary>
        /// <param name="buffer">The byte array representing a <see cref="Item"/> instance.</param>
        /// <returns>An instance of <see cref="Item"/> that is deserialized from the byte array.</returns>
        public static Item FromBinary(byte[] buffer)
        {
            var deserializer = new System.Runtime.Serialization.DataContractSerializer(typeof(Item));

            using (var ms = new System.IO.MemoryStream(buffer))
            using (var reader = System.Xml.XmlDictionaryReader.CreateBinaryReader(ms, System.Xml.XmlDictionaryReaderQuotas.Max))
            {
                return deserializer.ReadObject(reader) as Item;
            }
        }
        #endregion

        #region Clone
        /// <summary>
        /// Creates a new object that is a copy of the current instance.
        /// </summary>
        /// <returns>
        /// A new object that is a copy of this instance.
        /// </returns>
        object ICloneable.Clone()
        {
            var serializer = new System.Runtime.Serialization.DataContractSerializer(GetType());
            using (var ms = new System.IO.MemoryStream())
            {
                serializer.WriteObject(ms, this);
                ms.Position = 0;
                return serializer.ReadObject(ms);
            }
        }

        /// <summary>
        /// Creates a new object that is a copy of the current instance.
        /// </summary>
        /// <returns>
        /// A new object that is a copy of this instance.
        /// </returns>
        /// <remarks>
        /// Only loaded <see cref="T:System.Data.Linq.EntityRef`1"/> and <see cref="T:System.Data.Linq.EntitySet`1" /> child accessions will be cloned.
        /// </remarks>
        public Item Clone()
        {
            return (Item)((ICloneable)this).Clone();
        }
        #endregion

        #region Detach Methods
        /// <summary>
        /// Detach this instance from the <see cref="System.Data.Linq.DataContext"/>.
        /// </summary>
        /// <remarks>
        /// Detaching the entity will stop all lazy loading and allow it to be added to another <see cref="System.Data.Linq.DataContext"/>.
        /// </remarks>
        public override void Detach()
        {
            if (!IsAttached())
                return;

            base.Detach();
            _product = Detach(_product);
            _supplier1 = Detach(_supplier1);
        }
        #endregion
    }
}
