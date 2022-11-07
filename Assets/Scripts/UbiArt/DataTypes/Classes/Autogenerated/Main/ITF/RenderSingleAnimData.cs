namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class RenderSingleAnimData : SingleAnimData {
		public float xMin;
		public float yMin;
		public uint state;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			xMin = s.Serialize<float>(xMin, name: "xMin");
			yMin = s.Serialize<float>(yMin, name: "yMin");
			state = s.Serialize<uint>(state, name: "state");
		}
		public override uint? ClassCRC => 0xAD846A09;
	}
}

