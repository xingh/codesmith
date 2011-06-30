#pragma warning disable 1591
#pragma warning disable 0414        
//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using Sakila.Data;

namespace Sakila.Data.Entities
{
    [System.Runtime.Serialization.DataContract(IsReference = true)]
    [System.ComponentModel.DataAnnotations.ScaffoldTable(true)]
    [System.Diagnostics.DebuggerDisplay("ActorId: {ActorId}")]
    public partial class Actor : EntityBase
    {
        #region Static Constructor
        
        /// <summary>
        /// Initializes the <see cref="Account"/> class.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        static Actor()
        {
            AddSharedRules();
        }
        
        #endregion

        #region Default Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="Account"/> class.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public Actor()
        {
            Initialize();
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        protected override void Initialize()
        {
            OnCreated();
        }
        
        #endregion
        
        #region Column Mapped Properties
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        private System.Int16 _actorId;
        
        [System.Runtime.Serialization.DataMember(Order = 1)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public virtual System.Int16 ActorId
        {
            get { return _actorId; }
            set
            {
                OnActorIdChanging(value, _actorId);
                SendPropertyChanging("ActorId");
                _actorId = value;
                SendPropertyChanged("ActorId");
                OnActorIdChanged(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        private System.String _firstName;
        
        [System.Runtime.Serialization.DataMember(Order = 2)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public virtual System.String FirstName
        {
            get { return _firstName; }
            set
            {
                OnFirstNameChanging(value, _firstName);
                SendPropertyChanging("FirstName");
                _firstName = value;
                SendPropertyChanged("FirstName");
                OnFirstNameChanged(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        private System.String _lastName;
        
        [System.Runtime.Serialization.DataMember(Order = 3)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public virtual System.String LastName
        {
            get { return _lastName; }
            set
            {
                OnLastNameChanging(value, _lastName);
                SendPropertyChanging("LastName");
                _lastName = value;
                SendPropertyChanged("LastName");
                OnLastNameChanged(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        private System.DateTime _lastUpdate;
        
        [System.Runtime.Serialization.DataMember(Order = 4)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public virtual System.DateTime LastUpdate
        {
            get { return _lastUpdate; }
            set
            {
                OnLastUpdateChanging(value, _lastUpdate);
                SendPropertyChanging("LastUpdate");
                _lastUpdate = value;
                SendPropertyChanged("LastUpdate");
                OnLastUpdateChanged(value);
            }
        }
        
        #endregion
        
        #region Associations Mappings
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        private IList<Film> _filmList;
        
        [System.Runtime.Serialization.DataMember(Order = 5, EmitDefaultValue = false)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public virtual IList<Film> FilmList
        {
            get { return _filmList; }
            set
            {
                OnFilmListChanging(value, _filmList);
                SendPropertyChanging("FilmList");
                _filmList = value;
                SendPropertyChanged("FilmList");
                OnFilmListChanged(value);
            }
        }
        
        #endregion
        
        #region Extensibility Method
        
        static partial void AddSharedRules();
        
        partial void OnCreated();
        
        partial void OnActorIdChanging(System.Int16 newValue, System.Int16 oldValue);
        
        partial void OnActorIdChanged(System.Int16 value);
        
        partial void OnFirstNameChanging(System.String newValue, System.String oldValue);
        
        partial void OnFirstNameChanged(System.String value);
        
        partial void OnLastNameChanging(System.String newValue, System.String oldValue);
        
        partial void OnLastNameChanged(System.String value);
        
        partial void OnLastUpdateChanging(System.DateTime newValue, System.DateTime oldValue);
        
        partial void OnLastUpdateChanged(System.DateTime value);
        
        
        partial void OnFilmListChanging(IList<Film> newValue, IList<Film> oldValue);
        
        partial void OnFilmListChanged(IList<Film> value);
        
        #endregion
        
        #region Clone
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public virtual Actor Clone()
        {
            return (Actor)((ICloneable)this).Clone();
        }
        
        #endregion
        
        #region Serialization
        
        /// <summary>
        /// Deserializes an instance of <see cref="Account"/> from XML.
        /// </summary>
        /// <param name="xml">The XML string representing a <see cref="Account"/> instance.</param>
        /// <returns>An instance of <see cref="Account"/> that is deserialized from the XML string.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static Actor FromXml(string xml)
        {
            var deserializer = new System.Runtime.Serialization.DataContractSerializer(typeof(Actor));

            using (var sr = new System.IO.StringReader(xml))
            using (var reader = System.Xml.XmlReader.Create(sr))
            {
                return deserializer.ReadObject(reader) as Actor;
            }
        }

        /// <summary>
        /// Deserializes an instance of <see cref="Account"/> from a byte array.
        /// </summary>
        /// <param name="buffer">The byte array representing a <see cref="Account"/> instance.</param>
        /// <returns>An instance of <see cref="Account"/> that is deserialized from the byte array.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static Actor FromBinary(byte[] buffer)
        {
            var deserializer = new System.Runtime.Serialization.DataContractSerializer(typeof(Actor));

            using (var ms = new System.IO.MemoryStream(buffer))
            using (var reader = System.Xml.XmlDictionaryReader.CreateBinaryReader(ms, System.Xml.XmlDictionaryReaderQuotas.Max))
            {
                return deserializer.ReadObject(reader) as Actor;
            }
        }
        
        #endregion
    }
}

#pragma warning restore 1591
#pragma warning restore 0414
