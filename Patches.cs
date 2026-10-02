using HarmonyLib;
using GorillaNetworking;

namespace KIDAntiMute;

[HarmonyPatch(typeof(GorillaComputer), nameof(GorillaComputer.CheckVoiceChatEnabled))]
static class PatchCheckVoiceChatEnabled
{
    static bool Prefix(ref bool __result)
    {
        __result = true;
        return false;
    }
}

[HarmonyPatch(typeof(GorillaComputer), "SetVoiceChatBySafety")]
static class PatchSetVoiceChatBySafety
{
    static bool Prefix()
    {
        return false;
    }
}

[HarmonyPatch(typeof(GorillaComputer), "KID_SetVoiceChatSettingOnStart")]
static class PatchKIDSetVoiceChatOnStart
{
    static bool Prefix()
    {
        return false;
    }
}

[HarmonyPatch(typeof(PlayFabAuthenticator), nameof(PlayFabAuthenticator.GetSafety))]
static class PatchGetSafety
{
    static bool Prefix(ref bool __result)
    {
        __result = false;
        return false;
    }
}
