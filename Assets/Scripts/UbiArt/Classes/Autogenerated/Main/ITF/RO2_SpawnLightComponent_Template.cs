using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_SpawnLightComponent_Template : ActorComponent_Template {
		public Path LightPath;
		public Path backLightPath;
		public float lightOffset;
		public float backLightOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			LightPath = s.SerializeObject<Path>(LightPath, name: "LightPath");
			backLightPath = s.SerializeObject<Path>(backLightPath, name: "backLightPath");
			lightOffset = s.Serialize<float>(lightOffset, name: "lightOffset");
			backLightOffset = s.Serialize<float>(backLightOffset, name: "backLightOffset");
		}
		public override uint? ClassCRC => 0x058F5AAD;
	}
}

