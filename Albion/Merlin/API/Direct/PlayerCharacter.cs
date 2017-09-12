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
    /* Internal type: aws */
    public partial class PlayerCharacter : FightingObject
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private aws _internal;
        
        #region Properties
        
        public aws PlayerCharacter_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public string GetAllianceName() => _internal.jo();
        public string GetGuildName() => _internal.ji();
        public bool GetIsHarvesting() => _internal.vd();
        public bool GetIsMounted() => _internal.u3();
        public bool GetIsMounting() => _internal.ve();
        public MountItemDescriptor GetMount() => _internal.u4();
        public ObservableRange<ac1> GetMountHealth() => _internal.u5();
        public PlayerCharacterDescriptor GetPlayerDescriptor() => _internal.uz();
        public ObservableRange<acz> GetReputation() => _internal.u6();
        public Guid GetUid() => _internal.@as();
        
        #endregion
        
        #region Constructor
        
        public PlayerCharacter(aws instance) : base(instance)
        {
            _internal = instance;
        }
        
        static PlayerCharacter()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator aws(PlayerCharacter instance)
        {
            return instance._internal;
        }
        
        public static implicit operator PlayerCharacter(aws instance)
        {
            return new PlayerCharacter(instance);
        }
        
        public static implicit operator bool(PlayerCharacter instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
