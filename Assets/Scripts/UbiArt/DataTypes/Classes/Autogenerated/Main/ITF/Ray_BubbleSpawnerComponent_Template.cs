namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR)]
	public partial class Ray_BubbleSpawnerComponent_Template : CSerializable {
		public Path bubblePath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			bubblePath = s.SerializeObject<Path>(bubblePath, name: "bubblePath");
		}
		public override uint? ClassCRC => 0xB3E59BA3;
	}
}

