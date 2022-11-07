namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class MusicPartSet_Template : CSerializable {
		public CListO<MusicPart_Template> parts;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			parts = s.SerializeObject<CListO<MusicPart_Template>>(parts, name: "parts");
		}
	}
}
