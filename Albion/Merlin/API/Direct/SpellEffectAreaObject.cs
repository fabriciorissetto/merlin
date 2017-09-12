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
    /* Internal type: ase */
    public partial class SpellEffectAreaObject : MovingObject
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private ase _internal;
        
        #region Properties
        
        public ase SpellEffectAreaObject_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public ActiveSpellDescriptor GetDescriptor() => _internal.sb();
        
        #endregion
        
        #region Constructor
        
        public SpellEffectAreaObject(ase instance) : base(instance)
        {
            _internal = instance;
        }
        
        static SpellEffectAreaObject()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator ase(SpellEffectAreaObject instance)
        {
            return instance._internal;
        }
        
        public static implicit operator SpellEffectAreaObject(ase instance)
        {
            return new SpellEffectAreaObject(instance);
        }
        
        public static implicit operator bool(SpellEffectAreaObject instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
