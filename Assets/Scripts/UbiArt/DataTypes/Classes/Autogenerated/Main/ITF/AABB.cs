namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.VH | GameFlags.RA)]
	public partial class AABB : CSerializable {
		public Vec2d MIN;
		public Vec2d MAX;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			MIN = s.SerializeObject<Vec2d>(MIN, name: "MIN");
			MAX = s.SerializeObject<Vec2d>(MAX, name: "MAX");
		}
	}
}

