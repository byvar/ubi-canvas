namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_450_sub_B88830 : RO2_AIComponent {
		public Vec3d beforeCamRelativeInitialPos;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags_xC0)) {
				beforeCamRelativeInitialPos = s.SerializeObject<Vec3d>(beforeCamRelativeInitialPos, name: "beforeCamRelativeInitialPos");
			}
		}
		public override uint? ClassCRC => 0x0C7AC209;
	}
}

