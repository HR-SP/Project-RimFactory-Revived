using RimWorld;
using Verse;

namespace ProjectRimFactory.SAL3.Tools
{
    class BasePowerUtil
    {
        public static readonly float idlePower = -10f;
        public static readonly float scanningPower = -30f;
        public static float getDefaultPower(Thing thing)
        {
            float defPower = (float)thing.def.GetCompProperties<CompProperties_Power>()?.basePowerConsumption;
            return defPower * -1f;
        }
    }
}
