namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_WaterHandsAIComponent : Ray_AIComponent {
		public float rangeMaxDetect;
		public int isDead;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				rangeMaxDetect = s.Serialize<float>(rangeMaxDetect, name: "rangeMaxDetect");
			}
			if (s.HasFlags(SerializeFlags.Persistent)) {
				isDead = s.Serialize<int>(isDead, name: "isDead");
			}
		}
		public override uint? ClassCRC => 0x28FBB2C1;
	}
}

