namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_UIMenuAutoMurphyChoiceComponent_Template : CSerializable {
		public Path murphyIconPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			murphyIconPath = s.SerializeObject<Path>(murphyIconPath, name: "murphyIconPath");
		}
		public override uint? ClassCRC => 0x8697A56D;
	}
}

