namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_SoccerTeamIconComponent_Template : GraphicComponent_Template {
		public float transitionTime;
		public GFXMaterialSerializable frameMaterial;
		public Vec2d frameSize;
		public GFXMaterialSerializable luigiMaterial;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RL) {
				transitionTime = s.Serialize<float>(transitionTime, name: "transitionTime");
				frameMaterial = s.SerializeObject<GFXMaterialSerializable>(frameMaterial, name: "frameMaterial");
				frameSize = s.SerializeObject<Vec2d>(frameSize, name: "frameSize");
				luigiMaterial = s.SerializeObject<GFXMaterialSerializable>(luigiMaterial, name: "luigiMaterial");
			} else {
				transitionTime = s.Serialize<float>(transitionTime, name: "transitionTime");
				frameMaterial = s.SerializeObject<GFXMaterialSerializable>(frameMaterial, name: "frameMaterial");
				frameSize = s.SerializeObject<Vec2d>(frameSize, name: "frameSize");
			}
		}
		public override uint? ClassCRC => 0xEE1D6665;
	}
}

