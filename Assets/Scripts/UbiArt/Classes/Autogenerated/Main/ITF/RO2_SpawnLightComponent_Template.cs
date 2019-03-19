using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_SpawnLightComponent_Template : ActorComponent_Template {
		[Serialize("LightPath"      )] public Path LightPath;
		[Serialize("backLightPath"  )] public Path backLightPath;
		[Serialize("lightOffset"    )] public float lightOffset;
		[Serialize("backLightOffset")] public float backLightOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(LightPath));
			SerializeField(s, nameof(backLightPath));
			SerializeField(s, nameof(lightOffset));
			SerializeField(s, nameof(backLightOffset));
		}
		public override uint? ClassCRC => 0x058F5AAD;
	}
}

