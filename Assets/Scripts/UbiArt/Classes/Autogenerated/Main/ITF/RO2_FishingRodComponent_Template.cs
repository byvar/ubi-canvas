using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_FishingRodComponent_Template : ActorComponent_Template {
		public StringID animExplode;
		public StringID animDropped;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animExplode = s.SerializeObject<StringID>(animExplode, name: "animExplode");
			animDropped = s.SerializeObject<StringID>(animDropped, name: "animDropped");
		}
		public override uint? ClassCRC => 0x5B4A4888;
	}
}

