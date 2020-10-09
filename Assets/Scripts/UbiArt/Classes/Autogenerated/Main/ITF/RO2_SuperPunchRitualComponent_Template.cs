using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_SuperPunchRitualComponent_Template : ActorComponent_Template {
		public StringID powerUpId;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			powerUpId = s.SerializeObject<StringID>(powerUpId, name: "powerUpId");
		}
		public override uint? ClassCRC => 0x46B4D8E3;
	}
}

