using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_464_sub_B90900 : CSerializable {
		[Serialize("bulletExitBone")] public StringID bulletExitBone;
		[Serialize("useBonesEnd"   )] public int useBonesEnd;
		[Serialize("bullet"        )] public Path bullet;
		[Serialize("offset"        )] public float offset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(bulletExitBone));
			SerializeField(s, nameof(useBonesEnd));
			SerializeField(s, nameof(bullet));
			SerializeField(s, nameof(offset));
		}
		public override uint? ClassCRC => 0x507D7FA2;
	}
}

