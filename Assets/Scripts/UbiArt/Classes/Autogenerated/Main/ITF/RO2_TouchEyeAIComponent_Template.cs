using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_TouchEyeAIComponent_Template : ActorComponent_Template {
		public StringID animIdle;
		public StringID animTouched;
		public StringID animStunned;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animIdle = s.SerializeObject<StringID>(animIdle, name: "animIdle");
			animTouched = s.SerializeObject<StringID>(animTouched, name: "animTouched");
			animStunned = s.SerializeObject<StringID>(animStunned, name: "animStunned");
		}
		public override uint? ClassCRC => 0x1539E8F0;
	}
}

