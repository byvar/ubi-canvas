namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_WM_SpotComponent : CSerializable {
		public StringID tag;
		public int isStandSwim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			tag = s.SerializeObject<StringID>(tag, name: "tag");
			isStandSwim = s.Serialize<int>(isStandSwim, name: "isStandSwim");
		}
		public override uint? ClassCRC => 0xCD2A03CA;
	}
}

