using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class VirtualLinkComponent : ActorComponent {
		public StringID channelID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			channelID = s.SerializeObject<StringID>(channelID, name: "channelID");
		}
		public override uint? ClassCRC => 0xA68DF4A2;
	}
}

