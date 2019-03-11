using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_397_sub_B3F8D0 : CSerializable {
		[Serialize("leaderboardTutoText")] public Placeholder leaderboardTutoText;
		[Serialize("animOffset"         )] public Vector2 animOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(leaderboardTutoText));
			SerializeField(s, nameof(animOffset));
		}
		public override uint? ClassCRC => 0xEE4A97EA;
	}
}

