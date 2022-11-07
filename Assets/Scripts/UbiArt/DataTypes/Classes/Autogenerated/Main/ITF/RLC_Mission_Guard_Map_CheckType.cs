namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class RLC_Mission_Guard_Map_CheckType : RLC_Mission_Guard {
		public uint mapType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			mapType = s.Serialize<uint>(mapType, name: "mapType");
		}
		public override uint? ClassCRC => 0xCF8C03CE;
	}
}

