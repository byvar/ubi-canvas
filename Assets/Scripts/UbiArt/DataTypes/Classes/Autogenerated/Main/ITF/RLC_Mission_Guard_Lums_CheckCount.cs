namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class RLC_Mission_Guard_Lums_CheckCount : CSerializable {
		public uint lumCount;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			lumCount = s.Serialize<uint>(lumCount, name: "lumCount");
		}
		public override uint? ClassCRC => 0x9E8D98FE;
	}
}

