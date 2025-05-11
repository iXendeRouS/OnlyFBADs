
using BTD_Mod_Helper.Api.Data;
using BTD_Mod_Helper.Api.ModOptions;

namespace OnlyFBADs
{
    public class Settings : ModSettings
    {
        public static readonly ModSettingBool modEnabled = new(true)
        {
            description = "While enabled, only FBADs will spawn in sandbox rounds."
        };
    }
}
