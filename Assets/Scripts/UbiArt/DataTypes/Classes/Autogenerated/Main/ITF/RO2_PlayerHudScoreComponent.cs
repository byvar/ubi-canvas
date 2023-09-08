namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_PlayerHudScoreComponent : GraphicComponent {
		public Path characterTexture;
		public GFXMaterialSerializable characterMaterial;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RL) {
				if (s.HasFlags(SerializeFlags.Flags8)) {
					characterTexture = s.SerializeObject<Path>(characterTexture, name: "characterTexture");
				}
				characterMaterial = s.SerializeObject<GFXMaterialSerializable>(characterMaterial, name: "characterMaterial");
			} else {
			}
		}
		public override uint? ClassCRC => 0x21BC5790;
	}
}

