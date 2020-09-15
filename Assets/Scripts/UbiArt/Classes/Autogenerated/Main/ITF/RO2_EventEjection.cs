using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_EventEjection : Event {
		[Serialize("speed"     )] public Vec2d speed;
		[Serialize("immuneDrag")] public bool immuneDrag;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(speed));
			SerializeField(s, nameof(immuneDrag));
		}
		public override uint? ClassCRC => 0x0C37395B;
	}
}

