using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_WM_BonusLevelSpotComponent : Ray_WM_LevelSpotComponent {
		[Serialize("bubbleOffset" )] public Vector2 bubbleOffset;
		[Serialize("bubbleZOffset")] public float bubbleZOffset;
		[Serialize("blockedLines" )] public Placeholder blockedLines;
		[Serialize("openLines"    )] public Placeholder openLines;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(bubbleOffset));
			SerializeField(s, nameof(bubbleZOffset));
			SerializeField(s, nameof(blockedLines));
			SerializeField(s, nameof(openLines));
		}
		public override uint? ClassCRC => 0xEE1270D6;
	}
}

