using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH | GameFlags.RO)]
	public partial class TODOComponent : ActorComponent {
		[Serialize("TextLabel"      )] public CString TextLabel;
		[Serialize("drawUsingEngine")] public int drawUsingEngine;
		[Serialize("drawBoxWidth"   )] public float drawBoxWidth;
		[Serialize("drawBoxHeight"  )] public float drawBoxHeight;
		[Serialize("textSize"       )] public float textSize;
		[Serialize("textAlpha"      )] public float textAlpha;
		[Serialize("textRed"        )] public float textRed;
		[Serialize("textGreen"      )] public float textGreen;
		[Serialize("textBlue"       )] public float textBlue;
		[Serialize("backgroundAlpha")] public float backgroundAlpha;
		[Serialize("backgroundRed"  )] public float backgroundRed;
		[Serialize("backgroundGreen")] public float backgroundGreen;
		[Serialize("backgroundBlue" )] public float backgroundBlue;
		[Serialize("centerText"     )] public int centerText;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(TextLabel));
					SerializeField(s, nameof(drawUsingEngine));
					SerializeField(s, nameof(drawBoxWidth));
					SerializeField(s, nameof(drawBoxHeight));
					SerializeField(s, nameof(textSize));
					SerializeField(s, nameof(textAlpha));
					SerializeField(s, nameof(textRed));
					SerializeField(s, nameof(textGreen));
					SerializeField(s, nameof(textBlue));
					SerializeField(s, nameof(backgroundAlpha));
					SerializeField(s, nameof(backgroundRed));
					SerializeField(s, nameof(backgroundGreen));
					SerializeField(s, nameof(backgroundBlue));
					SerializeField(s, nameof(centerText));
				}
			} else {
			}
		}
		public override uint? ClassCRC => 0x1010A8F1;
	}
}

