namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class AABB3d : CSerializable {
		public Vec3d MIN;
		public Vec3d MAX;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			MIN = s.SerializeObject<Vec3d>(MIN, name: "MIN");
			MAX = s.SerializeObject<Vec3d>(MAX, name: "MAX");
		}
	}
}

