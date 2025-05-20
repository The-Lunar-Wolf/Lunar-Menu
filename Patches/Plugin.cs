using BepInEx;
using System.ComponentModel;

namespace LunarMenu.Patches
{
    [Description(LunarMenu.PluginInfo.Description)]
    [BepInPlugin(LunarMenu.PluginInfo.GUID, LunarMenu.PluginInfo.Name, LunarMenu.PluginInfo.Version)]
    public class HarmonyPatches : BaseUnityPlugin
    {
        private void OnEnable()
        {
            Menu.ApplyHarmonyPatches();
        }

        private void OnDisable()
        {
            Menu.RemoveHarmonyPatches();
        }
    }
}
