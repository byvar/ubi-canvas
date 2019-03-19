using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_ProjectileComponent_Template : CSerializable {
		[Serialize("speed")] public float speed;
		[Serialize("delay")] public float delay;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(speed));
			SerializeField(s, nameof(delay));
		}
		public override uint? ClassCRC => 0x2E8A2705;
	}
}

