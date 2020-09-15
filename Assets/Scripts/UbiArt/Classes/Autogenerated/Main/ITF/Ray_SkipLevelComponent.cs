using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_SkipLevelComponent : ActorComponent {
		[Serialize("RELATIVEPOS")] public Vec2d RELATIVEPOS;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(RELATIVEPOS));
			}
		}
		public override uint? ClassCRC => 0x6E1B4C24;
	}
}

