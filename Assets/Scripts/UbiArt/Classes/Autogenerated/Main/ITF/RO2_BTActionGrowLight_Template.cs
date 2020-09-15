using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTActionGrowLight_Template : BTAction_Template {
		public StringID animGrowLight;
		public float growLightDuration;
		public bool useGrowLightTimer;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animGrowLight = s.SerializeObject<StringID>(animGrowLight, name: "animGrowLight");
			growLightDuration = s.Serialize<float>(growLightDuration, name: "growLightDuration");
			useGrowLightTimer = s.Serialize<bool>(useGrowLightTimer, name: "useGrowLightTimer");
		}
		public override uint? ClassCRC => 0x8D78F8D1;
	}
}

