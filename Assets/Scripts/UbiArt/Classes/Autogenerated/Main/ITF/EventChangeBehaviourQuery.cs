using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class EventChangeBehaviourQuery : Event {
		public StringID wantedBehaviourName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			wantedBehaviourName = s.SerializeObject<StringID>(wantedBehaviourName, name: "wantedBehaviourName");
		}
		public override uint? ClassCRC => 0x42CD8BE8;
	}
}

