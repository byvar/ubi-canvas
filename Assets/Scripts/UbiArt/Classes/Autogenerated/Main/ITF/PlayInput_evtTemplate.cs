using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class PlayInput_evtTemplate : SequenceEventWithActor_Template {
		public string InputName;
		public Spline InputSpline;
		public StringID ActionInput;
		public float InputCoeff;
		public string GaugingLowerLabel;
		public string GaugingUpperLabel;
		public float GaugingLowerValue;
		public float GaugingUpperValue;
		public ColorEventList Colors;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL || Settings.s.game == Settings.Game.VH) {
				InputName = s.Serialize<string>(InputName, name: "InputName");
				InputSpline = s.SerializeObject<Spline>(InputSpline, name: "InputSpline");
			} else {
				InputName = s.Serialize<string>(InputName, name: "InputName");
				InputSpline = s.SerializeObject<Spline>(InputSpline, name: "InputSpline");
				ActionInput = s.SerializeObject<StringID>(ActionInput, name: "ActionInput");
				InputCoeff = s.Serialize<float>(InputCoeff, name: "InputCoeff");
				GaugingLowerLabel = s.Serialize<string>(GaugingLowerLabel, name: "GaugingLowerLabel");
				GaugingUpperLabel = s.Serialize<string>(GaugingUpperLabel, name: "GaugingUpperLabel");
				GaugingLowerValue = s.Serialize<float>(GaugingLowerValue, name: "GaugingLowerValue");
				GaugingUpperValue = s.Serialize<float>(GaugingUpperValue, name: "GaugingUpperValue");
				Colors = s.SerializeObject<ColorEventList>(Colors, name: "Colors");
			}
		}
		public override uint? ClassCRC => 0x66BDC40F;
	}
}

