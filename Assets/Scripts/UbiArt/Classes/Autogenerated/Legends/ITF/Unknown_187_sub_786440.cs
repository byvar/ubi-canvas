using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_187_sub_786440 : CSerializable {
		[Serialize("shape"                )] public Placeholder shape;
		[Serialize("detectDangerousGround")] public Placeholder detectDangerousGround;
		[Serialize("detectDangerousGround")] public bool detectDangerousGround;
		[Serialize("broken"               )] public bool broken;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(shape));
				SerializeField(s, nameof(detectDangerousGround));
				SerializeField(s, nameof(detectDangerousGround));
			}
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(broken));
			}
		}
		public override uint? ClassCRC => 0x0A7203EA;
	}
}

