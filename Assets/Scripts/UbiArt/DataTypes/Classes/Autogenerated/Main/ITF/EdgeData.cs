namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class EdgeData : CSerializable {
		public float Level;
		public float Pos;
		public int Way;
		public bool CutUV;
		public float HeightScale;
		public float HeightScaleTotal;
		public float HeightPos;
		public float PosZ;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Level = s.Serialize<float>(Level, name: "Level");
			Pos = s.Serialize<float>(Pos, name: "Pos");
			Way = s.Serialize<int>(Way, name: "Way");
			CutUV = s.Serialize<bool>(CutUV, name: "CutUV");
			HeightScale = s.Serialize<float>(HeightScale, name: "HeightScale");
			HeightScaleTotal = s.Serialize<float>(HeightScaleTotal, name: "HeightScaleTotal");
			HeightPos = s.Serialize<float>(HeightPos, name: "HeightPos");
			PosZ = s.Serialize<float>(PosZ, name: "PosZ");
		}
	}
}

