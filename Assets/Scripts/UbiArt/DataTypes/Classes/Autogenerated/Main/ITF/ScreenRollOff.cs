namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion | GameFlags.RLVersion)]
	public partial class ScreenRollOff : SoundModifier {
		public float distanceMin;
		public float distanceMax;
		public bool useMetricUnit;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RL || s.Settings.Game == Game.COL) {
				distanceMin = s.Serialize<float>(distanceMin, name: "distanceMin");
				distanceMax = s.Serialize<float>(distanceMax, name: "distanceMax");
				useMetricUnit = s.Serialize<bool>(useMetricUnit, name: "useMetricUnit");
			} else {
				distanceMin = s.Serialize<float>(distanceMin, name: "distanceMin");
				distanceMax = s.Serialize<float>(distanceMax, name: "distanceMax");
			}
		}
		public override uint? ClassCRC => 0x4EDC3030;
	}
}

