namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class CircleInterpolatorComponent : InterpolatorComponent {
		public float innerRadius;
		public float outerRadius;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.COL) {
				innerRadius = s.Serialize<float>(innerRadius, name: "innerRadius");
				outerRadius = s.Serialize<float>(outerRadius, name: "outerRadius");
			} else {
			}
		}
		public override uint? ClassCRC => 0xBA81CB26;
	}
}

