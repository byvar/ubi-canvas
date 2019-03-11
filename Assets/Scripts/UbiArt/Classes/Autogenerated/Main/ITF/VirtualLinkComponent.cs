using UnityEngine;

namespace UbiArt.ITF {
	public partial class VirtualLinkComponent : ActorComponent {
		[Serialize("channelID")] public StringID channelID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(channelID));
		}
		public override uint? ClassCRC => 0xA68DF4A2;
	}
}

