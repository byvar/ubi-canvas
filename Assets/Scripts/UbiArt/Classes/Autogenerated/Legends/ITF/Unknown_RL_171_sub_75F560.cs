using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_171_sub_75F560 : CSerializable {
		[Serialize("fallSpeed")] public float fallSpeed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(fallSpeed));
		}
		public override uint? ClassCRC => 0x949CF179;
	}
}

