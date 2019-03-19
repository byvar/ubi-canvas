using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_WMContentUnlockComponent : CSerializable {
		[Serialize("RELATIVEPOS")] public Vector2 RELATIVEPOS;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(RELATIVEPOS));
			}
		}
		public override uint? ClassCRC => 0x2701D106;
	}
}

