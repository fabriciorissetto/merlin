////////////////////////////////////////////////////////////////////////////////////
// Merlin API for Albion Online v1.0.327.96272-live
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
    /* Internal type: aea */
    public partial struct Point3
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        
        private aea _internal;
        
        #region Properties
        
        public aea Point3_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public Point3(aea instance)
        {
            _internal = instance;
        }
        
        static Point3()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator aea(Point3 instance)
        {
            return instance._internal;
        }
        
        public static implicit operator Point3(aea instance)
        {
            return new Point3(instance);
        }
        #endregion
    }
}
