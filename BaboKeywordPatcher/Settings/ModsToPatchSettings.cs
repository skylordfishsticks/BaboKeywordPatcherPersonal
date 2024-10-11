#nullable enable
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Synthesis.Settings;
using System.Collections.Generic;

namespace BaboKeywordPatcher.Settings
    {
    public class ModsToPatchSettings
        {
        [SynthesisSettingName("Please choose which mods you would like to include in the patch.")]
        // public HashSet<ModKey> ModsToNotPatch { get; set; } = new HashSet<ModKey>();
        public HashSet<ModKey> ModsToPatch { get; set; } = new HashSet<ModKey>();

        }

    }

