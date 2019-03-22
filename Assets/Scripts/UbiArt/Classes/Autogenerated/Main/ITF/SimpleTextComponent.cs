using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH | GameFlags.RO)]
	public partial class SimpleTextComponent : ActorComponent {
		[Serialize("TextLabel"      )] public string TextLabel;
		[Serialize("lineId"         )] public LocalisationId lineId;
		[Serialize("drawUsingEngine")] public bool drawUsingEngine;
		[Serialize("drawBoxWidth"   )] public float drawBoxWidth;
		[Serialize("drawBoxHeight"  )] public float drawBoxHeight;
		[Serialize("textSize"       )] public float textSize;
		[Serialize("textColor"      )] public Color textColor;
		[Serialize("backgroundColor")] public Color backgroundColor;
		[Serialize("centerText"     )] public bool centerText;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(TextLabel), type: typeof(CString));
					SerializeField(s, nameof(lineId));
					SerializeField(s, nameof(drawUsingEngine));
					SerializeField(s, nameof(drawBoxWidth));
					SerializeField(s, nameof(drawBoxHeight));
					SerializeField(s, nameof(textSize));
					SerializeField(s, nameof(textColor));
					SerializeField(s, nameof(backgroundColor));
					SerializeField(s, nameof(centerText));
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(TextLabel));
					SerializeField(s, nameof(lineId));
					SerializeField(s, nameof(drawUsingEngine));
					SerializeField(s, nameof(drawBoxWidth));
					SerializeField(s, nameof(drawBoxHeight));
					SerializeField(s, nameof(textSize));
					SerializeField(s, nameof(textColor));
					SerializeField(s, nameof(backgroundColor));
					SerializeField(s, nameof(centerText));
				}
			}
		}
		public override uint? ClassCRC => 0x8162686D;
	}
}

