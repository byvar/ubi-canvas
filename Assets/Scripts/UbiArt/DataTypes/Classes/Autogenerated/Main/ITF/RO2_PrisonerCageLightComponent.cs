namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_PrisonerCageLightComponent : RO2_AIComponent {
		public bool isBroken;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				isBroken = s.Serialize<bool>(isBroken, name: "isBroken");
			}
		}
		public override uint? ClassCRC => 0x60032DB8;
	}
}

