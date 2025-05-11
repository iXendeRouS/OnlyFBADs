using MelonLoader;
using BTD_Mod_Helper;
using OnlyFBADs;
using Il2CppAssets.Scripts.Simulation.Track;
using Il2CppAssets.Scripts.Models.Bloons;
using Il2CppAssets.Scripts.Simulation.Bloons;
using Il2CppAssets.Scripts.Unity.UI_New.InGame;

[assembly: MelonInfo(typeof(OnlyFBADs.OnlyFBADs), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace OnlyFBADs;

public class OnlyFBADs : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<OnlyFBADs>("OnlyFBADs loaded!");
    }

    public override void OnBloonEmitted(Spawner spawner, BloonModel bloonModel, int round, int index, float startingDist, ref Bloon bloon)
    {
        base.OnBloonEmitted(spawner, bloonModel, round, index, startingDist, ref bloon);

        if (Settings.modEnabled && InGameData.CurrentGame.IsSandbox && bloonModel.name != "BadFortified")
            bloon.Destroy();
    }
}