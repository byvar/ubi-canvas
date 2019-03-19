using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_303_sub_A04610 : CSerializable {
		[Serialize("defaultSpeed"  )] public Vector2 defaultSpeed;
		[Serialize("defaultZOffset")] public float defaultZOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(defaultSpeed));
			SerializeField(s, nameof(defaultZOffset));
		}
		public override uint? ClassCRC => 0x5ACC2440;
	}
}

