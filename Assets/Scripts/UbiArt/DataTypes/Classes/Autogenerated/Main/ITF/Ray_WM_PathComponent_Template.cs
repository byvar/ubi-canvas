namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class Ray_WM_PathComponent_Template : CSerializable {
		public Path Path__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Path__0 = s.SerializeObject<Path>(Path__0, name: "Path__0");
		}
		public override uint? ClassCRC => 0xB9958FCB;
	}
}

