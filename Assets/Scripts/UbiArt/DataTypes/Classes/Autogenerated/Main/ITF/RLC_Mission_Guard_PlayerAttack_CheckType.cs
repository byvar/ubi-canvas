namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class RLC_Mission_Guard_PlayerAttack_CheckType : RLC_Mission_Guard {
		public uint hitType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			hitType = s.Serialize<uint>(hitType, name: "hitType");
		}
		public override uint? ClassCRC => 0xA31C4830;
	}
}

