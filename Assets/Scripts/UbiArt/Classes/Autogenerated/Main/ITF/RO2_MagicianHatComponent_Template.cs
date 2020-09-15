using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_MagicianHatComponent_Template : ActorComponent_Template {
		public StringID animStand;
		public StringID animBounce;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animStand = s.SerializeObject<StringID>(animStand, name: "animStand");
			animBounce = s.SerializeObject<StringID>(animBounce, name: "animBounce");
		}
		public override uint? ClassCRC => 0x3D13B4AC;
	}
}

