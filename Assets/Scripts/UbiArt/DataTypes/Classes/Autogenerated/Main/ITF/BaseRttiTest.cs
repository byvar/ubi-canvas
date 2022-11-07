namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class BaseRttiTest : CSerializable {
		public string Name;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Name = s.Serialize<string>(Name, name: "Name");
		}
		public override uint? ClassCRC => 0x39F2685A;
	}
}

