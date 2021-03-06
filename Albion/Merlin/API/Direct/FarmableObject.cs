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
    /* Internal type: a10 */
    public partial class FarmableObject : BuildingObject
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private a10 _internal;
        
        #region Properties
        
        public a10 FarmableObject_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public FarmableObject(a10 instance) : base(instance)
        {
            _internal = instance;
        }
        
        static FarmableObject()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator a10(FarmableObject instance)
        {
            return instance._internal;
        }
        
        public static implicit operator FarmableObject(a10 instance)
        {
            return new FarmableObject(instance);
        }
        
        public static implicit operator bool(FarmableObject instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
