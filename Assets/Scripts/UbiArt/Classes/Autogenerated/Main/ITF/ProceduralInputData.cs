using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class ProceduralInputData : CSerializable {
		[Serialize("input"       )] public StringID input;
		[Serialize("min"         )] public float min;
		[Serialize("max"         )] public float max;
		[Serialize("initialValue")] public float initialValue;
		[Serialize("minValue"    )] public float minValue;
		[Serialize("maxValue"    )] public float maxValue;
		[Serialize("mod"         )] public int mod;
		[Serialize("abs"         )] public int abs;
		[Serialize("add"         )] public int add;
		[Serialize("sin"         )] public int sin;
		[Serialize("curve"       )] public Spline curve;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(input));
				SerializeField(s, nameof(min));
				SerializeField(s, nameof(max));
				SerializeField(s, nameof(minValue));
				SerializeField(s, nameof(maxValue));
				SerializeField(s, nameof(mod));
				SerializeField(s, nameof(abs));
				SerializeField(s, nameof(add));
			} else if (Settings.s.game == Settings.Game.VH || Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(input));
				SerializeField(s, nameof(min));
				SerializeField(s, nameof(max));
				SerializeField(s, nameof(minValue));
				SerializeField(s, nameof(maxValue));
				SerializeField(s, nameof(mod));
				SerializeField(s, nameof(abs));
				SerializeField(s, nameof(add));
				SerializeField(s, nameof(sin));
				SerializeField(s, nameof(curve));
			} else {
				SerializeField(s, nameof(input));
				SerializeField(s, nameof(min));
				SerializeField(s, nameof(max));
				SerializeField(s, nameof(initialValue));
				SerializeField(s, nameof(minValue));
				SerializeField(s, nameof(maxValue));
				SerializeField(s, nameof(mod));
				SerializeField(s, nameof(abs));
				SerializeField(s, nameof(add));
				SerializeField(s, nameof(sin));
				SerializeField(s, nameof(curve));
			}
		}
	}
}

