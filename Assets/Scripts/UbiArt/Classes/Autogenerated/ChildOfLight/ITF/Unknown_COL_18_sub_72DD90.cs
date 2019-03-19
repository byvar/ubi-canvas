using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class Unknown_COL_18_sub_72DD90 : CSerializable {
		[Serialize("enabled"         )] public int enabled;
		[Serialize("capsuleJumpLimit")] public float capsuleJumpLimit;
		[Serialize("minFluidDepth"   )] public float minFluidDepth;
		[Serialize("instance0"       )] public Placeholder instance0;
		[Serialize("instance1"       )] public Placeholder instance1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(enabled));
			SerializeField(s, nameof(capsuleJumpLimit));
			SerializeField(s, nameof(minFluidDepth));
			SerializeField(s, nameof(instance0));
			SerializeField(s, nameof(instance1));
		}
		public override uint? ClassCRC => 0xFC4FF4C5;
	}
}

