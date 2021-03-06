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
    /* Internal type: hv.b.a */
    public partial class HarvestableRareStateDescriptor
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private hv.b.a _internal;
        
        #region Properties
        
        public hv.b.a HarvestableRareStateDescriptor_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public HarvestableRareStateDescriptor(hv.b.a instance)
        {
            _internal = instance;
        }
        
        static HarvestableRareStateDescriptor()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator hv.b.a(HarvestableRareStateDescriptor instance)
        {
            return instance._internal;
        }
        
        public static implicit operator HarvestableRareStateDescriptor(hv.b.a instance)
        {
            return new HarvestableRareStateDescriptor(instance);
        }
        
        public static implicit operator bool(HarvestableRareStateDescriptor instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
