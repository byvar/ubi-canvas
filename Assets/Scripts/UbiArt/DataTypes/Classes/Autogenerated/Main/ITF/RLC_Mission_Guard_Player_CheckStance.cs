namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class RLC_Mission_Guard_Player_CheckStance : RLC_Mission_Guard {
		public uint stance;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			stance = s.Serialize<uint>(stance, name: "stance");
		}
		public override uint? ClassCRC => 0x77F683AC;
	}
}

