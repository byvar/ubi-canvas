namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.LegendsAndUp)]
	public partial class BoxInterpolatorComponent_Template : InterpolatorComponent_Template {
		public Placeholder innerAABB;
		public Placeholder outerAABB;
		public Angle AABBRotation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RO) {
				innerAABB = s.SerializeObject<Placeholder>(innerAABB, name: "innerAABB");
				outerAABB = s.SerializeObject<Placeholder>(outerAABB, name: "outerAABB");
				AABBRotation = s.SerializeObject<Angle>(AABBRotation, name: "AABBRotation");
			} else {
			}
		}
		public override uint? ClassCRC => 0x71F87656;
	}
}

