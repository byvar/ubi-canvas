using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_SuperPunchRitualComponent_Template : ActorComponent_Template {
		[Serialize("powerUpId")] public StringID powerUpId;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(powerUpId));
		}
		public override uint? ClassCRC => 0x46B4D8E3;
	}
}

