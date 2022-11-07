namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_FireflyCloudComponent : ActorComponent {
		public bool isActivated;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				isActivated = s.Serialize<bool>(isActivated, name: "isActivated");
			}
		}
		public override uint? ClassCRC => 0xF6DA8761;
	}
}

