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
    /* Internal type: awt */
    public partial class LocalPlayerCharacter : PlayerCharacter
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private awt _internal;
        
        #region Properties
        
        public awt LocalPlayerCharacter_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public ObservableRange<acy> GetCraftingFocus() => _internal.sd();
        public Point2 GetDestination() => _internal.tl();
        public GameTimeStamp GetGlobalCooldownTimeStamp() => _internal.th();
        public float GetSpellSlotCooldownPercent(byte A_0) => _internal.hk((byte)A_0);
        public SpellSlot[] GetSpellSlots() => _internal.tg().Select(x =>(SpellSlot)x).ToArray();
        public float GetWeight() => _internal.ua();
        
        #endregion
        
        #region Constructor
        
        public LocalPlayerCharacter(awt instance) : base(instance)
        {
            _internal = instance;
        }
        
        static LocalPlayerCharacter()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator awt(LocalPlayerCharacter instance)
        {
            return instance._internal;
        }
        
        public static implicit operator LocalPlayerCharacter(awt instance)
        {
            return new LocalPlayerCharacter(instance);
        }
        
        public static implicit operator bool(LocalPlayerCharacter instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
