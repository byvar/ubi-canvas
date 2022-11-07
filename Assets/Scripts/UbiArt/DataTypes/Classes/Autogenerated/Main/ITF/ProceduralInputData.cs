namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class ProceduralInputData : CSerializable {
		public StringID input;
		public float min;
		public float max;
		public float initialValue;
		public float minValue;
		public float maxValue;
		public bool mod;
		public bool abs;
		public bool add;
		public bool sin;
		// The mod, abs, add and sin values are based on one flag. Before serializing, the game code splits them
		// In Adventures, the values are bitshifted so they are always 0 or 1
		// In Legends, the values are not bitshifted, so they are 0 or 1, 2, 4, or 8.
		public int modFlag; // 0 or 1
		public int absFlag; // 0 or 2
		public int addFlag; // 0 or 4
		public int sinFlag; // 0 or 8
		public Spline curve;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RJR || s.Settings.game == Settings.Game.RFR || s.Settings.game == Settings.Game.RO) {
				input = s.SerializeObject<StringID>(input, name: "input");
				min = s.Serialize<float>(min, name: "min");
				max = s.Serialize<float>(max, name: "max");
				minValue = s.Serialize<float>(minValue, name: "minValue");
				maxValue = s.Serialize<float>(maxValue, name: "maxValue");
				modFlag = s.Serialize<int>(modFlag, name: "mod");
				absFlag = s.Serialize<int>(absFlag, name: "abs");
				addFlag = s.Serialize<int>(addFlag, name: "add");
			} else if (s.Settings.game == Settings.Game.VH || s.Settings.game == Settings.Game.RL || s.Settings.game == Settings.Game.COL) {
				input = s.SerializeObject<StringID>(input, name: "input");
				min = s.Serialize<float>(min, name: "min");
				max = s.Serialize<float>(max, name: "max");
				minValue = s.Serialize<float>(minValue, name: "minValue");
				maxValue = s.Serialize<float>(maxValue, name: "maxValue");
				modFlag = s.Serialize<int>(modFlag, name: "mod");
				absFlag = s.Serialize<int>(absFlag, name: "abs");
				addFlag = s.Serialize<int>(addFlag, name: "add");
				sinFlag = s.Serialize<int>(sinFlag, name: "sin");
				curve = s.SerializeObject<Spline>(curve, name: "curve");
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

