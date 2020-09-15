using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_FeedbackTextBox_Template : CSerializable {
		[Serialize("spawnPosOffset" )] public Vec2d spawnPosOffset;
		[Serialize("timeBeforeShown")] public float timeBeforeShown;
		[Serialize("displayTime"    )] public float displayTime;
		[Serialize("fadeTime"       )] public float fadeTime;
		[Serialize("travelDistance" )] public float travelDistance;
		[Serialize("scaleMultiplier")] public float scaleMultiplier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(spawnPosOffset));
			SerializeField(s, nameof(timeBeforeShown));
			SerializeField(s, nameof(displayTime));
			SerializeField(s, nameof(fadeTime));
			SerializeField(s, nameof(travelDistance));
			SerializeField(s, nameof(scaleMultiplier));
		}
		public override uint? ClassCRC => 0x3E7D5E55;
	}
}

