namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class RLC_TreeOptimGraph : CSerializable {
		public Path OptimPath;
		public Vec3d OptimPos;
		public float OptimLoadMin;
		public float OptimLoadMax;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			OptimPath = s.SerializeObject<Path>(OptimPath, name: "OptimPath");
			OptimPos = s.SerializeObject<Vec3d>(OptimPos, name: "OptimPos");
			OptimLoadMin = s.Serialize<float>(OptimLoadMin, name: "OptimLoadMin");
			OptimLoadMax = s.Serialize<float>(OptimLoadMax, name: "OptimLoadMax");
		}
		public override uint? ClassCRC => 0x6EF4AFC3;
	}
}

