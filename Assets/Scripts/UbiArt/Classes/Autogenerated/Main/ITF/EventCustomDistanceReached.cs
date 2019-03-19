using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class EventCustomDistanceReached : Event {
		[Serialize("customDistance")] public float customDistance;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(customDistance));
		}
		public override uint? ClassCRC => 0x6E311B27;
	}
}

