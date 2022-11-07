namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class ShadowZonesComponent : ActorComponent {
		public GFXPrimitiveParam LightPrimitiveParameters;
		public GFXPrimitiveParam LightBackPrimitiveParameters;
		public GFXPrimitiveParam ShadowsPrimitiveParameters;
		public GFXPrimitiveParam ShadowsBackPrimitiveParameters;
		public float radius;
		public Angle angle;
		public Angle angleOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			LightPrimitiveParameters = s.SerializeObject<GFXPrimitiveParam>(LightPrimitiveParameters, name: "LightPrimitiveParameters");
			LightBackPrimitiveParameters = s.SerializeObject<GFXPrimitiveParam>(LightBackPrimitiveParameters, name: "LightBackPrimitiveParameters");
			ShadowsPrimitiveParameters = s.SerializeObject<GFXPrimitiveParam>(ShadowsPrimitiveParameters, name: "ShadowsPrimitiveParameters");
			ShadowsBackPrimitiveParameters = s.SerializeObject<GFXPrimitiveParam>(ShadowsBackPrimitiveParameters, name: "ShadowsBackPrimitiveParameters");
			radius = s.Serialize<float>(radius, name: "radius");
			angle = s.SerializeObject<Angle>(angle, name: "angle");
			angleOffset = s.SerializeObject<Angle>(angleOffset, name: "angleOffset");
		}
		public override uint? ClassCRC => 0xC2E066BD;
	}
}

