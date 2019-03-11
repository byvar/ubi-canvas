using UnityEngine;

namespace UbiArt.ITF {
	public partial class PlayInput_evtTemplate : SequenceEventWithActor_Template {
		[Serialize("InputName"        )] public string InputName;
		[Serialize("InputSpline"      )] public Spline InputSpline;
		[Serialize("ActionInput"      )] public StringID ActionInput;
		[Serialize("InputCoeff"       )] public float InputCoeff;
		[Serialize("GaugingLowerLabel")] public string GaugingLowerLabel;
		[Serialize("GaugingUpperLabel")] public string GaugingUpperLabel;
		[Serialize("GaugingLowerValue")] public float GaugingLowerValue;
		[Serialize("GaugingUpperValue")] public float GaugingUpperValue;
		[Serialize("Colors"           )] public ColorEventList Colors;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(InputName));
				SerializeField(s, nameof(InputSpline));
			} else {
				SerializeField(s, nameof(InputName));
				SerializeField(s, nameof(InputSpline));
				SerializeField(s, nameof(ActionInput));
				SerializeField(s, nameof(InputCoeff));
				SerializeField(s, nameof(GaugingLowerLabel));
				SerializeField(s, nameof(GaugingUpperLabel));
				SerializeField(s, nameof(GaugingLowerValue));
				SerializeField(s, nameof(GaugingUpperValue));
				SerializeField(s, nameof(Colors));
			}
		}
		public override uint? ClassCRC => 0x66BDC40F;
	}
}

