namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.VH | GameFlags.RA)]
	public partial class BlendTreeBranchWeight : CSerializable {
		public float weight = 1f;
		public ProceduralInputData proceduralWeight;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			weight = s.Serialize<float>(weight, name: "weight");
			proceduralWeight = s.SerializeObject<ProceduralInputData>(proceduralWeight, name: "proceduralWeight");
		}
	}
}

