using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class EventCustomDistanceReached : Event {
		public float customDistance;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			customDistance = s.Serialize<float>(customDistance, name: "customDistance");
		}
		public override uint? ClassCRC => 0x6E311B27;
	}
}

