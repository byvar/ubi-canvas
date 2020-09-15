using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_SceneConfig_Base : SceneConfig {
		public Enum_DRCGameplayMode DRCGameplayMode;
		public StringID fade;
		public RO2_PackageDescriptor_Template packageDescriptor;
		public bool istouchScreenMap;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			DRCGameplayMode = s.Serialize<Enum_DRCGameplayMode>(DRCGameplayMode, name: "DRCGameplayMode");
			fade = s.SerializeObject<StringID>(fade, name: "fade");
			packageDescriptor = s.SerializeObject<RO2_PackageDescriptor_Template>(packageDescriptor, name: "packageDescriptor");
			istouchScreenMap = s.Serialize<bool>(istouchScreenMap, name: "istouchScreenMap");
		}
		public enum Enum_DRCGameplayMode {
			[Serialize("Normal"        )] Normal = 0,
			[Serialize("Exclusive"     )] Exclusive = 1,
			[Serialize("Coop"          )] Coop = 2,
			[Serialize("AutoPlayerOnly")] AutoPlayerOnly = 3,
			[Serialize("Disabled"      )] Disabled = 4,
		}
		public override uint? ClassCRC => 0x930322B9;
	}
}

