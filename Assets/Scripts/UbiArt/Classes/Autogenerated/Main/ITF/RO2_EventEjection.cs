using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_EventEjection : Event {
		[Serialize("speed"     )] public Vector2 speed;
		[Serialize("immuneDrag")] public bool immuneDrag;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(speed));
			SerializeField(s, nameof(immuneDrag));
		}
		public override uint? ClassCRC => 0x0C37395B;
	}
}

