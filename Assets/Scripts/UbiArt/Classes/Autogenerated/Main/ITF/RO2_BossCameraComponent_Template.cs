using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BossCameraComponent_Template : BaseCameraComponent_Template {
		public StringID attachBone;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			attachBone = s.SerializeObject<StringID>(attachBone, name: "attachBone");
		}
		public override uint? ClassCRC => 0x9FE95EE7;
	}
}

