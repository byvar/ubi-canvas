using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_LoadNotificationComponent : ActorComponent {
		[Serialize("RELATIVEPOS")] public Vector2 RELATIVEPOS;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(RELATIVEPOS));
			}
		}
		public override uint? ClassCRC => 0x53B7C065;
	}
}

