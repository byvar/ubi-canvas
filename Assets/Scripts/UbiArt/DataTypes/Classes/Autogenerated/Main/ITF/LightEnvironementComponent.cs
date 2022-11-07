namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class LightEnvironementComponent : CSerializable {
		public Vec3d LightDir0;
		public Vec3d LightDir1;
		public Vec3d LightDir2;
		public Color LightCol0;
		public Color LightCol1;
		public Color LightCol2;
		public Vec3d RimLightDirection;
		public Color RimLightColor;
		public Vec2d BoxSize;
		public float BoxFadeDist;
		public float LightColMultiplier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				LightDir0 = s.SerializeObject<Vec3d>(LightDir0, name: "LightDir0");
				LightDir1 = s.SerializeObject<Vec3d>(LightDir1, name: "LightDir1");
				LightDir2 = s.SerializeObject<Vec3d>(LightDir2, name: "LightDir2");
				LightCol0 = s.SerializeObject<Color>(LightCol0, name: "LightCol0");
				LightCol1 = s.SerializeObject<Color>(LightCol1, name: "LightCol1");
				LightCol2 = s.SerializeObject<Color>(LightCol2, name: "LightCol2");
				RimLightDirection = s.SerializeObject<Vec3d>(RimLightDirection, name: "RimLightDirection");
				RimLightColor = s.SerializeObject<Color>(RimLightColor, name: "RimLightColor");
				BoxSize = s.SerializeObject<Vec2d>(BoxSize, name: "BoxSize");
				BoxFadeDist = s.Serialize<float>(BoxFadeDist, name: "BoxFadeDist");
				LightColMultiplier = s.Serialize<float>(LightColMultiplier, name: "LightColMultiplier");
			}
		}
		public override uint? ClassCRC => 0x3292B7C1;
	}
}

