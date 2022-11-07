namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_GroundEnemyAIComponent : RO2_AIComponent {
		public bool useRaycast;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			useRaycast = s.Serialize<bool>(useRaycast, name: "useRaycast");
		}
		public override uint? ClassCRC => 0xCAAFC949;
	}
}

