using HarmonyLib;
using InventorySystem.Items.Usables.Scp330;


namespace EvilPump
{
    [HarmonyPatch(typeof(CandyBlack), "get_SpawnChanceWeight")]
    public static class CandyBlackPumper
    {
        public static void Postfix(ref float __result)
        {
            __result = Plugin.Instance.Config.BlackCandyChange;
        }
    }

    [HarmonyPatch(typeof(CandyBlue), "get_SpawnChanceWeight")]
    public static class CandyBluePumper
    {
        public static void Postfix(ref float __result)
        {
            __result = Plugin.Instance.Config.BlueCandyChange;
        }
    }

    [HarmonyPatch(typeof(CandyBrown), "get_SpawnChanceWeight")]
    public static class CandyBrownPumper
    {
        public static void Postfix(ref float __result)
        {
            __result = Plugin.Instance.Config.BrownCandyChange;
        }
    }

    [HarmonyPatch(typeof(CandyEvil), "get_SpawnChanceWeight")]
    public static class CandyEvilPumper
    {
        public static void Postfix(ref float __result)
        {
            __result = Plugin.Instance.Config.EvilCandyChange;
        }
    }

    [HarmonyPatch(typeof(CandyGray), "get_SpawnChanceWeight")]
    public static class CandyGrayPumper
    {
        public static void Postfix(ref float __result)
        {
            __result = Plugin.Instance.Config.GreyCandyChange;
        }
    }

    [HarmonyPatch(typeof(CandyGreen), "get_SpawnChanceWeight")]
    public static class CandyGreenPumper
    {
        public static void Postfix(ref float __result)
        {
            __result = Plugin.Instance.Config.GreenCandyChange;
        }
    }

    [HarmonyPatch(typeof(CandyOrange), "get_SpawnChanceWeight")]
    public static class CandyOrangePumper
    {
        public static void Postfix(ref float __result)
        {
            __result = Plugin.Instance.Config.OrangeCandyChange;
        }
    }

    [HarmonyPatch(typeof(CandyPink), "get_SpawnChanceWeight")]
    public static class CandyPinkPumper
    {
        public static void Postfix(ref float __result)
        {
            __result = Plugin.Instance.Config.PinkCandyChange;
        }
    }

    [HarmonyPatch(typeof(CandyPurple), "get_SpawnChanceWeight")]
    public static class CandyPurplePumper
    {
        public static void Postfix(ref float __result)
        {
            __result = Plugin.Instance.Config.PurpleCandyChange;
        }
    }

    [HarmonyPatch(typeof(CandyRainbow), "get_SpawnChanceWeight")]
    public static class CandyRainbowPumper
    {
        public static void Postfix(ref float __result)
        {
            __result = Plugin.Instance.Config.RainbowCandyChange;
        }
    }

    [HarmonyPatch(typeof(CandyRed), "get_SpawnChanceWeight")]
    public static class CandyRedPumper
    {
        public static void Postfix(ref float __result)
        {
            __result = Plugin.Instance.Config.RedCandyChange;
        }
    }

    [HarmonyPatch(typeof(CandyWhite), "get_SpawnChanceWeight")]
    public static class CandyWhitePumper
    {
        public static void Postfix(ref float __result)
        {
            __result = Plugin.Instance.Config.WhiteCandyChange;
        }
    }

    [HarmonyPatch(typeof(CandyYellow), "get_SpawnChanceWeight")]
    public static class CandyYellowPumper
    {
        public static void Postfix(ref float __result)
        {
            __result = Plugin.Instance.Config.YellowCandyChange;
        }
    }
}
