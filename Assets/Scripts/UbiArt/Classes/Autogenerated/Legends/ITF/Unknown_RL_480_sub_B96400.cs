using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_480_sub_B96400 : BTAction_Template {
		[Serialize("anim"       )] public StringID anim;
		[Serialize("basicBullet")] public RO2_BasicBullet_Template basicBullet;
		[Serialize("posOffset"  )] public Vector2 posOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(anim));
			SerializeField(s, nameof(basicBullet));
			SerializeField(s, nameof(posOffset));
		}
		public override uint? ClassCRC => 0x3863E02D;
	}
}

