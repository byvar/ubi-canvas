namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class EdgeFluidLevel : CSerializable {
		public uint IdEdgeFluid;
		public EdgeData Data;
		public Transform2d Xf;
		public float Scale = 1f;
		public CListO<FluidFriseLayer> LayerInfos;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			IdEdgeFluid = s.Serialize<uint>(IdEdgeFluid, name: "IdEdgeFluid");
			Data = s.SerializeObject<EdgeData>(Data, name: "Data");
			Xf = s.SerializeObject<Transform2d>(Xf, name: "Xf");
			Scale = s.Serialize<float>(Scale, name: "Scale");
			LayerInfos = s.SerializeObject<CListO<FluidFriseLayer>>(LayerInfos, name: "LayerInfos");
		}
	}
}

