using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_117_sub_6A9150 : CSerializable {
		[Serialize("active"     )] public int active;
		[Serialize("offset"     )] public Vec3d offset;
		[Serialize("applyAlways")] public int applyAlways;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(active));
			SerializeField(s, nameof(offset));
			SerializeField(s, nameof(applyAlways));
		}
		public override uint? ClassCRC => 0xA8C26DDA;
	}
}

