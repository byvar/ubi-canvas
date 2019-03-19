using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_90_sub_64AF30 : CSerializable {
		[Serialize("numPlayerPerPage"   )] public uint numPlayerPerPage;
		[Serialize("pageHeight"         )] public float pageHeight;
		[Serialize("playerActorPath"    )] public Path playerActorPath;
		[Serialize("flagIconPath"       )] public Path flagIconPath;
		[Serialize("costumeIconPath"    )] public Path costumeIconPath;
		[Serialize("playerActorPoolSize")] public uint playerActorPoolSize;
		[Serialize("playerActorOffset"  )] public Vector2 playerActorOffset;
		[Serialize("friendText"         )] public Placeholder friendText;
		[Serialize("friendsText"        )] public Placeholder friendsText;
		[Serialize("friends0Text"       )] public Placeholder friends0Text;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(numPlayerPerPage));
			SerializeField(s, nameof(pageHeight));
			SerializeField(s, nameof(playerActorPath));
			SerializeField(s, nameof(flagIconPath));
			SerializeField(s, nameof(costumeIconPath));
			SerializeField(s, nameof(playerActorPoolSize));
			SerializeField(s, nameof(playerActorOffset));
			SerializeField(s, nameof(friendText));
			SerializeField(s, nameof(friendsText));
			SerializeField(s, nameof(friends0Text));
		}
		public override uint? ClassCRC => 0xFC6594C4;
	}
}

