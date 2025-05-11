
using BTD_Mod_Helper.Api.Data;
using BTD_Mod_Helper.Api.ModOptions;

namespace OnlyFBADs
{
    public class Settings : ModSettings
    {
        public static readonly ModSettingBool ModEnabled = new(true)
        {
            description = "While enabled, only FBADs will spawn in sandbox rounds."
        };

        public static readonly ModSettingBool IncludeRegularBads = new(false)
        {
            description = "Also allow regular BADs to spawn."
        };
    }
}
