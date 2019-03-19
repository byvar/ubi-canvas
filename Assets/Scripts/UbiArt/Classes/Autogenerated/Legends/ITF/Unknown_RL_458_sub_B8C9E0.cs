using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_458_sub_B8C9E0 : CSerializable {
		[Serialize("basicBullet")] public Placeholder basicBullet;
		[Serialize("posOffset"  )] public Vector2 posOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(basicBullet));
			SerializeField(s, nameof(posOffset));
		}
		public override uint? ClassCRC => 0x2B5B95B0;
	}
}

