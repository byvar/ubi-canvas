namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class ZInput : CSerializable {
		public StringID control;
		public StringID query;
		public Vec2d axis_range;
		public float threshold;
		public float delay;
		public float decreaseSpeed;
		public float increaseValue;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			control = s.SerializeObject<StringID>(control, name: "control");
			query = s.SerializeObject<StringID>(query, name: "query");
			axis_range = s.SerializeObject<Vec2d>(axis_range, name: "axis_range");
			threshold = s.Serialize<float>(threshold, name: "threshold");
			delay = s.Serialize<float>(delay, name: "delay");
			if (s.Settings.Game == Game.VH || s.Settings.Game == Game.RA) {
				decreaseSpeed = s.Serialize<float>(decreaseSpeed, name: "decreaseSpeed");
				increaseValue = s.Serialize<float>(increaseValue, name: "increaseValue");
			}
		}
	}
}

