namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class ProceduralInputData : CSerializable {
		public StringID input;
		public float min;
		public float max = 1f;
		public float initialValue;
		public float minValue;
		public float maxValue = 1f;
		public bool mod;
		public bool abs;
		public bool add;
		public bool sin;
		// The mod, abs, add and sin values are based on one flag. Before serializing, the game code splits them
		// In Adventures, the values are bitshifted so they are always 0 or 1
		// In Legends, the values are not bitshifted, so they are 0 or 1, 2, 4, or 8.
		public int modFlag { get => mod ? 1 : 0; set => mod = value == 1; } // 0 or 1
		public int absFlag { get => abs ? 2 : 0; set => abs = value == 2; } // 0 or 2
		public int addFlag { get => add ? 4 : 0; set => add = value == 4; } // 0 or 4
		public int sinFlag { get => sin ? 8 : 0; set => sin = value == 8; } // 0 or 8
		public Spline curve;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RJR || s.Settings.Game == Game.RFR || s.Settings.Game == Game.RO) {
				input = s.SerializeObject<StringID>(input, name: "input");
				min = s.Serialize<float>(min, name: "min");
				max = s.Serialize<float>(max, name: "max");
				minValue = s.Serialize<float>(minValue, name: "minValue");
				maxValue = s.Serialize<float>(maxValue, name: "maxValue");
				modFlag = s.Serialize<int>(modFlag, name: "mod");
				absFlag = s.Serialize<int>(absFlag, name: "abs");
				addFlag = s.Serialize<int>(addFlag, name: "add");
			} else if (s.Settings.Game == Game.VH || s.Settings.Game == Game.RL || s.Settings.Game == Game.COL) {
				input = s.SerializeObject<StringID>(input, name: "input");
				min = s.Serialize<float>(min, name: "min");
				max = s.Serialize<float>(max, name: "max");
				minValue = s.Serialize<float>(minValue, name: "minValue");
				maxValue = s.Serialize<float>(maxValue, name: "maxValue");
				modFlag = s.Serialize<int>(modFlag, name: "mod");
				absFlag = s.Serialize<int>(absFlag, name: "abs");
				addFlag = s.Serialize<int>(addFlag, name: "add");
				sinFlag = s.Serialize<int>(sinFlag, name: "sin");
				if (s.Settings.Platform != GamePlatform.Vita) {
					curve = s.SerializeObject<Spline>(curve, name: "curve");
				}
			} else {
				input = s.SerializeObject<StringID>(input, name: "input");
				min = s.Serialize<float>(min, name: "min");
				max = s.Serialize<float>(max, name: "max");
				initialValue = s.Serialize<float>(initialValue, name: "initialValue");
				minValue = s.Serialize<float>(minValue, name: "minValue");
				maxValue = s.Serialize<float>(maxValue, name: "maxValue");
				mod = s.Serialize<bool>(mod, name: "mod");
				abs = s.Serialize<bool>(abs, name: "abs");
				add = s.Serialize<bool>(add, name: "add");
				sin = s.Serialize<bool>(sin, name: "sin");
				curve = s.SerializeObject<Spline>(curve, name: "curve");
			}
		}
	}
}

