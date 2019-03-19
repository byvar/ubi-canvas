using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_145_sub_73FEB0 : CSerializable {
		[Serialize("challengeExpertColor")] public Color challengeExpertColor;
		[Serialize("challengeSwitchDelay")] public float challengeSwitchDelay;
		[Serialize("challengeSwitchSpeed")] public float challengeSwitchSpeed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(challengeExpertColor));
			SerializeField(s, nameof(challengeSwitchDelay));
			SerializeField(s, nameof(challengeSwitchSpeed));
		}
		public override uint? ClassCRC => 0xE80EF191;
	}
}

