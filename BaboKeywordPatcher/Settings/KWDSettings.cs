#nullable enable
//using Mutagen.Bethesda.WPF.Reflection.Attributes;
using Mutagen.Bethesda.Synthesis.Settings;

namespace BaboKeywordPatcher.Settings
    {
    public class KWDSettings
        {
        // Active settings
        //[SynthesisOrder]

        /*        [SynthesisTooltip("SLA_AnalPlugBeads")]
                public bool AnalBeadsDefault { get; set; }
                [SynthesisTooltip("SLA_AnalPlug")]
                public bool AnalPlugDefault { get; set; }
                public bool AnalPlugTailDefault { get; set; }
                public bool ArmorCapeFullDefault { get; set; }
                public bool ArmorCurtainDefault { get; set; }
                public bool ArmorEroticDefault { get; set; }
                public bool ArmorFemaleOnlyDefault { get; set; }
                public bool ArmorHalfNakedBikiniDefault { get; set; }
                public bool ArmorHalfNakedDefault { get; set; }
                public bool ArmorHarnessDefault { get; set; }
                public bool ArmorIllegalDefault { get; set; }
                public bool ArmorLewdLeotardDefault { get; set; }
                public bool ArmorPartBottomDefault { get; set; }
                public bool ArmorPartTopDefault { get; set; }
                public bool ArmorPrettyDefault { get; set; }
                public bool ArmorRubberDefault { get; set; }
                public bool ArmorSpendexDefault { get; set; }
                public bool ArmorTransparentDefault { get; set; }
                public bool BootsHeelsDefault { get; set; }
                public bool BraArmorDefault { get; set; }
                // public bool BrabikiniDefault { get; set; }
                public bool EarringsDefault { get; set; }
                public bool EroticDresses { get; set; }
                public bool FullSkirtDefault { get; set; }
                public bool HasLeggingsDefault { get; set; }
                public bool HasSleevesDefault { get; set; }
                public bool HasStockingsDefault { get; set; }
                public bool ImpossibleClothesDefault { get; set; }
                public bool KillerHeelsDefault { get; set; }
                public bool MicroHotpantsDefault { get; set; }
                public bool MicroSkirtDefault { get; set; }
                public bool MiniSkirtDefault { get; set; }
                public bool PantiesNormalDefault { get; set; }
                public bool PantsNormalDefault { get; set; }
                public bool PastiesNippleDefault { get; set; }
                public bool PelvicCurtainDefault { get; set; }
                public bool PiercingBellyDefault { get; set; }
                public bool PiercingClitDefault { get; set; }
                public bool PiercingNippleDefault { get; set; }
                public bool ThongCStringDefault { get; set; }
                public bool ThongGstringDefault { get; set; }
                public bool VaginalBeadsDefault { get; set; }
                public bool VaginalDildoDefault { get; set; }
                // Commented out for future use
                // public bool ArmorBondageDefault { get; set; }
                // public bool ArmorCapeMiniDefault { get; set; }
                // public bool EroticArmorDefault { get; set; }
                // public bool PastiesCrotchDefault { get; set; }
                // public bool PiercingLipsDefault { get; set; }
                // public bool PiercingNoseDefault { get; set; }
                // public bool PiercingVulvaDefault { get; set; }
                // public bool ShowgirlSkirtDefault { get; set; }
                // public bool ThongLowlegDefault { get; set; }
                // public bool ThongTDefault { get; set; }

        */
        //[SynthesisSettingName("Please choose which KeyWords you would like to include in the patch.")]
        [SynthesisTooltip("SLA_AnalPlug")]
        public bool AnalPlugDefault { get; set; } = true;
        [SynthesisTooltip("SLA_AnalPlugBeads")]
        public bool AnalBeadsDefault { get; set; } = true;
        [SynthesisTooltip("SLA_AnalPlugTail")]
        public bool AnalPlugTailDefault { get; set; } = true;
        [SynthesisTooltip("EroticArmor")]
        public bool ArmorEroticDefault { get; set; } = true;
        [SynthesisTooltip("SLA_ArmorCapeFull")]
        public bool ArmorCapeFullDefault { get; set; } = true;
        [SynthesisTooltip("SLA_ArmorCurtain")]
        public bool ArmorCurtainDefault { get; set; } = true;
        [SynthesisTooltip("SLA_ArmorFemaleOnly")]
        public bool ArmorFemaleOnlyDefault { get; set; } = true;
        [SynthesisTooltip("SLA_ArmorHalfNaked")]
        public bool ArmorHalfNakedDefault { get; set; } = true;
        [SynthesisTooltip("SLA_ArmorHalfNakedBikini")]
        public bool ArmorHalfNakedBikiniDefault { get; set; } = true;
        [SynthesisTooltip("SLA_ArmorHarness")]
        public bool ArmorHarnessDefault { get; set; } = true;
        [SynthesisTooltip("SLA_ArmorIllegal")]
        public bool ArmorIllegalDefault { get; set; } = true;
        [SynthesisTooltip("SLA_ArmorLewdLeotard")]
        public bool ArmorLewdLeotardDefault { get; set; } = true;
        [SynthesisTooltip("SLA_ArmorPartBottom")]
        public bool ArmorPartBottomDefault { get; set; } = true;
        [SynthesisTooltip("SLA_ArmorPartTop")]
        public bool ArmorPartTopDefault { get; set; } = true;
        [SynthesisTooltip("SLA_ArmorPretty")]
        public bool ArmorPrettyDefault { get; set; } = true;
        [SynthesisTooltip("SLA_ArmorRubber")]
        public bool ArmorRubberDefault { get; set; } = true;
        [SynthesisTooltip("SLA_ArmorSpandex")]
        public bool ArmorSpendexDefault { get; set; } = true;
        [SynthesisTooltip("SLA_ArmorTransparent")]
        public bool ArmorTransparentDefault { get; set; } = true;
        [SynthesisTooltip("SLA_BootsHeels")]
        public bool BootsHeelsDefault { get; set; } = true;
        [SynthesisTooltip("SLA_BraArmor")]
        public bool BraArmorDefault { get; set; } = true;
        [SynthesisTooltip("SLA_Earrings")]
        public bool EarringsDefault { get; set; } = true;
        [SynthesisTooltip("SLA_FullSkirt")]
        public bool FullSkirtDefault { get; set; } = true;
        [SynthesisTooltip("SLA_HasLeggings")]
        public bool HasLeggingsDefault { get; set; } = true;
        [SynthesisTooltip("SLA_HasSleeves")]
        public bool HasSleevesDefault { get; set; } = true;
        [SynthesisTooltip("SLA_HasStockings")]
        public bool HasStockingsDefault { get; set; } = true;
        [SynthesisTooltip("SLA_ImpossibleClothes")]
        public bool ImpossibleClothesDefault { get; set; } = true;
        [SynthesisTooltip("SLA_KillerHeels")]
        public bool KillerHeelsDefault { get; set; } = true;
        [SynthesisTooltip("SLA_MicroHotpants")]
        public bool MicroHotpantsDefault { get; set; } = true;
        [SynthesisTooltip("SLA_MicroSkirt")]
        public bool MicroSkirtDefault { get; set; } = true;
        [SynthesisTooltip("SLA_MiniSkirt")]
        public bool MiniSkirtDefault { get; set; } = true;
        [SynthesisTooltip("SLA_PantsNormal")]
        public bool PantsNormalDefault { get; set; } = true;
        [SynthesisTooltip("SLA_PantiesNormal")]
        public bool PantiesNormalDefault { get; set; } = true;
        [SynthesisTooltip("SLA_PastiesNipple")]
        public bool PastiesNippleDefault { get; set; } = true;
        [SynthesisTooltip("SLA_PelvicCurtain")]
        public bool PelvicCurtainDefault { get; set; } = true;
        [SynthesisTooltip("SLA_PiercingBelly")]
        public bool PiercingBellyDefault { get; set; } = true;
        [SynthesisTooltip("SLA_PiercingClit")]
        public bool PiercingClitDefault { get; set; } = true;
        [SynthesisTooltip("SLA_PiercingNipple")]
        public bool PiercingNippleDefault { get; set; } = true;
        [SynthesisTooltip("SLA_ThongCString")]
        public bool ThongCStringDefault { get; set; } = true;
        [SynthesisTooltip("SLA_ThongGstring")]
        public bool ThongGstringDefault { get; set; } = true;
        [SynthesisTooltip("SLA_VaginalBeads")]
        public bool VaginalBeadsDefault { get; set; } = true;
        [SynthesisTooltip("SLA_VaginalDildo")]
        public bool VaginalDildoDefault { get; set; } = true;



        // Commented out for future use
        //[SynthesisTooltip("SLA_ArmorBondage")]
        // public bool ArmorBondageDefault { get; set; } = true;
        //[SynthesisTooltip("SLA_ArmorCapeMini")]
        // public bool ArmorCapeMiniDefault { get; set; } = true;
        //[SynthesisTooltip("SLA_Brabikini")]
        // public bool BrabikiniDefault { get; set; } = true;
        //[SynthesisTooltip("EroticArmor")]
        // public bool EroticArmorDefault { get; set; } = true;
        //[SynthesisTooltip("EroticDresses")]
        //public bool EroticDresses { get; set; } = true;
        //[SynthesisTooltip("SLA_PantyNormal")]
        //public bool PantyNormalDefault { get; set; } = true;
        //[SynthesisTooltip("SLA_PastiesCrotch")]
        // public bool PastiesCrotchDefault { get; set; } = true;
        //[SynthesisTooltip("SLA_PiercingLips")]
        // public bool PiercingLipsDefault { get; set; } = true;
        //[SynthesisTooltip("SLA_PiercingNose")]
        // public bool PiercingNoseDefault { get; set; } = true;
        //[SynthesisTooltip("SLA_PiercingVulva")]
        // public bool PiercingVulvaDefault { get; set; } = true;
        //[SynthesisTooltip("SLA_ShowgirlSkirt")]
        // public bool ShowgirlSkirtDefault { get; set; } = true;
        //[SynthesisTooltip("SLA_ThongLowleg")]
        // public bool ThongLowlegDefault { get; set; } = true;
        //[SynthesisTooltip("SLA_ThongT")]
        // public bool ThongTDefault { get; set; } = true;
        }

    }


