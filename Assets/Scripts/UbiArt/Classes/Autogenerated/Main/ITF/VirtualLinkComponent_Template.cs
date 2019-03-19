using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class VirtualLinkComponent_Template : ActorComponent_Template {
		[Serialize("channelID"         )] public StringID channelID;
		[Serialize("emitter"           )] public bool emitter;
		[Serialize("receiver"          )] public bool receiver;
		[Serialize("broadcastEventList")] public CList<Event> broadcastEventList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(channelID));
			SerializeField(s, nameof(emitter));
			SerializeField(s, nameof(receiver));
			SerializeField(s, nameof(broadcastEventList));
		}
		public override uint? ClassCRC => 0xF5BE9917;
	}
}

