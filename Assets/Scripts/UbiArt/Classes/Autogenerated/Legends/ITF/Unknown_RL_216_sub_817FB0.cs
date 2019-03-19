using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_216_sub_817FB0 : CSerializable {
		[Serialize("playerOnlineID")] public uint playerOnlineID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(playerOnlineID));
		}
		public override uint? ClassCRC => 0x8B16092A;
	}
}

