namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class ParCurve : CSerializable {
		public float baseTime = 1f;
		public Vec3d outputMin;
		public Vec3d outputMax = Vec3d.One;
		public Spline curve;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			baseTime = s.Serialize<float>(baseTime, name: "baseTime");
			outputMin = s.SerializeObject<Vec3d>(outputMin, name: "outputMin");
			outputMax = s.SerializeObject<Vec3d>(outputMax, name: "outputMax");
			curve = s.SerializeObject<Spline>(curve, name: "curve");
		}
		public override uint? ClassCRC => 0xF241D702;
	}
}

