namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_PhialBTComponent_Template : BTAIComponent_Template {
		public Generic<Event> reward;
		public Path fx;
		public int air;

		public uint factionVITA;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Platform == GamePlatform.Vita) {
				factionVITA = s.Serialize<uint>(factionVITA, name: nameof(factionVITA));
			}
			reward = s.SerializeObject<Generic<Event>>(reward, name: "reward");
			fx = s.SerializeObject<Path>(fx, name: "fx");
			air = s.Serialize<int>(air, name: "air");
		}
		public override uint? ClassCRC => 0x4F73A6C1;
	}
}

