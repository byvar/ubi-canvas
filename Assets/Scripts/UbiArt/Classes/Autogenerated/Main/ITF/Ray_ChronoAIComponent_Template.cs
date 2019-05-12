using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_ChronoAIComponent_Template : ActorComponent_Template {
		[Serialize("bubbleBone"       )] public StringID bubbleBone;
		[Serialize("bubblePath"       )] public Path bubblePath;
		[Serialize("cupPath"          )] public Path cupPath;
		[Serialize("electoonPath"     )] public Path electoonPath;
		[Serialize("textColor"        )] public Color textColor;
		[Serialize("fontInitialHeight")] public float fontInitialHeight;
		[Serialize("moveDuration"     )] public float moveDuration;
		[Serialize("moveCurve"        )] public float moveCurve;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(bubbleBone));
			SerializeField(s, nameof(bubblePath));
			SerializeField(s, nameof(cupPath));
			SerializeField(s, nameof(electoonPath));
			SerializeField(s, nameof(textColor));
			SerializeField(s, nameof(fontInitialHeight));
			SerializeField(s, nameof(moveDuration));
			SerializeField(s, nameof(moveCurve));
		}
		public override uint? ClassCRC => 0xA309F872;
	}
}

