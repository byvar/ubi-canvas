using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class EventPushForce : Event {
		public Vec2d force;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			force = s.SerializeObject<Vec2d>(force, name: "force");
		}
		public override uint? ClassCRC => 0x182FB611;
	}
}

