using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_ChronoAIComponent_Template : ActorComponent_Template {
		public EventInstructionDialog dialogIntruction;
		public StringID bubbleBone;
		public Path bubblePath;
		public Path cupPath;
		public Path electoonPath;
		public Color textColor;
		public float fontInitialHeight;
		public float moveDuration;
		public float moveCurve;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			dialogIntruction = s.SerializeObject<EventInstructionDialog>(dialogIntruction, name: "dialogIntruction");
			bubbleBone = s.SerializeObject<StringID>(bubbleBone, name: "bubbleBone");
			bubblePath = s.SerializeObject<Path>(bubblePath, name: "bubblePath");
			cupPath = s.SerializeObject<Path>(cupPath, name: "cupPath");
			electoonPath = s.SerializeObject<Path>(electoonPath, name: "electoonPath");
			textColor = s.SerializeObject<Color>(textColor, name: "textColor");
			fontInitialHeight = s.Serialize<float>(fontInitialHeight, name: "fontInitialHeight");
			moveDuration = s.Serialize<float>(moveDuration, name: "moveDuration");
			moveCurve = s.Serialize<float>(moveCurve, name: "moveCurve");
		}
		public override uint? ClassCRC => 0xDDA22C17;
	}
}

