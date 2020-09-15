using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class AnimMarkerEvent : Event {
		[Serialize("name"    )] public StringID name;
		[Serialize("posLocal")] public Vec2d posLocal;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(name));
			SerializeField(s, nameof(posLocal));
		}
		public override uint? ClassCRC => 0x2CF531DD;
	}
}

