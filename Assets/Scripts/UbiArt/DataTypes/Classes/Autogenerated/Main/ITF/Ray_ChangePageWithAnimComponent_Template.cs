using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_ChangePageWithAnimComponent_Template : CSerializable {
		public StringID animPlayer;
		public StringID aspireAnim;
		public StringID aspirePoint;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animPlayer = s.SerializeObject<StringID>(animPlayer, name: "animPlayer");
			aspireAnim = s.SerializeObject<StringID>(aspireAnim, name: "aspireAnim");
			aspirePoint = s.SerializeObject<StringID>(aspirePoint, name: "aspirePoint");
		}
		public override uint? ClassCRC => 0x86E7DE33;
	}
}

