using System.Reflection;
using HarmonyLib;
using Verse;

namespace FasterDevSpeed
{
    [StaticConstructorOnStartup]
    internal static class FasterDevSpeed
    {
        static FasterDevSpeed()
        {
            Log.Message("FasterDevSpeed starting up");

            var harmony = new Harmony("rimworld.sparr.fasterdevspeed");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}