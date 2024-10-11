using Mutagen.Bethesda.Synthesis.Settings;

namespace BaboKeywordPatcher.Settings
    {
    public class MainSettings
        {
        [SynthesisSettingName("Please choose which KeyWords you would like to include in the patch.")]
        public KWDSettings kwdSettings = new();

        [SynthesisSettingName("Please choose which mods you would like to include in the patch.")]
        public ModsToPatchSettings modstopatchSettings = new();

        /*public bool EnableDebugMode = false;*/
        }
    }
