using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class EventChangeBehaviourQuery : Event {
		[Serialize("wantedBehaviourName")] public StringID wantedBehaviourName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(wantedBehaviourName));
		}
		public override uint? ClassCRC => 0x42CD8BE8;
	}
}

