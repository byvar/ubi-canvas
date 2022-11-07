namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class SubRenderParam : CSerializable {
		public bool Enable;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Enable = s.Serialize<bool>(Enable, name: "Enable");
		}
		public override uint? ClassCRC => 0xDE8F531A;
	}
}

