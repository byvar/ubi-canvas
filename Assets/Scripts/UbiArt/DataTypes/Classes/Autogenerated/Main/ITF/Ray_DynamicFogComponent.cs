namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_DynamicFogComponent : ActorComponent {
		public bool useTempateFogParams;
		public Color dynamicFogColor;
		public float dynamicFogMaxDepth;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				useTempateFogParams = s.Serialize<bool>(useTempateFogParams, name: "useTempateFogParams");
				if (!useTempateFogParams) {
					dynamicFogColor = s.SerializeObject<Color>(dynamicFogColor, name: "dynamicFogColor");
					dynamicFogMaxDepth = s.Serialize<float>(dynamicFogMaxDepth, name: "dynamicFogMaxDepth");
				}
			}
		}
		public override uint? ClassCRC => 0x3104D334;
	}
}

