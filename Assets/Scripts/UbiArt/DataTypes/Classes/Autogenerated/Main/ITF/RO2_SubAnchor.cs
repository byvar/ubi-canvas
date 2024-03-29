namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class RO2_SubAnchor : CSerializable {
		public StringID name;
		public Vec3d pos;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			name = s.SerializeObject<StringID>(name, name: "name");
			pos = s.SerializeObject<Vec3d>(pos, name: "pos");
		}
	}
}

