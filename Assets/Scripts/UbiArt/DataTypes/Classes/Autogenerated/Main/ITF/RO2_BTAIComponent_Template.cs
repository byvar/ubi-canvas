namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTAIComponent_Template : BTAIComponent_Template {
		public int health = 100;
		public CArrayP<uint> damageLevels;
		public bool useHealth;

		public uint Vita_faction { get; set; }

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			health = s.Serialize<int>(health, name: "health");
			damageLevels = s.SerializeObject<CArrayP<uint>>(damageLevels, name: "damageLevels");
			useHealth = s.Serialize<bool>(useHealth, name: "useHealth");
			if (s.Settings.platform == Settings.Platform.Vita) {
				Vita_faction = s.Serialize<uint>(Vita_faction, name: nameof(Vita_faction));
			}
		}
		public override uint? ClassCRC => 0x3100A2DA;
	}
}

