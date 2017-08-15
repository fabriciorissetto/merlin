////////////////////////////////////////////////////////////////////////////////////
// Merlin API for Albion Online v1.0.327.94396-live
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
    /* Internal type: akj.TerritoryType */
    public enum TerritoryType
    {
        NORMAL = 0,
        CASTLE = 1,
        CITY = 2,
        WATCHTOWER = 3,
        SIEGECAMP = 4
    }
    
    public static class TerritoryTypeExtensions
    {
        public static akj.TerritoryType ToInternal(this TerritoryType instance)
        {
            return (akj.TerritoryType)instance;
        }
        
        public static TerritoryType ToWrapped(this akj.TerritoryType instance)
        {
            return (TerritoryType)instance;
        }
    }
}
