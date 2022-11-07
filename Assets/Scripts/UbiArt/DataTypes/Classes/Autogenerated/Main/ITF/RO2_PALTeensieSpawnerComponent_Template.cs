namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_PALTeensieSpawnerComponent_Template : ActorComponent_Template {
		public StringID helpFX;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			helpFX = s.SerializeObject<StringID>(helpFX, name: "helpFX");
		}
		public override uint? ClassCRC => 0x1F9E6AE9;
	}
}

