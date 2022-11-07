namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_StargateComponent : ActorComponent {
		public Vec2d doorOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				doorOffset = s.SerializeObject<Vec2d>(doorOffset, name: "doorOffset");
			}
		}
		public override uint? ClassCRC => 0x683BEF32;
	}
}

