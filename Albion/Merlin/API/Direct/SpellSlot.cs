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
    /* Internal type: aew */
    public partial class SpellSlot
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private aew _internal;
        
        #region Properties
        
        public aew SpellSlot_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public float GetCooldownPercent(GameTimeStamp A_0) => _internal.j((GameTimeStamp)A_0);
        public GameTimeStamp GetCooldownTimeStamp() => _internal.l();
        public CastSpellDescriptor GetSpellDescriptor() => _internal.h();
        
        #endregion
        
        #region Constructor
        
        public SpellSlot(aew instance)
        {
            _internal = instance;
        }
        
        static SpellSlot()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator aew(SpellSlot instance)
        {
            return instance._internal;
        }
        
        public static implicit operator SpellSlot(aew instance)
        {
            return new SpellSlot(instance);
        }
        
        public static implicit operator bool(SpellSlot instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
