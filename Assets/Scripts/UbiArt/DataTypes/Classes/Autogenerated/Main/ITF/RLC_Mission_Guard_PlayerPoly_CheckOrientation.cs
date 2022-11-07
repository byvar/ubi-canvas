namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class RLC_Mission_Guard_PlayerPoly_CheckOrientation : RLC_Mission_Guard {
		public uint edgeOrientation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			edgeOrientation = s.Serialize<uint>(edgeOrientation, name: "edgeOrientation");
		}
		public override uint? ClassCRC => 0xD7534FEA;
	}
}

