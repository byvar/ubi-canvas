namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_LightMessageComponent_Template : CSerializable {
		[Description("Brush nib material")]
		public Placeholder brushNibMaterial;
		[Description("Interaction icon actor path")]
		public Path interactionIconActorPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			brushNibMaterial = s.SerializeObject<Placeholder>(brushNibMaterial, name: "brushNibMaterial");
			interactionIconActorPath = s.SerializeObject<Path>(interactionIconActorPath, name: "interactionIconActorPath");
		}
		public override uint? ClassCRC => 0xE46D871B;
	}
}

