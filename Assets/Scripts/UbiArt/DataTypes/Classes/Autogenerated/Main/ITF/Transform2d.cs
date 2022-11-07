namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class Transform2d : CSerializable {
		public matrix2d Rot;
		public Vec2d Pos;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Rot = s.SerializeObject<matrix2d>(Rot, name: "Rot");
			Pos = s.SerializeObject<Vec2d>(Pos, name: "Pos");
		}
	}
}

