namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class UIPadManager_Template : TemplateObj {
		public float snapDistanceWeight;
		public float snapDeadAngle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			snapDistanceWeight = s.Serialize<float>(snapDistanceWeight, name: "snapDistanceWeight");
			snapDeadAngle = s.Serialize<float>(snapDeadAngle, name: "snapDeadAngle");
		}
		public override uint? ClassCRC => 0x3ED7DB9C;
	}
}

