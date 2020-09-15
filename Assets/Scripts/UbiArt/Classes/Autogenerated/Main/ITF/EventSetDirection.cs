using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class EventSetDirection : Event {
		[Serialize("direction")] public Vec2d direction;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(direction));
		}
		public override uint? ClassCRC => 0x0B2DF3EA;
	}
}

