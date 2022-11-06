using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class EventChangeBehaviourQuery : Event {
		public StringID wantedBehaviourName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			wantedBehaviourName = s.SerializeObject<StringID>(wantedBehaviourName, name: "wantedBehaviourName");
		}
		public override uint? ClassCRC => 0x42CD8BE8;
	}
}

