namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class RLC_Mission_Guard_Elixir_CheckType : RLC_Mission_Guard {
		public uint elixirType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			elixirType = s.Serialize<uint>(elixirType, name: "elixirType");
		}
		public override uint? ClassCRC => 0x5CE246BC;
	}
}

