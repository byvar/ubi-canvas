namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class Unknown_COL_19_sub_7957A0 : CSerializable {
		public Placeholder brightnessTable;
		public int enableCloth;
		public int enableCollisionCapsules;
		public float clothTeleportDistance;
		public int renderToTexture;
		public Placeholder rttMaterial;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			brightnessTable = s.SerializeObject<Placeholder>(brightnessTable, name: "brightnessTable");
			enableCloth = s.Serialize<int>(enableCloth, name: "enableCloth");
			enableCollisionCapsules = s.Serialize<int>(enableCollisionCapsules, name: "enableCollisionCapsules");
			clothTeleportDistance = s.Serialize<float>(clothTeleportDistance, name: "clothTeleportDistance");
			renderToTexture = s.Serialize<int>(renderToTexture, name: "renderToTexture");
			rttMaterial = s.SerializeObject<Placeholder>(rttMaterial, name: "rttMaterial");
		}
		public override uint? ClassCRC => 0x825B7536;
	}
}

