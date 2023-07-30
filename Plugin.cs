using BepInEx;
using HarmonyLib;
using UnityEngine;

namespace Photomod
{
    [BepInPlugin(pluginGuid, pluginName, pluginVersion)]
    public class Plugin : BaseUnityPlugin
    {
        public const string pluginGuid = "com.metalted.zeepkist.photomod";
        public const string pluginName = "Photomod";
        public const string pluginVersion = "1.3.1";

        private void Awake()
        {
            // Plugin startup logic
            Logger.LogInfo($"Plugin {pluginGuid} is loaded!");

            Harmony harmony = new Harmony(pluginGuid);
            harmony.PatchAll();

            PhotomodConfig.InitializeConfig(Config);
        }

        private void Update()
        {
            PhotomodManager.Update();
        }
    }

    [HarmonyPatch(typeof(MainMenuUI), "Awake")]
    public class MainMenuStart
    {
        public static void Prefix()
        {
            PhotomodConfig.ForceReload();
            PhotomodManager.modEnabled = true;
        }
    }
    
    [HarmonyPatch(typeof(LEV_LevelEditorCentral), "Awake")]
    public class LevelEditorAwake
    {
        public static void Prefix()
        {
            PhotomodManager.modEnabled = false;
            PhotomodManager.fcs = null;
            PhotomodManager.spectatorUIHandler = null;
        }
    }

    [HarmonyPatch(typeof(FlyingCameraScript), "Awake")]
    public class FlyingCameraAwake
    {
        public static void Prefix(FlyingCameraScript __instance)
        {
            if (PhotomodManager.modEnabled)
            {
                PhotomodManager.SetFlyingCameraScript(__instance);
            }
        }
    }

    [HarmonyPatch(typeof(SpectatorCameraUI), "Awake")]
    public class SpectatorUIAwake
    {
        public static void Prefix(SpectatorCameraUI __instance)
        {
            if(PhotomodManager.modEnabled)
            {
                PhotomodManager.InitializeSpectatorCameraUI(__instance);
            }            
        }
    }
}
