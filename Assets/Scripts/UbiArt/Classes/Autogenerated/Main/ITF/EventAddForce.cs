using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.VH | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class EventAddForce : Event {
		[Serialize("force" )] public Vec2d force;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(force));
		}
		public override uint? ClassCRC => 0x67329674;
	}
}

