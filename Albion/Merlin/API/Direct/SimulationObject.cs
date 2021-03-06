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
    /* Internal type: as3 */
    public partial class SimulationObject
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private as3 _internal;
        
        #region Properties
        
        public as3 SimulationObject_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public long GetId() => _internal.az();
        
        #endregion
        
        #region Constructor
        
        public SimulationObject(as3 instance)
        {
            _internal = instance;
        }
        
        static SimulationObject()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator as3(SimulationObject instance)
        {
            return instance._internal;
        }
        
        public static implicit operator SimulationObject(as3 instance)
        {
            return new SimulationObject(instance);
        }
        
        public static implicit operator bool(SimulationObject instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
