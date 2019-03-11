using UnityEngine;

namespace UbiArt.online {
	public partial class LinkCode : CSerializable {
		[Serialize("slot"     )] public uint slot;
		[Serialize("profileId")] public string profileId;
		[Serialize("code"     )] public string code;
		[Serialize("ttl"      )] public uint ttl;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(slot));
			SerializeField(s, nameof(profileId));
			SerializeField(s, nameof(code));
			SerializeField(s, nameof(ttl));
		}
		public override uint? ClassCRC => 0x1038C063;
	}
}

