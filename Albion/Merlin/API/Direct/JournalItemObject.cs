////////////////////////////////////////////////////////////////////////////////////
// Merlin API for Albion Online v1.0.332.98217-prod
////////////////////////////////////////////////////////////////////////////////////
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

using UnityEngine;

using Albion.Common.Time;

namespace Merlin.API.Direct
{
    /* Internal type: atj */
    public partial class JournalItemObject : DurableItemObject
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private atj _internal;
        
        #region Properties
        
        public atj JournalItemObject_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public JournalItemObject(atj instance) : base(instance)
        {
            _internal = instance;
        }
        
        static JournalItemObject()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator atj(JournalItemObject instance)
        {
            return instance._internal;
        }
        
        public static implicit operator JournalItemObject(atj instance)
        {
            return new JournalItemObject(instance);
        }
        
        public static implicit operator bool(JournalItemObject instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
