using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_197_sub_786C50 : CSerializable {
		[Serialize("reward")] public Placeholder reward;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(reward));
		}
		public override uint? ClassCRC => 0x4F73A6C1;
	}
}

