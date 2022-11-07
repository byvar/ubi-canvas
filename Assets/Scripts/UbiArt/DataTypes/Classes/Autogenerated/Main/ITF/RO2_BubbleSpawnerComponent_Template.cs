namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_BubbleSpawnerComponent_Template : ActorComponent_Template {
		public Path bubblePath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			bubblePath = s.SerializeObject<Path>(bubblePath, name: "bubblePath");
		}
		public override uint? ClassCRC => 0x9A282E92;
	}
}

