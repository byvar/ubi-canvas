namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class RLC_Creature_Guard_CheckMove : RLC_Mission_Guard {
		public string movetype;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			movetype = s.Serialize<string>(movetype, name: "movetype");
		}
		public override uint? ClassCRC => 0x530D2990;
	}
}

