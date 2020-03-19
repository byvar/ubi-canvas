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
		[Serialize("mod"         )] public bool mod;
		[Serialize("abs"         )] public bool abs;
		[Serialize("add"         )] public bool add;
		[Serialize("sin"         )] public bool sin;
		// The mod, abs, add and sin values are based on one flag. Before serializing, the game code splits them
		// In Adventures, the values are bitshifted so they are always 0 or 1
		// In Legends, the values are not bitshifted, so they are 0 or 1, 2, 4, or 8.
		[Serialize("mod"         )] public int modFlag; // 0 or 1
		[Serialize("abs"         )] public int absFlag; // 0 or 2
		[Serialize("add"         )] public int addFlag; // 0 or 4
		[Serialize("sin"         )] public int sinFlag; // 0 or 8
		[Serialize("curve"       )] public Spline curve;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(input));
				SerializeField(s, nameof(min));
				SerializeField(s, nameof(max));
				SerializeField(s, nameof(minValue));
				SerializeField(s, nameof(maxValue));
				SerializeField(s, nameof(modFlag));
				SerializeField(s, nameof(absFlag));
				SerializeField(s, nameof(addFlag));
			} else if (Settings.s.game == Settings.Game.VH || Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(input));
				SerializeField(s, nameof(min));
				SerializeField(s, nameof(max));
				SerializeField(s, nameof(minValue));
				SerializeField(s, nameof(maxValue));
				SerializeField(s, nameof(modFlag));
				SerializeField(s, nameof(absFlag));
				SerializeField(s, nameof(addFlag));
				SerializeField(s, nameof(sinFlag));
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

