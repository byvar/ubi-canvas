using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_SkipLevelComponent : CSerializable {
		[Serialize("RELATIVEPOS")] public Vector2 RELATIVEPOS;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(RELATIVEPOS));
			}
		}
		public override uint? ClassCRC => 0x6E1B4C24;
	}
}

