namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class RLC_Mission_Guard_Player_CheckFamily : RLC_Mission_Guard {
		public string playerFamily;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			playerFamily = s.Serialize<string>(playerFamily, name: "playerFamily");
		}
		public override uint? ClassCRC => 0x51A69AB0;
	}
}

