using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class EventPushForce : Event {
		[Serialize("force")] public Vec2d force;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(force));
		}
		public override uint? ClassCRC => 0x182FB611;
	}
}

