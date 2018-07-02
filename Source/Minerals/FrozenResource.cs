﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;   // Always needed
using RimWorld;      // RimWorld specific functions 
using Verse;         // RimWorld universal objects 

namespace Minerals
{
    /// <summary>
    /// FrozenResource class
    /// </summary>
    /// <author>zachary-foster</author>
    /// <permission>No restrictions</permission>
    public class FrozenResource : ThingWithComps
    {

        public virtual ThingDef_FrozenResource attributes
        {
            get
            {
                return this.def as ThingDef_FrozenResource;
            }
        }


        public override void TickRare()
        {
            // Melt if hot
            float temp = this.Position.GetTemperature(this.Map);
            if (temp > 0)
            {
                float meltDamage = temp / 10;
                base.TakeDamage(new DamageInfo(DamageDefOf.Rotting, (int) meltDamage, -1, null, null, null, DamageInfo.SourceCategory.ThingOrUnknown));
            }

            base.TickRare();
        }

    }       



    /// <summary>
    /// ThingDef_FrozenResource class.
    /// </summary>
    /// <author>zachary-foster</author>
    /// <permission>No restrictions</permission>
    public class ThingDef_FrozenResource : ThingDef
    {

    }

}
