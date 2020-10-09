using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_PrisonerPostComponent_Template : RO2_AIComponent_Template {
		public StringID animIdle;
		public StringID animExplodeLeft;
		public StringID animExplodeRight;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animIdle = s.SerializeObject<StringID>(animIdle, name: "animIdle");
			animExplodeLeft = s.SerializeObject<StringID>(animExplodeLeft, name: "animExplodeLeft");
			animExplodeRight = s.SerializeObject<StringID>(animExplodeRight, name: "animExplodeRight");
		}
		public override uint? ClassCRC => 0x0A0000CA;
	}
}

