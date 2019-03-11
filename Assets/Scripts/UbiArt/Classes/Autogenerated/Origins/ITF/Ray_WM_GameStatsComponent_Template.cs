using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_WM_GameStatsComponent_Template : CSerializable {
		[Serialize("scoreTextActor")] public Path scoreTextActor;
		[Serialize("fontHeight"    )] public float fontHeight;
		[Serialize("textColor"     )] public Color textColor;
		[Serialize("scoreOffsets2D")] public Placeholder scoreOffsets2D;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(scoreTextActor));
			SerializeField(s, nameof(fontHeight));
			SerializeField(s, nameof(textColor));
			SerializeField(s, nameof(scoreOffsets2D));
		}
		public override uint? ClassCRC => 0x921DF538;
	}
}

