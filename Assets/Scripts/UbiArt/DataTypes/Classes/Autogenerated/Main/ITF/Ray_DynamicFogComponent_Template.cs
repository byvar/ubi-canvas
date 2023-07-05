namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_DynamicFogComponent_Template : ActorComponent_Template {
		public int useDynamicFog;
		public Color dynamicFogDefaultColor;
		public float dynamicFogMaxDepth;
		public int isDataOnly;
		public int isModifier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			useDynamicFog = s.Serialize<int>(useDynamicFog, name: "useDynamicFog");
			dynamicFogDefaultColor = s.SerializeObject<Color>(dynamicFogDefaultColor, name: "dynamicFogDefaultColor");
			dynamicFogMaxDepth = s.Serialize<float>(dynamicFogMaxDepth, name: "dynamicFogMaxDepth");
			isDataOnly = s.Serialize<int>(isDataOnly, name: "isDataOnly");
			isModifier = s.Serialize<int>(isModifier, name: "isModifier");
		}
		public override uint? ClassCRC => 0x7C8B6190;
	}
}

