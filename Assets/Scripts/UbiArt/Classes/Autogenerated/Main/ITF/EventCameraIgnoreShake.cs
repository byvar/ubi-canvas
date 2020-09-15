using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.VH | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class EventCameraIgnoreShake : Event {
		public bool ignoreShake;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			ignoreShake = s.Serialize<bool>(ignoreShake, name: "ignoreShake");
		}
		public override uint? ClassCRC => 0x6D2CA7CB;
	}
}

