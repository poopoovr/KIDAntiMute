using BepInEx;
using HarmonyLib;
using UnityEngine;

namespace KIDAntiMute;

[BepInPlugin("com.poopoovr.kidantimute", "KIDAntiMute", "1.0.0")]
public class Plugin : BaseUnityPlugin
{
    void Awake()
    {
        var harmony = new Harmony("com.poopoovr.kidantimute");
        harmony.PatchAll(typeof(Patches).Assembly);
        Logger.LogInfo("KIDAntiMute loaded");
    }
}
