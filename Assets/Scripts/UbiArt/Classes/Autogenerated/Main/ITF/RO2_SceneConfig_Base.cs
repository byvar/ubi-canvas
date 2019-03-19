using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_SceneConfig_Base : SceneConfig {
		[Serialize("DRCGameplayMode"  )] public Enum_DRCGameplayMode DRCGameplayMode;
		[Serialize("fade"             )] public StringID fade;
		[Serialize("packageDescriptor")] public RO2_PackageDescriptor_Template packageDescriptor;
		[Serialize("istouchScreenMap" )] public bool istouchScreenMap;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(DRCGameplayMode));
			SerializeField(s, nameof(fade));
			SerializeField(s, nameof(packageDescriptor));
			SerializeField(s, nameof(istouchScreenMap));
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

