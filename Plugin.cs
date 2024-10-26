using Exiled.API.Features;
using HarmonyLib;
using InventorySystem.Items.Usables.Scp330;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvilPump
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin Instance { get; private set; }

        public override string Author => "ZurnaSever";

        public override string Name => "EvilPump";

        public override string Prefix => "EvilPump";

        public override Version RequiredExiledVersion { get; } = new Version(8, 13, 1);

        public override Version Version { get; } = new Version(1, 0, 0);
        private Harmony harmony;
        public override void OnEnabled()
        {
            Instance = this;
            harmony = new Harmony("EvilCandyPump");
            harmony.PatchAll();
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            Instance = null;
            harmony.UnpatchAll("EvilCandyPump");
            base.OnDisabled();
        }
    }
}
