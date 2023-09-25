namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.VH | GameFlags.RA)]
	public partial class RO2_PagePortalComponent : RO2_TeleportPortalComponent {
		public float enterExitDist = 2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				enterExitDist = s.Serialize<float>(enterExitDist, name: "enterExitDist");
			}
		}
		public override uint? ClassCRC => 0x69DC1680;
	}
}

